using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{

    struct Layers
    {
        public Color color;
        public int thickness;
        public DashStyle style;
        public List<PointF> graph;
    }
    class Painter
    {
        public double xmin, xmax, ymin, ymax, stepx, stepy;       
        public bool scalling=true, vertical_line=false;
        public int x_selected;
        public int text_count;


        private double X(double width, double x)
        {
            return width / (xmax - xmin) * (x - xmin);
        }

        private double Y(double height, double y)
        {
            return -height / (ymax - ymin) * (y - ymax);
        }

       

        private void Scale(List <Layers> layers)
        {
            if (layers.Count != 0)
            {
                double xmax_b = 0, xmin_b = 0, ymax_b = 0, ymin_b = 0;
                for (int i = 0; i < layers.Count; i++)
                {
                    for (int j = 0; j < layers[i].graph.Count; j++)
                    {
                        if (layers[i].graph[j].X < xmin_b) xmin_b = layers[i].graph[j].X;
                        if (layers[i].graph[j].X > xmax_b) xmax_b = layers[i].graph[j].X;
                        if (layers[i].graph[j].Y < ymin_b) ymin_b = layers[i].graph[j].Y;
                        if (layers[i].graph[j].Y > ymax_b) ymax_b = layers[i].graph[j].Y;
                    }
                }


                if (ymax_b > Math.Abs(ymin_b / 14)) ymax_b += ymax_b / 8;
                else ymax_b = -ymin_b / 14 - ymin_b / 14 / 8;

                if (ymin_b > -Math.Abs(ymax_b / 14)) ymin_b = -ymax_b / 14;

                xmax = xmax_b;
                ymax = ymax_b;
                xmin = xmin_b;
                ymin = ymin_b;
            }
            stepy = (Math.Abs((double)ymin) + Math.Abs((double)ymax)) / 7;
            stepx = (Math.Abs((double)xmin) + Math.Abs((double)xmax)) / 7;
        }



        public Bitmap Draw
            (double xmin_p, double xmax_p, double ymin_p, double ymax_p,
            int width, int height,
            List <Layers> layers,
            bool isscale,
            int textCount)
        {
            text_count = textCount;
            scalling = isscale;
            xmax = xmax_p;
            xmin = xmin_p;
            ymax = ymax_p;
            ymin = ymin_p;

            stepy = (Math.Abs((double)ymin) + Math.Abs((double)ymax)) / 10;
            stepx = (Math.Abs((double)xmin) + Math.Abs((double)xmax)) / 10;

            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            String str;
            Font font = new Font("Arial", 8);

            SolidBrush brush_background = new SolidBrush(Color.Black);
            SolidBrush brush_text = new SolidBrush(Color.White);


            Pen pen_osi = new Pen(Color.White, 3);
            pen_osi.DashStyle = DashStyle.Solid;
            pen_osi.EndCap = LineCap.ArrowAnchor;

            Pen pen_setka = new Pen(Color.SlateGray, 1);
            pen_setka.DashStyle = DashStyle.Dot;
            
                        
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;            
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.FillRectangle(brush_background, 0, 0, width, height);

           if(scalling) Scale(layers);

           //рисую ось
            g.DrawLine(pen_osi, (float)X(width, xmin), (float)Y(height, 0), (float)X(width, xmax), (float)Y(height, 0));
            g.DrawLine(pen_osi, (float)X(width, 0), (float)Y(height,ymin), (float)X(width, 0), (float)Y(height, ymax));

            //рисую сетку

            //право вертикаль
            for (double i = stepx; i <=xmax; i += stepx)
            {
                g.DrawLine(pen_setka, (float)X(width, i), (float)Y(height,ymin), (float)X(width, i), (float)Y(height,ymax));
            }
            //лево вертикаль
            for (double i = 0; i >= xmin; i -= stepx)
            {
                g.DrawLine(pen_setka, (float) X(width, i), (float) Y(height,  ymin), (float) X(width, i), (float) Y(height,  ymax));
            }
            //верх горизонталь
            for (double i =  stepy; i <=  ymax; i +=  stepy)
            {
                g.DrawLine(pen_setka, (float) X(width,  xmin), (float) Y(height, i), (float) X(width,  xmax), (float) Y(height, i));
            }
            //низ горизонталь
            for (double i = - stepy; i >=  ymin; i -=  stepy)
            {
                g.DrawLine(pen_setka, (float) X(width,  xmin), (float) Y(height, i), (float) X(width,  xmax), (float) Y(height, i));
            }


            //подписываю оси
           

            

            //вправо
            for (double i = 0; i <=  xmax; i +=  stepx)
            {
                str = i.ToString("F"+textCount.ToString());
                g.DrawString(str, font, brush_text, (float) X(width, i)+2, height-14);
            }
            //влево
            for (double i = - stepx; i >=  xmin+stepx; i -=  stepx)
            {
                str = i.ToString("F" + textCount.ToString());
                g.DrawString(str, font, brush_text, (float) X(width, i)+2, height-14);
            }

            //вверх
            for (double i =  stepy; i <=  ymax; i +=  stepy)
            {
                str = i.ToString("F3");
                g.DrawString(str, font, brush_text, 2, (float) Y(height, i) + 2);
            }

            //вверх
            for (double i = 0; i >=  ymin; i -=  stepy)
            {
                str = i.ToString("F3");
                g.DrawString(str, font, brush_text, 2, (float) Y(height, i) + 2);
            }

            if(layers.Count!=0)
            {
                for (int i=0; i<layers.Count;i++)
                {
                    Pen pen_graph = new Pen(layers[i].color, layers[i].thickness);
                    pen_graph.DashStyle = layers[i].style;

                    for(int j=0; j<layers[i].graph.Count-1;j++)
                    {
                        g.DrawLine(pen_graph, (float)X(width, layers[i].graph[j].X), (float)Y(height, layers[i].graph[j].Y), 
                            (float)X(width, layers[i].graph[j+1].X), (float)Y(height, layers[i].graph[j+1].Y));

                    }
                }
            }

            if (vertical_line)
            {
                Pen pen_line = new Pen(Color.Red, 3);
                g.DrawLine(pen_line, (float)X(width, layers[0].graph[x_selected].X), (float)Y(height, ymin),
                            (float)X(width, layers[0].graph[x_selected].X), (float)Y(height, ymax));
            }
            return bmp;
        }
    }
}
