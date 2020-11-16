namespace TeorVerBalls2
{
    partial class BallsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BallsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.left_white = new System.Windows.Forms.PictureBox();
            this.right_white = new System.Windows.Forms.PictureBox();
            this.right_black = new System.Windows.Forms.PictureBox();
            this.left_black = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iterations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.predict = new System.Windows.Forms.Label();
            this.error_msg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bar_value = new System.Windows.Forms.TextBox();
            this.error_msg2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.left_white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_white
            // 
            this.left_white.Image = ((System.Drawing.Image)(resources.GetObject("left_white.Image")));
            this.left_white.Location = new System.Drawing.Point(216, 348);
            this.left_white.Name = "left_white";
            this.left_white.Size = new System.Drawing.Size(100, 100);
            this.left_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_white.TabIndex = 1;
            this.left_white.TabStop = false;
            this.left_white.Tag = "white";
            // 
            // right_white
            // 
            this.right_white.Image = ((System.Drawing.Image)(resources.GetObject("right_white.Image")));
            this.right_white.Location = new System.Drawing.Point(322, 242);
            this.right_white.Name = "right_white";
            this.right_white.Size = new System.Drawing.Size(100, 100);
            this.right_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_white.TabIndex = 1;
            this.right_white.TabStop = false;
            this.right_white.Tag = "white";
            // 
            // right_black
            // 
            this.right_black.Enabled = false;
            this.right_black.Image = ((System.Drawing.Image)(resources.GetObject("right_black.Image")));
            this.right_black.Location = new System.Drawing.Point(322, 348);
            this.right_black.Name = "right_black";
            this.right_black.Size = new System.Drawing.Size(100, 100);
            this.right_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_black.TabIndex = 1;
            this.right_black.TabStop = false;
            this.right_black.Tag = "black";
            // 
            // left_black
            // 
            this.left_black.Image = ((System.Drawing.Image)(resources.GetObject("left_black.Image")));
            this.left_black.Location = new System.Drawing.Point(216, 242);
            this.left_black.Name = "left_black";
            this.left_black.Size = new System.Drawing.Size(100, 100);
            this.left_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_black.TabIndex = 1;
            this.left_black.TabStop = false;
            this.left_black.Tag = "black";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(193, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Всего испытаний: 0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BackImageTransparentColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(587, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 15;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "ww";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 15;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "wb";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 15;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "bb";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(544, 582);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(510, 499);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(71, 20);
            this.iterations.TabIndex = 4;
            this.iterations.Text = "1";
            this.iterations.TextChanged += new System.EventHandler(this.iterations_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(507, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Макс. знач";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Белый белый: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Белый черный: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Черный черный: 0";
            // 
            // predict
            // 
            this.predict.AutoSize = true;
            this.predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predict.Location = new System.Drawing.Point(83, 232);
            this.predict.Name = "predict";
            this.predict.Size = new System.Drawing.Size(93, 24);
            this.predict.TabIndex = 2;
            this.predict.Text = "P(ww) = 0";
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_msg.ForeColor = System.Drawing.Color.Red;
            this.error_msg.Location = new System.Drawing.Point(507, 537);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(74, 18);
            this.error_msg.TabIndex = 7;
            this.error_msg.Text = "Ошибка!";
            this.error_msg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(284, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Текущ. знач";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(286, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(33, 464);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(560, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // bar_value
            // 
            this.bar_value.Location = new System.Drawing.Point(286, 499);
            this.bar_value.Name = "bar_value";
            this.bar_value.Size = new System.Drawing.Size(71, 20);
            this.bar_value.TabIndex = 11;
            this.bar_value.Text = "0";
            this.bar_value.TextChanged += new System.EventHandler(this.bar_value_TextChanged);
            // 
            // error_msg2
            // 
            this.error_msg2.AutoSize = true;
            this.error_msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_msg2.ForeColor = System.Drawing.Color.Red;
            this.error_msg2.Location = new System.Drawing.Point(284, 537);
            this.error_msg2.Name = "error_msg2";
            this.error_msg2.Size = new System.Drawing.Size(74, 18);
            this.error_msg2.TabIndex = 12;
            this.error_msg2.Text = "Ошибка!";
            this.error_msg2.Visible = false;
            // 
            // BallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 606);
            this.Controls.Add(this.bar_value);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.error_msg2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.predict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.right_white);
            this.Controls.Add(this.left_black);
            this.Controls.Add(this.right_black);
            this.Controls.Add(this.left_white);
            this.Name = "BallsForm";
            this.Text = "Balls";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BallsForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.left_white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox left_white;
        private System.Windows.Forms.PictureBox right_white;
        private System.Windows.Forms.PictureBox right_black;
        private System.Windows.Forms.PictureBox left_black;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label predict;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox bar_value;
        private System.Windows.Forms.Label error_msg2;
    }
}

