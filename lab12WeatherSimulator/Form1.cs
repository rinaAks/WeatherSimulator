using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Accord.Math;

namespace lab12WeatherSimulator
{
    public partial class Form1 : Form
    {
        bool buttonValue;
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonValue = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        int weatherState;
        int day;

        //интенсивности переходов матрицей инфинитезимальных коэффициентов:
        double[,] transitionRateMatrix =
        {
            {-0.4, 0.3, 0.1},
            {0.4, -0.8, 0.4},
            {0.1, 0.4, -0.5}
        };
        //диагональные элементы равны отрицательной сумме не диагональных в строке

        double[] theorProb = new double [3];
        double[] empiricProb = new double[3];

        Random rnd = new Random();
        private void btStart_Click(object sender, EventArgs e)
        {
            day = 0;
            buttonValue = true;
            weatherState = 1;
            lbTheor.Visible = false; lbTheor.Text = "Теоретические вероятности: ";
            lbEmpir.Visible = false; lbEmpir.Text = "Эмпирические вероятности:  ";
            for (int i = 0; i < theorProb.Length; i++)
            {
                theorProb[i] = 0;
                empiricProb[i] = 0;
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, weatherState);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buttonValue)
            {
                day++;
                //weatherState = rnd.Next(1, 4) - 1; //рандом от 0 до 2
                
                weatherState = changeState(weatherState);
                changePicture(weatherState);

                chart1.Series[0].Points.AddXY(day, weatherState);

                if (weatherState >= 0 && weatherState <= 2) empiricProb[weatherState] += 1;
                lbDays.Text = day.ToString();
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            buttonValue = false;
            for(int i = 0; i < empiricProb.Length; i++)
            {
                lbEmpir.Text += (Math.Round(empiricProb[i]/day, 2)).ToString() + "   ";
            }
            lbTheor.Visible = true;
            lbEmpir.Visible = true;
            timer1.Stop();
        }

        public void changePicture(int state)
        {
            switch (state)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.sun_with_glasses;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.cloud;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.rain;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.error_pic;
                    break;

            }
        }
        
        public int changeState(int oldState)
        {
            double sum = 0;
            double a = rnd.NextDouble();
            for (int i = 0; i < 3; i++)
            {
                sum += Math.Abs(transitionRateMatrix[oldState, i]);
                if (a < sum) return i;
            }
            return 2;
        }
    }
}
