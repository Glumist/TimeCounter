namespace TimeCounter
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msTimers = new System.Windows.Forms.MenuStrip();
            this.dgvTimers = new System.Windows.Forms.DataGridView();
            this.colLastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTodayCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiRecordAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTimers
            // 
            this.msTimers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msTimers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordAdd,
            this.tsmiRecordEdit,
            this.tsmiRecordDelete,
            this.tsmiAddTime,
            this.tsmiChart,
            this.tsmiTimer,
            this.tstbFilter,
            this.toolStripMenuItem1});
            this.msTimers.Location = new System.Drawing.Point(0, 0);
            this.msTimers.Name = "msTimers";
            this.msTimers.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msTimers.Size = new System.Drawing.Size(704, 37);
            this.msTimers.TabIndex = 0;
            this.msTimers.Text = "menuStrip1";
            // 
            // dgvTimers
            // 
            this.dgvTimers.AllowUserToAddRows = false;
            this.dgvTimers.AllowUserToDeleteRows = false;
            this.dgvTimers.AllowUserToResizeRows = false;
            this.dgvTimers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLastUpdate,
            this.colName,
            this.colTotalTimer});
            this.dgvTimers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTimers.Location = new System.Drawing.Point(0, 37);
            this.dgvTimers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTimers.Name = "dgvTimers";
            this.dgvTimers.ReadOnly = true;
            this.dgvTimers.RowHeadersVisible = false;
            this.dgvTimers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimers.Size = new System.Drawing.Size(704, 486);
            this.dgvTimers.TabIndex = 1;
            this.dgvTimers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimers_CellContentDoubleClick);
            this.dgvTimers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTimers_KeyDown);
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.DataPropertyName = "LastUpdate";
            this.colLastUpdate.HeaderText = "Обновление";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colTotalTimer
            // 
            this.colTotalTimer.DataPropertyName = "TotalTimerString";
            this.colTotalTimer.HeaderText = "Счетчик";
            this.colTotalTimer.Name = "colTotalTimer";
            this.colTotalTimer.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTodayCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTodayCount
            // 
            this.tsslTodayCount.Name = "tsslTodayCount";
            this.tsslTodayCount.Size = new System.Drawing.Size(0, 17);
            // 
            // tstbFilter
            // 
            this.tstbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(100, 31);
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // tsmiRecordAdd
            // 
            this.tsmiRecordAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordAdd.Image = global::TimeCounter.Properties.Resources.IconPlus;
            this.tsmiRecordAdd.Name = "tsmiRecordAdd";
            this.tsmiRecordAdd.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordAdd.Text = "Добавить";
            this.tsmiRecordAdd.Click += new System.EventHandler(this.tsmiRecordAdd_Click);
            // 
            // tsmiRecordEdit
            // 
            this.tsmiRecordEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordEdit.Image = global::TimeCounter.Properties.Resources.IconEdit;
            this.tsmiRecordEdit.Name = "tsmiRecordEdit";
            this.tsmiRecordEdit.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordEdit.Text = "Редактировать";
            this.tsmiRecordEdit.Click += new System.EventHandler(this.tsmiRecordEdit_Click);
            // 
            // tsmiRecordDelete
            // 
            this.tsmiRecordDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordDelete.Image = global::TimeCounter.Properties.Resources.action_delete_sharp_thick;
            this.tsmiRecordDelete.Name = "tsmiRecordDelete";
            this.tsmiRecordDelete.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordDelete.Text = "Удалить";
            this.tsmiRecordDelete.Click += new System.EventHandler(this.tsmiRecordDelete_Click);
            // 
            // tsmiAddTime
            // 
            this.tsmiAddTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiAddTime.Image = global::TimeCounter.Properties.Resources.IconTimeAdd;
            this.tsmiAddTime.Name = "tsmiAddTime";
            this.tsmiAddTime.Size = new System.Drawing.Size(36, 31);
            this.tsmiAddTime.Text = "Добавить время";
            this.tsmiAddTime.Click += new System.EventHandler(this.tsmiAddTime_Click);
            // 
            // tsmiChart
            // 
            this.tsmiChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiChart.Image = global::TimeCounter.Properties.Resources.IconChart;
            this.tsmiChart.Name = "tsmiChart";
            this.tsmiChart.Size = new System.Drawing.Size(36, 31);
            this.tsmiChart.Text = "Диаграмма";
            this.tsmiChart.Click += new System.EventHandler(this.tsmiChart_Click);
            // 
            // tsmiTimer
            // 
            this.tsmiTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTimer.Image = global::TimeCounter.Properties.Resources.IconTimer;
            this.tsmiTimer.Name = "tsmiTimer";
            this.tsmiTimer.Size = new System.Drawing.Size(36, 31);
            this.tsmiTimer.Text = "Таймер";
            this.tsmiTimer.Click += new System.EventHandler(this.tsmiTimer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Image = global::TimeCounter.Properties.Resources.IconFilter;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 31);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 545);
            this.Controls.Add(this.dgvTimers);
            this.Controls.Add(this.msTimers);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTimers;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Таймеры";
            this.msTimers.ResumeLayout(false);
            this.msTimers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTimers;
        private System.Windows.Forms.DataGridView dgvTimers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTodayCount;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

