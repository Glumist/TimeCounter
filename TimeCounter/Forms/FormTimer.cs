using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCounter
{
    public partial class FormTimer : Form
    {
        private Record editedRecord;
        private TimeSpan currentTimer;
        private int saveCounter;
        private Dictionary<DateTime, double> unsavedTimers;

        public event EventHandler OnStart;

        public FormTimer(Record record)
        {
            InitializeComponent();

            editedRecord = record;
            Text += record.Name;
            currentTimer = TimeSpan.Zero;
            saveCounter = 0;
            unsavedTimers = new Dictionary<DateTime, double>();

            RefreshData();
            //tbCurrentTimer.Text = Record.GetStringFotTimeSpan(currentTimer);
            //tbTotalTimer.Text = Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(editedRecord.TotalTimer));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimer = currentTimer.Add(TimeSpan.FromSeconds(1));

            DateTime today = DateTime.Today;
            if (!unsavedTimers.ContainsKey(today))
                unsavedTimers.Add(today, 0);
            unsavedTimers[today]++;

            RefreshData();

            if (saveCounter < 60)
                saveCounter++;
            else
            {
                saveCounter = 0;
                Save();
            }
        }

        private void RefreshData()
        {
            tbCurrentTimer.Text = Record.GetStringFotTimeSpan(currentTimer);

            DateTime today = DateTime.Today;
            double todayTimer = 0;
            if (editedRecord.Timers.ContainsKey(today))
                todayTimer += editedRecord.Timers[today];
            if (unsavedTimers.ContainsKey(today))
                todayTimer += unsavedTimers[today];
            tbTodayTimer.Text = Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(todayTimer));

            double unsavedTotal = 0;
            foreach (double val in unsavedTimers.Values)
                unsavedTotal += val;
            tbTotalTimer.Text = Record.GetStringFotTimeSpan(TimeSpan.FromSeconds(editedRecord.TotalTimer + unsavedTotal));
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (OnStart != null)
                OnStart(this, EventArgs.Empty);
            btPause.Enabled = true;
            btStart.Enabled = false;
            timer.Enabled = true;
            lStopped.Text = "";
            btPause.Select();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        public void Pause()
        {
            btPause.Enabled = false;
            btStart.Enabled = true;
            timer.Enabled = false;
            lStopped.Text = "Остановлено в " + DateTime.Now.ToString("HH:mm");
            btStart.Select();
            Save();
        }

        private void FormTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Enabled = false;
            if (currentTimer > TimeSpan.Zero)
                Save();
        }

        private void Save()
        {
            bool timerState = timer.Enabled;
            timer.Enabled = false;

            if (unsavedTimers.Count > 0)
            {
                foreach (DateTime key in unsavedTimers.Keys)
                {
                    if (!editedRecord.Timers.ContainsKey(key))
                        editedRecord.Timers.Add(key, 0);
                    editedRecord.Timers[key] += unsavedTimers[key];
                }
                unsavedTimers.Clear();
                RecordsCollection.UpdateRecord(editedRecord);
                RecordsCollection.Save();
            }

            timer.Enabled = timerState;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Owner != null && StartPosition == FormStartPosition.Manual)
            {
                int offset = Owner.OwnedForms.Length * 38;  // approx. 10mm
                Point p = new Point(Owner.Left + Owner.Width / 2 - Width / 2 + offset, Owner.Top + Owner.Height / 2 - Height / 2 + offset);
                this.Location = p;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
