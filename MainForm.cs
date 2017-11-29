using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painting;
using System.Drawing.Drawing2D;
using Jenyay.Mathematics;
using System.Threading;

namespace DynamicWave
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WaveBox.Image = painter.Draw(-1, 10, -10, 100, WaveBox.Width, WaveBox.Height, layers, true, 2);
            SpectrBox.Image = painter_fure.Draw(-1, 10, -10, 100, SpectrBox.Width, SpectrBox.Height, layers_fure, true, 3);
            SingleWaveBox.Image = painter_own_func.Draw(-1, 10, -10, 100, SingleWaveBox.Width, SingleWaveBox.Height, layers_own_functions, true, 2);

            RBox.Text = "2";
            ABox.Text = "1";
            V0Box.Text = "-1";
            SigmaBox.Text = "0,05";
            X0Box.Text = "0";
            SteptBox.Text = "0,01";
            AlphaBox.Text = "5";
            NBox.Text = "256";

        }



        Thread threadCreaterOfSpectr;

        Painter painter = new Painter();
        Painter painter_fure = new Painter();
        Painter painter_own_func = new Painter();
        List<Layers> layers = new List<Layers>();
        List<Layers> layers_fure = new List<Layers>();
        List<Layers> layers_own_functions = new List<Layers>();

        List<Complex> KSI = new List<Complex>();

        static object lockerDF = new object();
        static List<List<PointF>> data_furePic = new List<List<PointF>>();
        static List<List<PointF>> data_own_func = new List<List<PointF>>();

        static int size = 0;
        static float stept = 0;
        static bool isSpectrDone = false;
        static List<double> xx = new List<double>();
        static List<List<Complex>> data_fure = new List<List<Complex>>();

        WaveFunction wave;
        bool is_create_fourier = false;

        private void Run_Click(object sender, EventArgs e)
        {            
            if (is_create_fourier) is_create_fourier = false;
            wave = new WaveFunction(double.Parse(ABox.Text), double.Parse(X0Box.Text), double.Parse(SigmaBox.Text),
               double.Parse(SteptBox.Text), double.Parse(RBox.Text), double.Parse(V0Box.Text), double.Parse(AlphaBox.Text));


            stept = float.Parse(SteptBox.Text);
            xx.AddRange(wave.ReturnMapX());

            layers.Clear();
            Layers layer = new Layers
            {
                color = Color.Yellow,
                style = DashStyle.Solid,
                thickness = 3,
                graph = wave.NextWave()
            };

            Layers layer2 = new Layers
            {
                color = Color.LightBlue,
                style = DashStyle.Solid,
                thickness = 3,
                graph = wave.Get_U()
            };


            layers.Add(layer2);
            layers.Add(layer);

            MomentBar.Enabled = false;
            
            MomentBar.Minimum = 1;
            MomentBar.Maximum = wave.ReturnCountPoints()-1;
            MomentBar.Value = MomentBar.Maximum / 2;


            isSpectrDone = false;
            streamFure.Text = "Создайте спектры...";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Layers layer = new Layers
            {
                color = Color.Yellow,
                style = DashStyle.Solid,
                thickness = 3,
                graph = wave.NextWave()
            };

            Layers layer2 = new Layers
            {
                color = Color.LightBlue,
                style = DashStyle.Solid,
                thickness = 3,
                graph = wave.Get_U()
            };

            KSI.Clear();
            KSI.AddRange(wave.Get_KSI());

            if (isSpectrDone) { streamFure.Text = "Спектры готовы!"; MomentBar_Scroll(sender, e); FureBar_Scroll(sender, e); isSpectrDone = false; }

            if (is_create_fourier)
            {

                if (data_fure.Count == 0)
                {
                    for (int i = 0; i < layer.graph.Count; i++)
                    {
                        List<Complex> buf = new List<Complex>();
                        data_fure.Add(buf);
                    }
                }

                for (int i = 0; i < layer.graph.Count; i++)
                {
                    Complex buf = new Complex { Re = KSI[i].Re, Im = KSI[i].Im };
                    data_fure[i].Add(buf);
                }

                FureProgress.Value = (int)((double)data_fure[0].Count / size * 100);
                if (data_fure[0].Count == size)
                {
                    //threadCreaterOfSpectr= new Thread(Create_spectr);
                    if (!threadCreaterOfSpectr.IsAlive) threadCreaterOfSpectr.Start();
                    
                    is_create_fourier = false;
                    MomentBar.Enabled = true;
                    isSpectrDone = false;

                    threadCreaterOfSpectr.Join();
                }
                
            }
            layers[0] = layer2;
            layers[1] = layer;
            WaveBox.Image = painter.Draw(-2, 2, -1, 20, WaveBox.Width, WaveBox.Height, layers, true, 2);
            
        }

        static private void Create_spectr()
        {
            lock (lockerDF)
            {
                data_furePic.Clear();
                data_own_func.Clear();
                float step = (float)1 / size/stept;
                for (int i = 0; i < data_fure.Count; i++)
                {

                    Complex[] buf = new Complex[size];
                    for (int j = 0; j < size; j++)
                    {
                        buf[j] = data_fure[i][j];
                    }



                    buf = Fourier.FFT(buf);


                    for (int j = 0; j < size; j++)
                    {
                        data_fure[i][j] = buf[j];
                    }

                    List<PointF> buf_vector = new List<PointF>();
                    for (int j = 0; j < size; j++)
                    {
                        PointF point = new PointF { X = j * step, Y = (float)data_fure[i][j].Abs };
                        buf_vector.Add(point);
                    }
                    data_furePic.Add(buf_vector);

                }


                for (int i = 0; i < size; i++) //-2 ибо не считаю спектры с концов, там всякий шум копится
                {
                    List<PointF> buf_list = new List<PointF>();
                    for (int j=0; j< data_furePic.Count; j++)
                    {
                        PointF buf = new PointF { X = (float)xx[j], Y = (float)data_fure[j][i].Re };
                        buf_list.Add(buf);
                    }
                    data_own_func.Add(buf_list);

                }
                isSpectrDone = true;
            }

            return;

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            is_create_fourier = false;
        }

        private void SearchFure_Click(object sender, EventArgs e)
        {
            threadCreaterOfSpectr = new Thread(Create_spectr);

            MomentBar.Enabled = false;
            is_create_fourier = true;
            isSpectrDone = false;
            data_fure.Clear();
            size = int.Parse(NBox.Text);
            streamFure.Text = "Создание спектров...";

            FureBar.Enabled = false;
            FureBar.Minimum = 0;
            FureBar.Maximum = size - 2;
            FureBar.Value = FureBar.Value / 2;

        }

        private void MomentBar_Scroll(object sender, EventArgs e)
        {
            painter.vertical_line = true;
            painter.x_selected = MomentBar.Value;

            layers_fure.Clear();
            Layers layer_fure = new Layers
            {
                color = Color.Yellow,
                style = DashStyle.Solid,
                thickness = 3,
                graph = data_furePic[MomentBar.Value]
            };

            layers_fure.Add(layer_fure);
            SpectrBox.Image = painter_fure.Draw(-1, 10, -10, 100, SpectrBox.Width, SpectrBox.Height, layers_fure, true, 2);
            FureBar.Enabled = true;
        }

        private void FureBar_Scroll(object sender, EventArgs e)
        {
            painter_fure.vertical_line = true;
            painter_fure.x_selected = FureBar.Value;

            layers_fure.Clear();
            Layers layer_fure = new Layers
            {
                color = Color.Yellow,
                style = DashStyle.Solid,
                thickness = 3,
                graph = data_furePic[MomentBar.Value]
            };

            layers_fure.Add(layer_fure);
            SpectrBox.Image = painter_fure.Draw(-1, 10, -10, 100, SpectrBox.Width, SpectrBox.Height, layers_fure, true, 2);

            layers_own_functions.Clear();
            Layers layer_own = new Layers
            {
                color = Color.Yellow,
                style = DashStyle.Solid,
                thickness = 3,
                graph = data_own_func[FureBar.Value]
            };

            layers_own_functions.Add(layer_own);


            SingleWaveBox.Image = painter_own_func.Draw(-1, 10, -10, 100, SingleWaveBox.Width, SingleWaveBox.Height, layers_own_functions, true, 2);
        }

       
    }
}
