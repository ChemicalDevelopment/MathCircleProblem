using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathCircleProblem
{
    public partial class Form1 : Form
    {
        private const double SCALE = 200; // pixels to math scale
        private readonly double _radius;
        private double _theta;
        private Color _color = Color.Green;
        private double _slop = .0001f;
        private readonly Dictionary<decimal, int> _results = new Dictionary<decimal, int>();
        private readonly Bitmap _mathSurface = new Bitmap(500, 500);
        public Form1()
        {
            InitializeComponent();
            _radius = 1 * SCALE;

            double degrees = 45;
            _theta = (double)(degrees * Math.PI / 180);

            nudThetaDegrees.Value = (decimal)degrees;
            nudThetaRadians.Value = (decimal)_theta;

            if (!DesignMode)
            {
                //SetDoubleBuffered(mathSurface);
                // SetDoubleBuffered(this);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void DisplayImage()
        {
            DrawImage();
            pictureBox1.Image = _mathSurface;
        }

        private void DrawImage()
        {
            
            //Graphics g = mathSurface.CreateGraphics();
            //var g = new Graphics()
           // mathSurface = new Bitmap(500, 500);
            
            Graphics g = Graphics.FromImage(_mathSurface);
            g.Clear(Color.White);

            DrawAxesAndCircle(g);

            DrawLines(g);
        }

        private PointF GetNthPoint(int n)
        {
            var angleToDraw = Math.PI - 2 * ((Math.PI / 2f - _theta)) * n;

            float y = (float)Math.Sin(angleToDraw);
            float x = (float)Math.Cos(angleToDraw);
            
            return new PointF(x, y);
        }

        private List<PointF> GetPoints()
        {
            List<PointF> points = new List<PointF>();

            //HACK arbitrary max number of points here
            var maxPoints = 720;
            //var maxPoints = 100;
            for (int idx = 0; idx < maxPoints; idx++)
            {
                var point = GetNthPoint(idx);
                points.Add(point);

                if (idx > 0)
                {
                    if (Math.Abs(point.Y) < _slop && Math.Abs(point.X - (-1)) < _slop)
                    {

                        return points;
                    }
                }
            }

            return points;
        }

        private void DrawLines(Graphics g)
        {
            Pen p = new Pen(_color, 2);
            var points = GetPoints();
            PointF lastPoint = new PointF(-1, 0); //Start at left part of circle

            for (int idx = 0; idx < points.Count; idx++)
            {
                var point = points[idx];

                DrawMathLine(g, p, lastPoint.X, lastPoint.Y, point.X, point.Y);

                lastPoint = point;
            }

            //HACK subtract 1, since the points contains our original point
            nudNumberOfPoints.Value = points.Count - 1;
        }

        private double DegreesToRadians(double deg)
        {
            return (double)(deg * Math.PI / 180.0);
        }

        private double RadiansToDegrees(double rad)
        {
            return (double)(rad * 180.0 / Math.PI);
        }

        private void DrawMathLine(Graphics g, Pen p, double x1, double y1, double x2, double y2)
        {
            g.DrawLine(p, MathXtoScreenX(x1), MathYtoScreenY(y1), MathXtoScreenX(x2), MathYtoScreenY(y2));
        }

        private void DrawAxesAndCircle(Graphics g)
        {
            Pen myPen = new Pen(Color.Black, 2);

            DrawMathLine(g, myPen, -2, (0), (2), (0));
            DrawMathLine(g, myPen, (0), (-2), (0), (2));

            var x = MathXtoScreenX(0);
            var y = MathYtoScreenY(0);

            g.DrawCircle(myPen, x, y, (float)_radius);
        }

        public float MathXtoScreenX(double mathX)
        {
            double centerX = (double)(_mathSurface.Width / 2.0);

            return (float) (centerX + mathX * SCALE);
        }

        public float MathYtoScreenY(double mathY)
        {
            double centerY = (double)(_mathSurface.Height / 2.0);

            return (float) (centerY - mathY * SCALE);
        }

        private void nudThetaDegrees_ValueChanged(object sender, EventArgs e)
        {
            var deg = nudThetaDegrees.Value;
            var rad = DegreesToRadians((double)deg);
            nudThetaRadians.Value = (decimal)rad;

            _theta = rad;
            //mathSurface.Refresh();
            DisplayImage();
        }

        private void nudThetaRadians_ValueChanged(object sender, EventArgs e)
        {
            var rad = nudThetaRadians.Value;
            var deg = RadiansToDegrees((double)rad);
            nudThetaDegrees.Value = (decimal)deg;

            _theta = (double)rad;

            //mathSurface.Refresh();
            DisplayImage();
        }

        private void UpdateTheta(decimal deg)
        {
            nudThetaDegrees.Value = deg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateTheta(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTheta(30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTheta(45);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTheta(60);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateTheta(90);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // mathSurface.Refresh();

            DisplayImage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool running = timer1.Enabled;
            if (!running)
            {
                _results.Clear();
            }
            else
            {
                ChartResults();
            }
            timer1.Enabled = !timer1.Enabled;
        }

        private void ChartResults()
        {
            chart1.Series.Clear();
            Series ser1 = new Series("My Series", 10);
            ser1.ChartType = SeriesChartType.Line;
            chart1.Series.Add(ser1);
            chart1.Series["My Series"].Points.DataBindXY(_results.Keys, _results.Values);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var angle = nudThetaDegrees.Value;
            var max = 45;
            angle += (max - angle) / 2;
            _results.Clear();
            if (Math.Abs(angle - max) > (decimal)_slop)
            {
                UpdateTheta(angle);
                Application.DoEvents();
                _results[(int)nudThetaDegrees.Value] = (int)nudNumberOfPoints.Value;
            }
            else
            {
                timer1.Enabled = false;
                ChartResults();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _results.Clear();
            ChartResults();

            decimal increment = nudSeriesIncrement.Value;

            for (decimal idx = 0; idx < 90; idx += increment)
            {
                _color = Color.FromArgb(0, (int)((idx / 90m) * 255m), (int)(((90 - idx) / 90m) * 255m));
                UpdateTheta(idx);
                Application.DoEvents();

                _results[nudThetaDegrees.Value] = (int)nudNumberOfPoints.Value;

                chart1.Series["My Series"].Points.DataBindXY(_results.Keys, _results.Values);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Circle-" + _theta + ".bmp";
            var dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var filename = saveFileDialog1.FileName;
                _mathSurface.Save(filename);
            }
        }
    }
}
