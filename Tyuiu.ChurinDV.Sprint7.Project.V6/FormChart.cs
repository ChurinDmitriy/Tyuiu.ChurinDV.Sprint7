using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ChurinDV.Sprint7.Project.V6
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        public void UpdateChart(List<int> agecount)
        {
            chartAge_CDV.Series.Clear();

            for (int i = 0; i < agecount.Count - 1; i+=2)
            {
                Series series1 = new Series($"{agecount[i]}");
                series1.ChartType = SeriesChartType.Column;
                chartAge_CDV.Series.Add(series1);

                chartAge_CDV.Series[$"{agecount[i]}"].Points.AddXY(agecount[i], agecount[i + 1]);
            }
        }
    }
}
