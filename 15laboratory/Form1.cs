using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15laboratory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool start = false;
        double time = 0;
        double next = 0;
        int curWeather = 0;
        int nextWeather = 0;
        Random random = new Random();
        double[] masFreq = new double[3] { 0, 0, 0 };
        int sum = 0;

        double[,] matrix = new double[3, 3] { { -0.4, 0.3, 0.1 },
                                              { 0.4, -0.8, 0.4 },
                                              { 0.1, 0.4, -0.5 } };

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (start)
            {
                timer1.Stop();
                button_Start.Text = "Start";
                start = false;
                for (int i = 0; i < 3; i++)
                {
                    masFreq[i] = masFreq[i] / sum;
                }
                label_Freq0.Text = "Freq0: " + masFreq[0].ToString();
                label_Freq1.Text = "Freq1: " + masFreq[1].ToString();
                label_Freq2.Text = "Freq2: " + masFreq[2].ToString();
            }
            else
            {
                timer1.Start();
                button_Start.Text = "Stop";
                start = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            label_day.Text = "Day: " + Math.Truncate(time / 24).ToString();
            label_hour.Text = " hour: " + (Math.Truncate(time) % 24).ToString();
            masFreq[nextWeather]++;
            sum++;
            if (time > next)
            {
                switch (nextWeather)
                {
                    case 0:
                        label_weather.Text = "Clear";
                        break;
                    case 1:
                        label_weather.Text = "Cloudy";
                        break;
                    case 2:
                        label_weather.Text = "Overcast";
                        break;
                }

                double rnd = random.NextDouble();
                double d = Math.Log(rnd) / matrix[curWeather, curWeather];
                next = time + d;
                rnd = random.NextDouble();

                for (int i = 0; i < 3; i++)
                {
                    if (i != curWeather)
                    {
                        rnd += matrix[curWeather, i] / matrix[curWeather, curWeather];
                    }
                    if (rnd < 0)
                    {
                        nextWeather = i;
                        curWeather = i;
                        break;
                    }
                }
            }
        }
    }
}
