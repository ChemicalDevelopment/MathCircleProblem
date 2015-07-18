namespace MathCircleProblem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mathSurface = new System.Windows.Forms.Panel();
            this.nudThetaDegrees = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudThetaRadians = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumberOfPoints = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button7 = new System.Windows.Forms.Button();
            this.nudSeriesIncrement = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudThetaDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThetaRadians)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesIncrement)).BeginInit();
            this.SuspendLayout();
            // 
            // mathSurface
            // 
            this.mathSurface.BackColor = System.Drawing.Color.White;
            this.mathSurface.Location = new System.Drawing.Point(183, 22);
            this.mathSurface.Name = "mathSurface";
            this.mathSurface.Size = new System.Drawing.Size(500, 500);
            this.mathSurface.TabIndex = 0;
            this.mathSurface.Paint += new System.Windows.Forms.PaintEventHandler(this.mathSurface_Paint);
            // 
            // nudThetaDegrees
            // 
            this.nudThetaDegrees.DecimalPlaces = 1;
            this.nudThetaDegrees.Location = new System.Drawing.Point(25, 83);
            this.nudThetaDegrees.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudThetaDegrees.Name = "nudThetaDegrees";
            this.nudThetaDegrees.Size = new System.Drawing.Size(120, 20);
            this.nudThetaDegrees.TabIndex = 1;
            this.nudThetaDegrees.ValueChanged += new System.EventHandler(this.nudThetaDegrees_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theta Angle (Degrees)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Theta Angle (Radians)";
            // 
            // nudThetaRadians
            // 
            this.nudThetaRadians.DecimalPlaces = 3;
            this.nudThetaRadians.Enabled = false;
            this.nudThetaRadians.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudThetaRadians.Location = new System.Drawing.Point(25, 139);
            this.nudThetaRadians.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudThetaRadians.Name = "nudThetaRadians";
            this.nudThetaRadians.Size = new System.Drawing.Size(120, 20);
            this.nudThetaRadians.TabIndex = 4;
            this.nudThetaRadians.ValueChanged += new System.EventHandler(this.nudThetaRadians_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "30";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "45";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "60";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "90";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(25, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of points";
            // 
            // nudNumberOfPoints
            // 
            this.nudNumberOfPoints.DecimalPlaces = 1;
            this.nudNumberOfPoints.Enabled = false;
            this.nudNumberOfPoints.Location = new System.Drawing.Point(25, 399);
            this.nudNumberOfPoints.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nudNumberOfPoints.Name = "nudNumberOfPoints";
            this.nudNumberOfPoints.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfPoints.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 500);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Go Nuts";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(704, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(561, 618);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(25, 458);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Chart";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nudSeriesIncrement
            // 
            this.nudSeriesIncrement.DecimalPlaces = 1;
            this.nudSeriesIncrement.Location = new System.Drawing.Point(106, 461);
            this.nudSeriesIncrement.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudSeriesIncrement.Name = "nudSeriesIncrement";
            this.nudSeriesIncrement.Size = new System.Drawing.Size(71, 20);
            this.nudSeriesIncrement.TabIndex = 16;
            this.nudSeriesIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 652);
            this.Controls.Add(this.nudSeriesIncrement);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNumberOfPoints);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudThetaRadians);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudThetaDegrees);
            this.Controls.Add(this.mathSurface);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudThetaDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThetaRadians)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesIncrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mathSurface;
        private System.Windows.Forms.NumericUpDown nudThetaDegrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudThetaRadians;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumberOfPoints;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown nudSeriesIncrement;




    }
}

