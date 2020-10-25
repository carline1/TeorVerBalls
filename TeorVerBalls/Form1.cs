using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeorVerBalls
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        int l = 33;
        int t = 68;
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] images = new PictureBox[9]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9
            };
            images[n].Left = l;
            images[n].Top = t;

            n = rnd.Next(0, 8);
            l = images[n].Left;
            t = images[n].Top;
            images[n].Left = 473;
            images[n].Top = 359;
        }
    }
}
