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
    public partial class FormAddTime : Form
    {
        private int maxMinutes;
        public int AddedMinutes;
        public DateTime? AddedDate;

        public FormAddTime(string name)
        {
            InitializeComponent();

            lName.Text = name;
            maxMinutes = -1;
        }

        private void dtpDate_EnabledChanged(object sender, EventArgs e)
        {
            SetMaximum();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetMaximum();
        }

        private void SetMaximum()
        {
            if (dtpDate.Checked)
            {
                Dictionary<string, double> dateTimers = RecordsCollection.GetTimersByDate(dtpDate.Value);
                double sumSeconds = 0;
                dateTimers.Values.ToList().ForEach(dt => sumSeconds += dt);
                int sumMinutes = (int)Math.Floor((decimal)(sumSeconds / 60));
                if (sumSeconds > sumMinutes * 60)
                    sumMinutes++;
                maxMinutes = 24 * 60 - sumMinutes;

                decimal hours = Math.Floor((decimal)maxMinutes / 60);
                lAvailable.Text = "На эту дату доступно " + hours + "ч " + (maxMinutes - hours * 60) + "м";
            }
            else
            {
                maxMinutes = -1;
                lAvailable.Text = "";
            }
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            if (maxMinutes == -1)
                return;
            decimal maxHours = Math.Floor((decimal)maxMinutes / 60);
            if (maxHours < nudHours.Value)
                nudHours.Value = maxHours;
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            decimal minutes = nudMinutes.Value + nudHours.Value * 60;
            if (maxMinutes != -1 && maxMinutes < minutes)
                minutes = maxMinutes;

            if (minutes > 60)
            {
                decimal hours = Math.Floor(minutes / 60);
                nudHours.Value = hours;
                minutes -= hours * 60;
            }
            nudMinutes.Value = minutes;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            AddedMinutes = (int)nudHours.Value * 60 + (int)nudMinutes.Value;
            if (dtpDate.Checked)
                AddedDate = dtpDate.Value;
            else
                AddedDate = null;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
