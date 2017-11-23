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

namespace DynamicWave
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WaveBox.Image = painter.Draw(-1, 10, -10, 100, WaveBox.Width, WaveBox.Height, layers, true);
            RBox.Text = "2";
            ABox.Text = "1";
            V0Box.Text = "1";
            SigmaBox.Text = "0,5";
            X0Box.Text = "1";
            SteptBox.Text = "0,001";
            AlphaBox.Text = "5";

        }

        Painter painter = new Painter();
        List<Layers> layers = new List<Layers>();
        List<PointF> sinus = new List<PointF>();
        WaveFunction wave;
        private void Run_Click(object sender, EventArgs e)
        {
           wave = new WaveFunction(double.Parse(ABox.Text), double.Parse(X0Box.Text), double.Parse(SigmaBox.Text),
              double.Parse(SteptBox.Text), double.Parse(RBox.Text), double.Parse(V0Box.Text), double.Parse(AlphaBox.Text) );
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

            layers.Add(layer);
            layers.Add(layer2);
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
            layers[0] = layer;
            WaveBox.Image = painter.Draw(-2, 2, -1, 20, WaveBox.Width, WaveBox.Height, layers, true);
        }

        private void WaveBox_MouseClick(object sender, MouseEventArgs e)
        {
            wave.selected_x = painter.ReturnSelectedX(e.X, WaveBox.Width, WaveBox.Height);
            wave.is_seleced_x = true;
            painter.vertical_line = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
