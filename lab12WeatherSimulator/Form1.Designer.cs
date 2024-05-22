namespace lab12WeatherSimulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTheor = new System.Windows.Forms.Label();
            this.lbEmpir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbEmpir);
            this.panel1.Controls.Add(this.lbTheor);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 0;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(189, 40);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(96, 23);
            this.btStop.TabIndex = 8;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(52, 40);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(114, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.Maximum = 3D;
            chartArea2.AxisY.Minimum = -1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Состояние погоды";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1022, 515);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(832, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 75);
            this.label4.TabIndex = 9;
            this.label4.Text = "0 – ясно\r\n1 – облачно\r\n2 – пасмурно";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(831, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbTheor
            // 
            this.lbTheor.AutoSize = true;
            this.lbTheor.Location = new System.Drawing.Point(386, 23);
            this.lbTheor.Name = "lbTheor";
            this.lbTheor.Size = new System.Drawing.Size(44, 16);
            this.lbTheor.TabIndex = 9;
            this.lbTheor.Text = "label1";
            this.lbTheor.Visible = false;
            // 
            // lbEmpir
            // 
            this.lbEmpir.AutoSize = true;
            this.lbEmpir.Location = new System.Drawing.Point(386, 57);
            this.lbEmpir.Name = "lbEmpir";
            this.lbEmpir.Size = new System.Drawing.Size(44, 16);
            this.lbEmpir.TabIndex = 10;
            this.lbEmpir.Text = "label2";
            this.lbEmpir.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Прошло дней:";
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(846, 40);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(14, 16);
            this.lbDays.TabIndex = 12;
            this.lbDays.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Weather Modeling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEmpir;
        private System.Windows.Forms.Label lbTheor;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label label1;
    }
}

