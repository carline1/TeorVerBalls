using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeorVerBalls2
{
    public partial class BallsForm : Form
    {
        Random rnd = new Random();
        public BallsForm()
        {
            InitializeComponent();
            PictureBox[] images = new PictureBox[]
            {
                left_black,
                left_white,
                right_black,
                right_white
            };

            // возращаем все шары на за экран
            for (int i = 0; i < images.Length; i++)
            {
                images[i].Left = -100;
                images[i].Top = 0;
            }
        }

        /*int l1 = 40;  // запоминаем left позицию шара первого бокса, чтобы потом вернуть его обратно
        int t1 = 34;  // запоминаем top позицию шара  первого бокса, чтобы потом вернуть его обратно
        int n1 = 0;  // запоминаем номер шара в первом массиве, тобы вернуть ему расположение

        int l2 = 980;  // запоминаем left позицию шара второго бокса, чтобы потом вернуть его обратно
        int t2 = 34;  // запоминаем top позицию шара  второго бокса, чтобы потом вернуть его обратно
        int n2 = 0;  // запоминаем номер шара во втором массиве, тобы вернуть ему расположение*/

        int ww = 0;  // кол-во комбинаций белый белый
        int wb = 0;  // кол-во комбинаций белый черный
        int bb = 0;  // кол-во комбинаций черный черный

        int n1;
        int n2;
        double pred;

        int tests = 0;  // кол-во испытаний

        int nextLocate_ww = 1;
        int nextLocate_wb = 1;
        int nextLocate_bb = 1;

        public int quant_balls;
        public int quant_black;

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] images = new PictureBox[]
            {
                left_black,
                left_white,
                right_black,
                right_white
            };

            int[] balls = new int[quant_balls];
            for (int i = 0; i < quant_balls; i++)
            {
                if (i < quant_black)
                    balls[i] = 1;
                else
                    balls[i] = 0;
            }

            if (iterations.Text == "")
                error_msg.Visible = true;
            else if (Int32.Parse(iterations.Text) < 1)
                error_msg.Visible = true;
            else
            {
                error_msg.Visible = false;
                for (int n = 0; n < Int32.Parse(iterations.Text); n++)
                {
                    tests++;
                    label4.Text = "Всего испытаний: " + tests;

                    // возращаем все шары на за экран
                    for (int i = 0; i < images.Length; i++)
                    {
                        images[i].Left = -100;
                        images[i].Top = 0;
                    }

                    // Вытаскиваем шары
                    n1 = balls[rnd.Next(0, 9)];
                    if (n1 == 0)
                    {
                        left_white.Left = 216;
                        left_white.Top = 408;
                    }
                    else
                    {
                        left_black.Left = 216;
                        left_black.Top = 408;
                    }

                    n2 = balls[rnd.Next(0, 9)];
                    if (n2 == 0)
                    {
                        right_white.Left = 322;
                        right_white.Top = 408;
                    }
                    else
                    {
                        right_black.Left = 322;
                        right_black.Top = 408;
                    }

                    pred = (double)ww / (double)tests;
                    predict.Text = "P(ww) = " + pred.ToString("F6");

                    // меняем таблички-счетчики
                    if (n1 == 0 & n2 == 0)
                    {
                        ww++;
                        label1.Text = "Белый белый: " + ww;
                        // График
                        chart1.Series["ww"].Points.AddXY(1, nextLocate_ww);
                        nextLocate_ww++;
                    }
                    else if ((n1 == 0 & n2 == 1) | (n1 == 1 & n2 == 0))
                    {
                        wb++;
                        label2.Text = "Белый черный: " + wb;
                        chart1.Series["wb"].Points.AddXY(2, nextLocate_wb);
                        nextLocate_wb++;
                    }
                    else if (n1 == 1 & n2 == 1)
                    {
                        bb++;
                        label3.Text = "Черный черный: " + bb;
                        chart1.Series["bb"].Points.AddXY(3, nextLocate_bb);
                        nextLocate_bb++;
                    }
                }
            }
        }

        private void CloseButton_Clic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tests = 0;

            nextLocate_ww = 1;
            nextLocate_wb = 1;
            nextLocate_bb = 1;

            ww = 0;
            wb = 0;
            bb = 0;

            label4.Text = "Всего испытаний: " + tests;
            label1.Text = "Белый белый: " + ww;
            label2.Text = "Белый черный: " + wb;
            label3.Text = "Черный черный: " + bb;
            predict.Text = "P(ww) = " + 0;

            chart1.Series["ww"].Points.Clear();
            chart1.Series["wb"].Points.Clear();
            chart1.Series["bb"].Points.Clear();

            PictureBox[] images = new PictureBox[]
            {
                left_black,
                left_white,
                right_black,
                right_white
            };

            for (int i = 0; i < images.Length; i++)
            {
                images[i].Left = -100;
                images[i].Top = 0;
            }
        }

        protected void BallsForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
