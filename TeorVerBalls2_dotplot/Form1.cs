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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f2.Show();
        }
        Form2 f2;

        int l1 = 40;  // запоминаем left позицию шара первого бокса, чтобы потом вернуть его обратно
        int t1 = 34;  // запоминаем top позицию шара  первого бокса, чтобы потом вернуть его обратно
        int n1 = 0;  // запоминаем номер шара в первом массиве, тобы вернуть ему расположение

        int l2 = 980;  // запоминаем left позицию шара второго бокса, чтобы потом вернуть его обратно
        int t2 = 34;  // запоминаем top позицию шара  второго бокса, чтобы потом вернуть его обратно
        int n2 = 0;  // запоминаем номер шара во втором массиве, тобы вернуть ему расположение
        int ww = 0;  // кол-во комбинаций белый белый
        int wb = 0;  // кол-во комбинаций белый черный
        int bb = 0;  // кол-во комбинаций черный черный

        int tests = 0;  // кол-во испытаний

        int nextLocate_ww = 0;
        int nextLocate_wb = 0;
        int nextLocate_bb = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            tests++;
            label4.Text = "Всего испытаний: " + tests;

            PictureBox[] images1 = new PictureBox[9]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
            };
            // возращаем прошлый шар на место
            images1[n1].Left = l1;  
            images1[n1].Top = t1;  

            // рандомим следующий шар и запоминаем его исходную позицию
            n1 = rnd.Next(0, 9);
            l1 = images1[n1].Left;
            t1 = images1[n1].Top;
            images1[n1].Left = 465;
            images1[n1].Top = 407;


            PictureBox[] images2 = new PictureBox[9]
            {
                pictureBox10,
                pictureBox11,
                pictureBox12,
                pictureBox13,
                pictureBox14,
                pictureBox15,
                pictureBox16,
                pictureBox17,
                pictureBox18,
            };
            images2[n2].Left = l2;
            images2[n2].Top = t2;

            n2 = rnd.Next(0, 9);
            l2 = images2[n2].Left;
            t2 = images2[n2].Top;
            images2[n2].Left = 571;
            images2[n2].Top = 407;

            // меняем таблички-счетчики
            if ((string)images1[n1].Tag == "white" & (string)images2[n2].Tag == "white")
            {
                ww++;
                label1.Text = "Белый белый: " + ww;
                // График
                f2.chart1.Series["ww"].Points.AddXY(1, nextLocate_ww);
                nextLocate_ww++;
            }
            else if ((string)images1[n1].Tag == "white" & (string)images2[n2].Tag == "black" | (string)images1[n1].Tag == "black" & (string)images2[n2].Tag == "white")
            {
                wb++;
                label2.Text = "Белый черный: " + wb;
                f2.chart1.Series["wb"].Points.AddXY(2, nextLocate_wb);
                nextLocate_wb++;
            }
            else if ((string)images1[n1].Tag == "black" & (string)images2[n2].Tag == "black")
            {
                bb++;
                label3.Text = "Черный черный: " + bb;
                f2.chart1.Series["bb"].Points.AddXY(3, nextLocate_bb);
                nextLocate_bb++;
            }
        }
    }
}
