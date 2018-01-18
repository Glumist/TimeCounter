namespace TimeCounter
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUndatedTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTimers = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.scRecord = new System.Windows.Forms.SplitContainer();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pTop = new System.Windows.Forms.Panel();
            this.lSum = new System.Windows.Forms.Label();
            this.pDateStart = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.pDateEnd = new System.Windows.Forms.Panel();
            this.lSingleDate = new System.Windows.Forms.Label();
            this.lEndDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scRecord)).BeginInit();
            this.scRecord.Panel1.SuspendLayout();
            this.scRecord.Panel2.SuspendLayout();
            this.scRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.pTop.SuspendLayout();
            this.pDateStart.SuspendLayout();
            this.pDateEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(13, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Нераспределенное время";
            // 
            // tbUndatedTime
            // 
            this.tbUndatedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUndatedTime.Location = new System.Drawing.Point(13, 64);
            this.tbUndatedTime.Name = "tbUndatedTime";
            this.tbUndatedTime.ReadOnly = true;
            this.tbUndatedTime.Size = new System.Drawing.Size(205, 20);
            this.tbUndatedTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Счетчики по датам";
            // 
            // dgvTimers
            // 
            this.dgvTimers.AllowUserToAddRows = false;
            this.dgvTimers.AllowUserToDeleteRows = false;
            this.dgvTimers.AllowUserToResizeRows = false;
            this.dgvTimers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTimer});
            this.dgvTimers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTimers.Enabled = false;
            this.dgvTimers.Location = new System.Drawing.Point(13, 103);
            this.dgvTimers.MultiSelect = false;
            this.dgvTimers.Name = "dgvTimers";
            this.dgvTimers.ReadOnly = true;
            this.dgvTimers.RowHeadersVisible = false;
            this.dgvTimers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimers.Size = new System.Drawing.Size(205, 299);
            this.dgvTimers.TabIndex = 5;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTimer
            // 
            this.colTimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTimer.DataPropertyName = "TimerString";
            this.colTimer.HeaderText = "Счетчик";
            this.colTimer.Name = "colTimer";
            this.colTimer.ReadOnly = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(36, 408);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(117, 408);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // scRecord
            // 
            this.scRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRecord.Location = new System.Drawing.Point(0, 0);
            this.scRecord.Name = "scRecord";
            // 
            // scRecord.Panel1
            // 
            this.scRecord.Panel1.Controls.Add(this.label1);
            this.scRecord.Panel1.Controls.Add(this.btCancel);
            this.scRecord.Panel1.Controls.Add(this.tbName);
            this.scRecord.Panel1.Controls.Add(this.btOk);
            this.scRecord.Panel1.Controls.Add(this.label2);
            this.scRecord.Panel1.Controls.Add(this.dgvTimers);
            this.scRecord.Panel1.Controls.Add(this.tbUndatedTime);
            this.scRecord.Panel1.Controls.Add(this.label3);
            // 
            // scRecord.Panel2
            // 
            this.scRecord.Panel2.Controls.Add(this.chart);
            this.scRecord.Panel2.Controls.Add(this.pTop);
            this.scRecord.Size = new System.Drawing.Size(819, 441);
            this.scRecord.SplitterDistance = 221;
            this.scRecord.SplitterWidth = 6;
            this.scRecord.TabIndex = 8;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 26);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(592, 415);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.lSum);
            this.pTop.Controls.Add(this.pDateStart);
            this.pTop.Controls.Add(this.pDateEnd);
            this.pTop.Controls.Add(this.cbPeriod);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(592, 26);
            this.pTop.TabIndex = 3;
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Location = new System.Drawing.Point(127, 7);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(0, 13);
            this.lSum.TabIndex = 4;
            // 
            // pDateStart
            // 
            this.pDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pDateStart.Controls.Add(this.label4);
            this.pDateStart.Controls.Add(this.dtpStart);
            this.pDateStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDateStart.Location = new System.Drawing.Point(267, 0);
            this.pDateStart.Name = "pDateStart";
            this.pDateStart.Size = new System.Drawing.Size(160, 26);
            this.pDateStart.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "С";
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Location = new System.Drawing.Point(23, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(131, 20);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // pDateEnd
            // 
            this.pDateEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pDateEnd.Controls.Add(this.lSingleDate);
            this.pDateEnd.Controls.Add(this.lEndDate);
            this.pDateEnd.Controls.Add(this.dtpEnd);
            this.pDateEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDateEnd.Location = new System.Drawing.Point(427, 0);
            this.pDateEnd.Name = "pDateEnd";
            this.pDateEnd.Size = new System.Drawing.Size(165, 26);
            this.pDateEnd.TabIndex = 2;
            // 
            // lSingleDate
            // 
            this.lSingleDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSingleDate.AutoSize = true;
            this.lSingleDate.Location = new System.Drawing.Point(6, 6);
            this.lSingleDate.Name = "lSingleDate";
            this.lSingleDate.Size = new System.Drawing.Size(21, 13);
            this.lSingleDate.TabIndex = 3;
            this.lSingleDate.Text = "На";
            // 
            // lEndDate
            // 
            this.lEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEndDate.AutoSize = true;
            this.lEndDate.Location = new System.Drawing.Point(6, 6);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(21, 13);
            this.lEndDate.TabIndex = 2;
            this.lEndDate.Text = "По";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Location = new System.Drawing.Point(31, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(131, 20);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // cbPeriod
            // 
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "За день",
            "За неделю",
            "За месяц",
            "За год",
            "Все",
            "На дату",
            "За период"});
            this.cbPeriod.Location = new System.Drawing.Point(0, 2);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cbPeriod.TabIndex = 0;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // FormRecord
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(819, 441);
            this.Controls.Add(this.scRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Таймер";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).EndInit();
            this.scRecord.Panel1.ResumeLayout(false);
            this.scRecord.Panel1.PerformLayout();
            this.scRecord.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRecord)).EndInit();
            this.scRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.pDateStart.ResumeLayout(false);
            this.pDateStart.PerformLayout();
            this.pDateEnd.ResumeLayout(false);
            this.pDateEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUndatedTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTimers;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimer;
        private System.Windows.Forms.SplitContainer scRecord;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pDateStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Panel pDateEnd;
        private System.Windows.Forms.Label lSingleDate;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lSum;
    }
}