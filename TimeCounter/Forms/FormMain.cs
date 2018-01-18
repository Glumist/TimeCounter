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
    public partial class FormMain : Form
    {
        RecordsCollection _recordsCollection;

        public FormMain()
        {
            InitializeComponent();
            dgvTimers.AutoGenerateColumns = false;
            _recordsCollection = RecordsCollection.GetInstance();
            RefreshRecordsTable();
        }

        private void Save()
        {
            if (!RecordsCollection.Save())
                MessageBox.Show("Ошибка при сохранении!");
        }

        private void RefreshRecordsTable()
        {
            Record selectedRecord = GetSelectedRecord();

            dgvTimers.DataSource = new List<Record>(_recordsCollection.Records);
            dgvTimers.ClearSelection();

            if (selectedRecord != null)
                SelectRecord(selectedRecord);
        }

        #region Menu

        private void tsmiRecordAdd_Click(object sender, EventArgs e)
        {
            FormRecord form = new FormRecord();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            RecordsCollection.Add(form.EditedRecord);
            Save();
            RefreshRecordsTable();

            SelectRecord(form.EditedRecord);
        }

        private void tsmiRecordEdit_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            if (new FormRecord(selectedRecord).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshRecordsTable();
            SelectRecord(selectedRecord);
        }

        private void tsmiRecordDelete_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedRecord.ToString() + "?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _recordsCollection.Records.Remove(selectedRecord);
            Save();
            RefreshRecordsTable();
        }

        private void tsmiAddTime_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            FormAddTime form = new FormAddTime(selectedRecord.Name);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.AddedDate.HasValue)
            {
                if (!selectedRecord.Timers.ContainsKey(form.AddedDate.Value.Date))
                    selectedRecord.Timers.Add(form.AddedDate.Value.Date, 0);
                selectedRecord.Timers[form.AddedDate.Value.Date] += form.AddedMinutes * 60;
            }
            else
                selectedRecord.UndatedTimer += form.AddedMinutes * 60;

            Save();
            RefreshRecordsTable();
            SelectRecord(selectedRecord);
        }

        private void tsmiChart_Click(object sender, EventArgs e)
        {
            new FormChart().Show();
        }

        private void tsmiTimer_Click(object sender, EventArgs e)
        {
            OpenTimerWindow();
        }

        #endregion

        private Record GetSelectedRecord()
        {
            if (dgvTimers.SelectedRows.Count == 0 || dgvTimers.SelectedRows[0].Index == -1)
                return null;

            return dgvTimers.SelectedRows[0].DataBoundItem as Record;
        }

        private void SelectRecord(Record record)
        {
            foreach (DataGridViewRow row in dgvTimers.Rows)
            {
                Record rowGame;

                if (row.DataBoundItem is Record)
                    rowGame = row.DataBoundItem as Record;
                else
                    continue;

                if (rowGame == record)
                {
                    row.Selected = true;
                    dgvTimers.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void dgvTimers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenTimerWindow();
        }

        private void OpenTimerWindow()
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            FormTimer form = new FormTimer(selectedRecord);
            form.FormClosed += FormTimer_FormClosed;
            form.Show(this);
            Hide();
        }

        private void FormTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            RefreshRecordsTable();
        }
    }
}
