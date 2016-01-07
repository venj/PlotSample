using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace PlotSample
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer aTimer;
        private OxyPlot.WindowsForms.PlotView Plot = new OxyPlot.WindowsForms.PlotView();
        private OxyPlot.Axes.LinearAxis axis1 = new LinearAxis();
        private LineSeries s1 = new LineSeries { Title = "Speed", StrokeThickness = 1 };
        private int counter = 0;
        private bool reverse = false;
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();

            
            Plot.Model = new PlotModel();
            Plot.Dock = DockStyle.Fill;
            this.plotBox.Controls.Add(Plot);
            //this.Controls.Add(Plot);

            Plot.Model.PlotType = PlotType.XY;
            Plot.Model.Background = OxyColor.FromRgb(255, 255, 255);
            Plot.Model.TextColor = OxyColor.FromRgb(0, 0, 0);
            
            axis1.Position = AxisPosition.Bottom;
            axis1.Minimum = 0.0;
            axis1.Maximum = 10.0;
            Plot.Model.Axes.Add(axis1);

            var axis2 = new LinearAxis();
            axis2.Position = AxisPosition.Left;
            axis2.Minimum = 0.0;
            axis2.Maximum = 15.0;
            Plot.Model.Axes.Add(axis2);

            // Create Line series
            s1.Points.Add(new DataPoint(1, 1));

            // add Series and Axis to plot model
            Plot.Model.Series.Add(s1);
            
            // Timer for dynamic test.
            SetTimer();
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ++x;
            // Invalidate chart for refresh
            Plot.Model.InvalidatePlot(true);
            if (this.counter==10)
            {
                s1.Points.Add(new DataPoint(x, y+1));
                reverse = true;
            }
            if (this.counter == 0)
            {
                reverse = false;
            }

            if (reverse) { counter--; } else { counter++; }

            if (reverse) { y--; } else { y++; }
            // Add lines
            if (reverse)
            {
                s1.Points.Add(new DataPoint(x, y+1));
                s1.Points.Add(new DataPoint(x, y));
            }
            else
            {
                s1.Points.Add(new DataPoint(x, y));
                s1.Points.Add(new DataPoint(x, y + 1));
            }
            // Change axis
            if (x > axis1.Maximum - 2)
            {
                axis1.Maximum += 10;
            }

            if (axis1.Maximum == 30)
            {
                aTimer.Stop();
                aTimer?.Dispose();
            }
        }
    }
}
