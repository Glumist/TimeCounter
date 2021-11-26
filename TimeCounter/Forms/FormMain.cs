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
        List<FormTimer> _openedTimerForms;

        public FormMain()
        {
            InitializeComponent();
            _openedTimerForms = new List<FormTimer>();
            dgvTimers.AutoGenerateColumns = false;
            _recordsCollection = RecordsCollection.GetInstance();
            RefreshData();
        }

        private void Save()
        {
            if (!RecordsCollection.Save())
                MessageBox.Show("Ошибка при сохранении!");
        }

        private void RefreshData()
        {
            List<Record> selectedRecords = GetSelectedRecords();

            List<Record> records = new List<Record>(_recordsCollection.Records);
            if (!string.IsNullOrWhiteSpace(tstbFilter.Text.Trim()))
                records.RemoveAll(r => !r.Name.ToLower().Contains(tstbFilter.Text.ToLower()));
            dgvTimers.DataSource = records;
            dgvTimers.ClearSelection();

            if (selectedRecords.Count > 0)
                SelectRecord(selectedRecords[0]);

            string totalTodayCount = Record.GetStringForTimers(RecordsCollection.GetTimersByPeriod(DateTime.Today, DateTime.Today));
            tsslTodayCount.Text = "Всего за сегодня: " + (totalTodayCount.Length > 0 ? totalTodayCount : "-");
        }

        #region Menu

        private void tsmiRecordAdd_Click(object sender, EventArgs e)
        {
            FormRecord form = new FormRecord();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            RecordsCollection.Add(form.EditedRecord);
            Save();
            RefreshData();

            SelectRecord(form.EditedRecord);
        }

        private void tsmiRecordEdit_Click(object sender, EventArgs e)
        {
            List<Record> selectedRecords = GetSelectedRecords();
            if (selectedRecords.Count == 0)
                return;

            Record selectedRecord = selectedRecords[0];

            if (new FormRecord(selectedRecord).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshData();
            SelectRecord(selectedRecord);
        }

        private void tsmiRecordDelete_Click(object sender, EventArgs e)
        {
            List<Record> selectedRecords = GetSelectedRecords();
            if (selectedRecords.Count == 0)
                return;
            else if (selectedRecords.Count == 1)
            {
                if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedRecords[0].ToString() + "?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }
            else
            {
                if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedRecords.Count + " записей?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }

            _recordsCollection.Records.RemoveAll(r => selectedRecords.Contains(r));
            Save();
            RefreshData();
        }

        private void tsmiAddTime_Click(object sender, EventArgs e)
        {
            List<Record> selectedRecords = GetSelectedRecords();
            if (selectedRecords.Count == 0)
                return;

            Record selectedRecord = selectedRecords[0];

            FormAddTime form = new FormAddTime(selectedRecord.Name);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.AddedDate.HasValue)
            {
                if (!selectedRecord.Timers.ContainsKey(form.AddedDate.Value.Date))
                    selectedRecord.Timers.Add(form.AddedDate.Value.Date, 0);
                selectedRecord.Timers[form.AddedDate.Value.Date] += form.AddedMinutes * 60;
                if (form.AddedDate.Value.Date > selectedRecord.LastUpdate)
                {
                    selectedRecord.LastUpdate = form.AddedDate.Value.Date;
                    _recordsCollection.Records.Sort(Record.CompareByDate);
                }
            }
            else
                selectedRecord.UndatedTimer += form.AddedMinutes * 60;

            Save();
            RefreshData();
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

        private List<Record> GetSelectedRecords()
        {
            List<Record> result = new List<Record>();
            if (dgvTimers.SelectedRows.Count == 0 || dgvTimers.SelectedRows[0].Index == -1)
                return result;

            foreach (DataGridViewRow row in dgvTimers.SelectedRows)
                result.Add(row.DataBoundItem as Record);

            return result;
        }

        private void SelectRecord(Record record)
        {
            dgvTimers.ClearSelection();
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
            List<Record> selectedRecords = GetSelectedRecords();
            if (selectedRecords.Count == 0)
                return;

            foreach (Record record in selectedRecords)
            {
                FormTimer form = new FormTimer(record);
                form.OnStart += Form_OnStart;
                form.FormClosed += FormTimer_FormClosed;
                form.Show(this);
                _openedTimerForms.Add(form);
            }
            Hide();
        }

        private void Form_OnStart(object sender, EventArgs e)
        {
            foreach (FormTimer form in _openedTimerForms)
                form.Pause();
        }

        private void FormTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            _openedTimerForms.Remove((FormTimer)sender);
            if (_openedTimerForms.Count == 0)
            {
                Show();
                RefreshData();
            }
        }

        private void dgvTimers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OpenTimerWindow();
            e.SuppressKeyPress = true;
        }

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}