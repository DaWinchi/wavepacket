﻿using Jenyay.Mathematics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicWave
{
    class WaveFunction
    {
        public double Vo = 1, alph = 5, d=100;
        private double step_t, step_x, R;
        private int K = 300, a = 30;

        List<double> x = new List<double>();
        List<Complex> A = new List<Complex>();
        List<Complex> B = new List<Complex>();
        List<Complex> C = new List<Complex>();
        List<Complex> D = new List<Complex>();
        List<Complex> alpha = new List<Complex>();
        List<Complex> beta = new List<Complex>();
        List<Complex> KSI = new List<Complex>();
        List<Complex> U = new List<Complex>();
        List<Complex> f_x = new List<Complex>();

        public WaveFunction(double A, double x0, double sgm, double step_time, double r, double v0, double alpha, double deep)
        {
            d = deep;
            step_t = step_time;
            Vo = v0;
            R = r;
            alph = alpha;
            Create_x();
            Create_U_x();
            Create_f_x();
            Initialization_KSI(A, x0, sgm);

        }

        private void Create_f_x()
        {
            f_x.Clear();
            List<double> sigma = new List<double>();
            for (int i = 0; i < a; i++)
            {
                double buf = (x[i] + Math.Abs(x[a])) * (x[i] + Math.Abs(x[a]));
                sigma.Add(buf);
            }

            for (int i = a; i < K - a; i++)
            {
                sigma.Add(0);
            }

            for (int i = K - a; i <= K; i++)
            {
                double buf = (x[i] - Math.Abs(x[a])) * (x[i] - Math.Abs(x[a]));
                sigma.Add(buf);
            }

            //создаю функцию, отвечающую за прозрачность стенок
            double gamma = 1;
            for (int i = 0; i <= K; i++)
            {
                Complex znam = new Complex { Re = 1, Im = gamma * sigma[i] };
                Complex buf = new Complex();
                buf = 1 / znam;
                f_x.Add(buf);
            }

        }
        private void Create_x()
        {
            x.Clear();
            step_x = (double)2 * R / (K + 1);
            for (double k = -R; k <= R; k += step_x)
            {
                x.Add(k);
            }
        }

        private void Create_U_x()
        {
            U.Clear();

            for (int i = 0; i <= K; i++)
            {
                Complex cmplx = new Complex { Re = 0, Im = 0 };
                U.Add(cmplx);
            }


            for (int i = a; i < K - a; i++)
            {
                Complex cmplx = new Complex
                {
                    Re = Vo * Math.Sin(alph * x[i]) * Math.Sin(alph * x[i]) -d,
                    Im = 0
                };
                U[i] = cmplx;
            }

        }

        private void Initialization_KSI(double A, double x0, double sigma)
        {
            KSI.Clear();
            for (int i = 0; i <= K; i++)
            {
                Complex cmplx = new Complex
                {
                    Re = A * Math.Exp(-(x[i] - x0) * (x[i] - x0) / 4 / sigma / sigma),
                    Im = 0
                };
                KSI.Add(cmplx);
            }
        }

        private void Create_A()
        {
            A.Clear();
            Complex cm = new Complex(0, 0);
            A.Add(cm);
            for (int i = 1; i < K; i++)
            {
                Complex buf = new Complex();
                buf = -step_t / step_x / step_x / 2 * f_x[i] * f_x[i - 1];
                Complex cmplx = new Complex
                {
                    Re = -buf.Im,
                    Im = buf.Re
                };
                A.Add(cmplx);
            }
        }

        private void Create_B()
        {
            B.Clear();
            Complex cm = new Complex(0, 0);
            B.Add(cm);
            for (int i = 1; i < K; i++)
            {
                Complex buf = new Complex();
                buf = -step_t / step_x / step_x / 2 * f_x[i] * f_x[i + 1];
                Complex cmplx = new Complex
                {
                    Re = -buf.Im,
                    Im = buf.Re
                };
                B.Add(cmplx);
            }
        }

        private void Create_C()
        {
            C.Clear();
            Complex cm = new Complex(0, 0);
            C.Add(cm);
            for (int i = 1; i < K; i++)
            {
                Complex buf = new Complex();
                buf = step_t * U[i] / 2 +
                    step_t * f_x[i] * (f_x[i + 1] +
                    f_x[i - 1]) / step_x / step_x / 2;
                Complex cmplx = new Complex
                {
                    Re = -buf.Im + 1,
                    Im = buf.Re
                };
                C.Add(cmplx);
            }
        }

        private void Create_D()
        {
            D.Clear();
            Complex cm = new Complex(0, 0);
            D.Add(cm);
            for (int i = 1; i < K; i++)
            {

                Complex buf;
                buf = step_t / 2 *
                    (
                        f_x[i] *
                        (f_x[i + 1] * (KSI[i + 1] - KSI[i]) - f_x[i - 1] * (KSI[i] - KSI[i - 1])) / step_x / step_x - U[i] * KSI[i]
                   );
                Complex cmplx = new Complex
                {
                    Re = -buf.Im,
                    Im = buf.Re
                };
                cmplx += KSI[i];
                D.Add(cmplx);
            }
        }

        private void Create_ab()
        {
            alpha.Clear();
            beta.Clear();
            Complex cm = new Complex(0, 0);
            alpha.Add(cm);
            alpha.Add(cm);
            beta.Add(cm);
            beta.Add(cm);

            for (int i = 2; i <= K; i++)
            {
                Complex cmplx_a = new Complex();
                cmplx_a = B[i - 1] / (C[i - 1] + A[i - 1] * alpha[i - 1]) * (-1);
                alpha.Add(cmplx_a);

                Complex cmplx_b = new Complex();
                cmplx_b = (D[i - 1] - A[i - 1] * beta[i - 1]) / (C[i - 1] + A[i - 1] * alpha[i - 1]);
                beta.Add(cmplx_b);
            }
        }

        private void Create_new_KSI()
        {
            KSI[K] = 0;

            for (int i = K - 1; i >= 0; i--)
            {
                KSI[i] = alpha[i + 1] * KSI[i + 1] + beta[i + 1];
            }
        }

        public List<PointF> NextWave()
        {
            List<PointF> wave = new List<PointF>();
            Create_A();
            Create_B();
            Create_C();
            Create_D();
            Create_ab();
            Create_new_KSI();

            for (int i = 0; i <= K; i++)
            {
                PointF point = new PointF
                {
                    X = (float)x[i],
                    Y = (float)KSI[i].Abs
                };
                wave.Add(point);
            }
            return wave;
        }

        public List<PointF> Get_U()
        {
            List<PointF> wave = new List<PointF>();
            float max_ksi = 0, max_u = 0;
            for (int i = 0; i <= K; i++)
            {
                if (KSI[i].Abs > max_ksi) max_ksi = (float)KSI[i].Abs;
                if (U[i].Abs > max_u) max_u = (float)U[i].Abs;

            }
            for (int i = 0; i <= K; i++)
            {
                PointF point = new PointF
                {
                    X = (float)x[i],
                    Y = (float)U[i].Abs / max_u*max_ksi
                };
                wave.Add(point);
            }
            return wave;
        }


        public List<Complex> Get_KSI()
        {
            return KSI;
        }
        public int ReturnCountPoints()
        {
            return K;
        }


        public List<double> ReturnMapX()
        {
            return x;
        }


    }
}
