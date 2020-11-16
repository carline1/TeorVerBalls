namespace TeorVerBalls2
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quant_balls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quant_black = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.error_msg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_Closed);
            this.SuspendLayout();
            // 
            // quant_balls
            // 
            this.quant_balls.Location = new System.Drawing.Point(81, 100);
            this.quant_balls.Name = "quant_balls";
            this.quant_balls.Size = new System.Drawing.Size(280, 20);
            this.quant_balls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество шаров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество черных";
            // 
            // quant_black
            // 
            this.quant_black.Location = new System.Drawing.Point(81, 211);
            this.quant_black.Name = "quant_black";
            this.quant_black.Size = new System.Drawing.Size(280, 20);
            this.quant_black.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "(остальные будут белыми)";
            // 
            // start_button
            // 
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(145, 271);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(151, 41);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_msg.ForeColor = System.Drawing.Color.Red;
            this.error_msg.Location = new System.Drawing.Point(184, 326);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(74, 18);
            this.error_msg.TabIndex = 6;
            this.error_msg.Text = "Ошибка!";
            this.error_msg.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(76, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "в каждой коробке";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 363);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quant_black);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quant_balls);
            this.Name = "SetForm";
            this.Text = "SetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label error_msg;
        public System.Windows.Forms.TextBox quant_balls;
        public System.Windows.Forms.TextBox quant_black;
        private System.Windows.Forms.Label label4;
    }
}