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

namespace TimeCounter
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();

            cbPeriod.SelectedIndex = 1;
        }

        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            pDateStart.Visible = false;
            pDateEnd.Visible = false;

            switch (cbPeriod.SelectedIndex)
            {
                case 0:
                    dtpStart.Value = DateTime.Today;
                    dtpEnd.Value = DateTime.Today;
                    break;
                case 1:
                    dtpStart.Value = DateTime.Today.AddDays(-6);
                    dtpEnd.Value = DateTime.Today;
                    break;
                case 2:
                    dtpStart.Value = DateTime.Today.AddMonths(-1);
                    dtpEnd.Value = DateTime.Today;
                    break;
                case 3:
                    dtpStart.Value = DateTime.Today.AddYears(-1);
                    dtpEnd.Value = DateTime.Today;
                    break;
                case 4:
                    RefreshChart(true);
                    return;
                case 5:
                    dtpStart.Value = dtpEnd.Value;
                    pDateEnd.Visible = true;
                    lSingleDate.BringToFront();
                    break;
                case 6:
                    pDateStart.Visible = true;
                    pDateEnd.Visible = true;
                    pDateStart.BringToFront();
                    lEndDate.BringToFront();
                    break;
            }

            RefreshChart();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (cbPeriod.SelectedIndex == 4)
                dtpStart.Value = dtpEnd.Value;

            RefreshChart();
        }

        private void RefreshChart(bool showAll = false)
        {
            Dictionary<string, double> data = 
                showAll ?
                RecordsCollection.GetTimersByPeriod(DateTime.MinValue, DateTime.MaxValue) :
                RecordsCollection.GetTimersByPeriod(dtpStart.Value, dtpEnd.Value);

            Series series = chart.Series[0];
            series.Points.Clear();
            foreach (string key in data.Keys)
            {
                int pointNum = series.Points.AddY(data[key] / 60 / 60);
                DataPoint point = series.Points[pointNum];
                point.Label = key;
            }

            double sum = 0;
            data.Values.ToList().ForEach(v => sum += v);
            if (sum > 0)
                lSum.Text = "Итого: " + Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(sum));
            else
                lSum.Text = "";
        }
    }
}
