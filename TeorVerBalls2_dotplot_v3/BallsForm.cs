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

        int ww = 0;  // кол-во комбинаций белый белый
        int wb = 0;  // кол-во комбинаций белый черный
        int bb = 0;  // кол-во комбинаций черный черный

        int n1;
        int n2;
        double pred;  // Частота выпадения комбинации ww

        int tests = 0;  // кол-во испытаний

        int nextLocate_ww = 1;
        int nextLocate_wb = 1;
        int nextLocate_bb = 1;

        public int quant_balls;
        public int quant_black;

        int past_pos_trackbar = 0;  // прошлая позиция трекбара - нужно чтобы продолжалась старая цепочка испытаний, а не создавалась новая
        int new_pos_trackbar;  // кол-во испытаний, который нужно прибавить

        private void CloseButton_Clic(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // обнуление всего
        private void reset_Click(object sender, EventArgs e)
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
            predict.Text = "Ѡ(ww) = " + 0;

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

        private void button2_Click(object sender, EventArgs e)
        {
            reset_Click(sender, e);
            trackBar1.Value = 0;
            bar_value.Text = "0";
            iterations.Text = "1";
            trackBar1.LargeChange = 1;
        }

        protected void BallsForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            bar_value.Text = "" + trackBar1.Value;
        }

        // боковой правый текстовый бар - показывает максимальное значение трэкбара
        private void iterations_TextChanged(object sender, EventArgs e)
        {
            if (iterations.Text == "")
                error_msg.Visible = true;
            else if (iterations.Text == "-")
                { }
            else if (Int32.Parse(iterations.Text) < 1)
                error_msg.Visible = true;
            else
            {
                error_msg.Visible = false;
                Controls.AddRange(new Control[] { bar_value, trackBar1 });
                trackBar1.Scroll += new EventHandler(trackBar1_Scroll);
                trackBar1.Maximum = Int32.Parse(iterations.Text);
                trackBar1.TickFrequency = 1;
                trackBar1.LargeChange = 5;
                trackBar1.SmallChange = 1;
            }
        }

        // центральный текстовый бар - показывает текущее значение трэкбара
        private void bar_value_TextChanged(object sender, EventArgs e)
        {
            if (bar_value.Text == "")
                error_msg2.Visible = true;
            else if (bar_value.Text == "-")
                { }
            else if ((Int32.Parse(bar_value.Text) < 0) || (Int32.Parse(bar_value.Text) > Int32.Parse(iterations.Text)))
                error_msg2.Visible = true;
            else
            {
                error_msg2.Visible = false;
                trackBar1.Value = Int32.Parse(bar_value.Text);
                trackBar1_Scroll_1(sender, e);
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
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

            if (trackBar1.Value >= past_pos_trackbar)
                new_pos_trackbar = trackBar1.Value - past_pos_trackbar;
            else
            {
                reset_Click(sender, e);
                new_pos_trackbar = trackBar1.Value;
            }   

            for (int n = 0; n < new_pos_trackbar; n++)
            {
                tests++;
                label4.Text = "Всего испытаний: " + tests;

                // возращаем все шары на за экран
                for (int i = 0; i < images.Length; i++)
                {
                    images[i].Left = -100;
                    images[i].Top = 0;
                }

                // Вытаскиваем шары из первой коробки
                n1 = balls[rnd.Next(0, 9)];
                if (n1 == 0)
                {
                    left_white.Left = 216;
                    left_white.Top = 348;
                }
                else
                {
                    left_black.Left = 216;
                    left_black.Top = 348;
                }

                // Вытаскиваем шары из второй коробки
                n2 = balls[rnd.Next(0, 9)];
                if (n2 == 0)
                {
                    right_white.Left = 322;
                    right_white.Top = 348;
                }
                else
                {
                    right_black.Left = 322;
                    right_black.Top = 348;
                }

                // меняем таблички-счетчики
                if (n1 == 0 & n2 == 0)
                {
                    ww++;
                    label1.Text = "Белый белый: " + ww;
                    chart1.Series["ww"].Points.AddXY(1, nextLocate_ww);  // График
                    nextLocate_ww++;
                }
                else if ((n1 == 0 & n2 == 1) | (n1 == 1 & n2 == 0))
                {
                    wb++;
                    label2.Text = "Белый черный: " + wb;
                    chart1.Series["wb"].Points.AddXY(2, nextLocate_wb);  // График
                    nextLocate_wb++;
                }
                else if (n1 == 1 & n2 == 1)
                {
                    bb++;
                    label3.Text = "Черный черный: " + bb;
                    chart1.Series["bb"].Points.AddXY(3, nextLocate_bb);  // График
                    nextLocate_bb++;
                }

                pred = (double)ww / (double)tests;
                predict.Text = "Ѡ(ww) = " + pred.ToString("F6");
            }
            past_pos_trackbar = trackBar1.Value;
        }
    }
}
