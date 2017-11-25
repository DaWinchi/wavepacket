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
            NBox.Text = "512";

        }

        Painter painter = new Painter();
        List<Layers> layers = new List<Layers>();
        List<PointF> sinus = new List<PointF>();
        int size=0;
        List<List<Complex>> data_fure = new List<List<Complex>>();
        Complex[] data_for_fure;
        WaveFunction wave;
        bool is_create_fourier = false;

        private void Run_Click(object sender, EventArgs e)
        {
            if (is_create_fourier) is_create_fourier = false;
            wave = new WaveFunction(double.Parse(ABox.Text), double.Parse(X0Box.Text), double.Parse(SigmaBox.Text),
               double.Parse(SteptBox.Text), double.Parse(RBox.Text), double.Parse(V0Box.Text), double.Parse(AlphaBox.Text));
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
            MomentBar.Minimum = 0;
            MomentBar.Maximum = wave.ReturnCountPoints();
            MomentBar.Value = MomentBar.Maximum / 2;

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
                    Complex buf = new Complex { Re = layer.graph[i].Y, Im = 0 };
                    data_fure[i].Add(buf);
                }

                FureProgress.Value = (int)((double)data_fure[0].Count / size * 100);
                if (data_fure[0].Count == size) { is_create_fourier = false; MomentBar.Enabled = true; }
            }
            layers[1] = layer;
            WaveBox.Image = painter.Draw(-2, 2, -1, 20, WaveBox.Width, WaveBox.Height, layers, true);
        }



        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            is_create_fourier = false;
        }

        private void SearchFure_Click(object sender, EventArgs e)
        {
            MomentBar.Enabled = false;
            is_create_fourier = true;
            data_fure.Clear();
            size = int.Parse(NBox.Text);
            data_for_fure = new Complex[size];


        }

        private void MomentBar_Scroll(object sender, EventArgs e)
        {
            if ((data_fure[0].Count == size)&&(size!=0))
            {

            }
        }
    }
}
