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
            this.tsmiRecordAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChart = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).BeginInit();
            this.SuspendLayout();
            // 
            // msTimers
            // 
            this.msTimers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordAdd,
            this.tsmiRecordEdit,
            this.tsmiRecordDelete,
            this.tsmiAddTime,
            this.tsmiChart,
            this.tsmiTimer});
            this.msTimers.Location = new System.Drawing.Point(0, 0);
            this.msTimers.Name = "msTimers";
            this.msTimers.Size = new System.Drawing.Size(369, 24);
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
            this.dgvTimers.Location = new System.Drawing.Point(0, 24);
            this.dgvTimers.MultiSelect = false;
            this.dgvTimers.Name = "dgvTimers";
            this.dgvTimers.ReadOnly = true;
            this.dgvTimers.RowHeadersVisible = false;
            this.dgvTimers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimers.Size = new System.Drawing.Size(369, 215);
            this.dgvTimers.TabIndex = 1;
            this.dgvTimers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimers_CellContentDoubleClick);
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
            // tsmiRecordAdd
            // 
            this.tsmiRecordAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordAdd.Image = global::TimeCounter.Properties.Resources.IconPlus;
            this.tsmiRecordAdd.Name = "tsmiRecordAdd";
            this.tsmiRecordAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordAdd.Text = "Добавить";
            this.tsmiRecordAdd.Click += new System.EventHandler(this.tsmiRecordAdd_Click);
            // 
            // tsmiRecordEdit
            // 
            this.tsmiRecordEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordEdit.Image = global::TimeCounter.Properties.Resources.IconEdit;
            this.tsmiRecordEdit.Name = "tsmiRecordEdit";
            this.tsmiRecordEdit.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordEdit.Text = "Редактировать";
            this.tsmiRecordEdit.Click += new System.EventHandler(this.tsmiRecordEdit_Click);
            // 
            // tsmiRecordDelete
            // 
            this.tsmiRecordDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordDelete.Image = global::TimeCounter.Properties.Resources.action_delete_sharp_thick;
            this.tsmiRecordDelete.Name = "tsmiRecordDelete";
            this.tsmiRecordDelete.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordDelete.Text = "Удалить";
            this.tsmiRecordDelete.Click += new System.EventHandler(this.tsmiRecordDelete_Click);
            // 
            // tsmiAddTime
            // 
            this.tsmiAddTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiAddTime.Image = global::TimeCounter.Properties.Resources.IconTimeAdd;
            this.tsmiAddTime.Name = "tsmiAddTime";
            this.tsmiAddTime.Size = new System.Drawing.Size(28, 20);
            this.tsmiAddTime.Text = "Добавить время";
            this.tsmiAddTime.Click += new System.EventHandler(this.tsmiAddTime_Click);
            // 
            // tsmiTimer
            // 
            this.tsmiTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTimer.Image = global::TimeCounter.Properties.Resources.IconTimer;
            this.tsmiTimer.Name = "tsmiTimer";
            this.tsmiTimer.Size = new System.Drawing.Size(28, 20);
            this.tsmiTimer.Text = "Таймер";
            this.tsmiTimer.Click += new System.EventHandler(this.tsmiTimer_Click);
            // 
            // tsmiChart
            // 
            this.tsmiChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiChart.Image = global::TimeCounter.Properties.Resources.IconChart;
            this.tsmiChart.Name = "tsmiChart";
            this.tsmiChart.Size = new System.Drawing.Size(28, 20);
            this.tsmiChart.Text = "Диаграмма";
            this.tsmiChart.Click += new System.EventHandler(this.tsmiChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 239);
            this.Controls.Add(this.dgvTimers);
            this.Controls.Add(this.msTimers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTimers;
            this.Name = "FormMain";
            this.Text = "Таймеры";
            this.msTimers.ResumeLayout(false);
            this.msTimers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimers)).EndInit();
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
    }
}

