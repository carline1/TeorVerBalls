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
    public partial class SetForm : Form
    {
        public SetForm()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (quant_black.Text == "" || quant_balls.Text == "") 
                error_msg.Visible = true;
            else if ((Int32.Parse(quant_black.Text) > Int32.Parse(quant_balls.Text)) || 
                Int32.Parse(quant_black.Text) < 1 || Int32.Parse(quant_balls.Text) < 1)
                error_msg.Visible = true;
            else
            {
                error_msg.Visible = false;
                BallsForm ballsform = new BallsForm();
                ballsform.quant_balls = Int32.Parse(quant_balls.Text);
                ballsform.quant_black = Int32.Parse(quant_black.Text);
                this.Hide();
                ballsform.Show();
            }
        }

        protected void SetForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
