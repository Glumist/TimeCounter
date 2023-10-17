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
    public partial class FormRecord : Form
    {
        public Record EditedRecord;

        private List<Counter> _changedCounters;

        public FormRecord()
            :this(new Record())
        {
            scRecord.Panel2Collapsed = true;
            Width = 300;
        }

        public FormRecord(Record record)
        {
            InitializeComponent();
            dgvTimers.AutoGenerateColumns = false;

            _changedCounters= new List<Counter>();

            EditedRecord = record;
            tbName.Text = record.Name;
            tbUndatedTime.Text = record.UndatedTimerString;

            List<Counter> timers = new List<Counter>();
            foreach (DateTime key in record.Timers.Keys)
                timers.Insert(0, new Counter(key, TimeSpan.FromSeconds(record.Timers[key])));
            dgvTimers.DataSource = timers;

            cbPeriod.SelectedIndex = 1;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            Record existedRecord = RecordsCollection.GetRecordByName(tbName.Text);
            btOk.Enabled = !(existedRecord != null && EditedRecord != existedRecord);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!btOk.Enabled)
                return;

            EditedRecord.Name = tbName.Text;

            foreach (Counter counter in _changedCounters)            
                EditedRecord.Timers[counter.Date] = counter.Timer.TotalSeconds;            

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvTimers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimers.SelectedRows.Count == 0 || dgvTimers.SelectedRows[0].Index == -1)
                return;

            Counter selectedCounter = dgvTimers.SelectedRows[0].DataBoundItem as Counter;
            int editedMinutes = (int)Math.Floor(selectedCounter.Timer.TotalMinutes);
            FormEditTime form = new FormEditTime(tbName.Text, selectedCounter.Date, editedMinutes);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            selectedCounter.Timer += TimeSpan.FromMinutes(form.EditedMinutes - editedMinutes);
            _changedCounters.Add(selectedCounter);
        }

        private class Counter
        {
            public DateTime Date { get; set; }
            public TimeSpan Timer { get; set; }
            public string TimerString { get { return Record.GetStringFotTimeSpan(Timer); } }

            public Counter(DateTime date, TimeSpan timer)
            {
                Date = date;
                Timer = timer;
            }
        }

        #region Chart

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
            Series series = chart.Series[0];
            series.Points.Clear();
            double sum = 0;
            foreach (DateTime key in EditedRecord.Timers.Keys)
            {
                if (!showAll && (key < dtpStart.Value || key > dtpEnd.Value))
                    continue;

                sum += EditedRecord.Timers[key];
                int pointNum = series.Points.AddY(EditedRecord.Timers[key] / 60 / 60);
                DataPoint point = series.Points[pointNum];
                point.Label = key.ToShortDateString();
            }

            if (sum > 0)
                lSum.Text = "Итого: " + Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(sum));
            else
                lSum.Text = "";
        }

        #endregion
    }
}
