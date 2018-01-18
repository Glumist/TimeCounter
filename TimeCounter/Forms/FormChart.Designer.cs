namespace TimeCounter
{
    partial class FormChart
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pTop = new System.Windows.Forms.Panel();
            this.lSum = new System.Windows.Forms.Label();
            this.pDateStart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.pDateEnd = new System.Windows.Forms.Panel();
            this.lSingleDate = new System.Windows.Forms.Label();
            this.lEndDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.pTop.SuspendLayout();
            this.pDateStart.SuspendLayout();
            this.pDateEnd.SuspendLayout();
            this.SuspendLayout();
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
            this.chart.Size = new System.Drawing.Size(561, 536);
            this.chart.TabIndex = 1;
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
            this.pTop.Size = new System.Drawing.Size(561, 26);
            this.pTop.TabIndex = 2;
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Location = new System.Drawing.Point(127, 5);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(0, 13);
            this.lSum.TabIndex = 3;
            // 
            // pDateStart
            // 
            this.pDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pDateStart.Controls.Add(this.label2);
            this.pDateStart.Controls.Add(this.dtpStart);
            this.pDateStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDateStart.Location = new System.Drawing.Point(236, 0);
            this.pDateStart.Name = "pDateStart";
            this.pDateStart.Size = new System.Drawing.Size(160, 26);
            this.pDateStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "С";
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
            this.pDateEnd.Location = new System.Drawing.Point(396, 0);
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
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 562);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.pTop);
            this.MinimumSize = new System.Drawing.Size(465, 38);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диаграмма";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Panel pDateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Panel pDateEnd;
        private System.Windows.Forms.Label lSingleDate;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lSum;
    }
}