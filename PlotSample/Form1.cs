using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace PlotSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var Plot = new OxyPlot.WindowsForms.PlotView();
            Plot.Model = new PlotModel();
            Plot.Dock = DockStyle.Fill;
            this.plotBox.Controls.Add(Plot);
            //this.Controls.Add(Plot);

            Plot.Model.PlotType = PlotType.XY;
            Plot.Model.Background = OxyColor.FromRgb(255, 255, 255);
            Plot.Model.TextColor = OxyColor.FromRgb(0, 0, 0);

            // Create Line series
            var s1 = new LineSeries { Title = "LineSeries", StrokeThickness = 1 };
            s1.Points.Add(new DataPoint(2, 7));
            s1.Points.Add(new DataPoint(7, 9));
            s1.Points.Add(new DataPoint(9, 4));

            // add Series and Axis to plot model
            Plot.Model.Series.Add(s1);
            var axis1 = new LinearAxis();
            axis1.Position = AxisPosition.Bottom;
            axis1.Minimum = 0.0;
            axis1.Maximum = 10.0;
            Plot.Model.Axes.Add(axis1);

            var axis2 = new LinearAxis();
            axis2.Position = AxisPosition.Left;
            axis2.Minimum = 0.0;
            axis2.Maximum = 10.0;
            Plot.Model.Axes.Add(axis2);
        }
    }
}
