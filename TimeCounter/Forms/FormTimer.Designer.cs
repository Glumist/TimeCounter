namespace TimeCounter
{
    partial class FormTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimer));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalTimer = new System.Windows.Forms.TextBox();
            this.tbCurrentTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btStop
            // 
            this.btStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btStop.Image = global::TimeCounter.Properties.Resources.IconStop;
            this.btStop.Location = new System.Drawing.Point(278, 152);
            this.btStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(120, 118);
            this.btStop.TabIndex = 2;
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btPause
            // 
            this.btPause.Enabled = false;
            this.btPause.Image = global::TimeCounter.Properties.Resources.IconPause;
            this.btPause.Location = new System.Drawing.Point(148, 152);
            this.btPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(120, 118);
            this.btPause.TabIndex = 1;
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStart
            // 
            this.btStart.Image = ((System.Drawing.Image)(resources.GetObject("btStart.Image")));
            this.btStart.Location = new System.Drawing.Point(20, 152);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(120, 118);
            this.btStart.TabIndex = 0;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущий счетчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Суммарный счетчик";
            // 
            // tbTotalTimer
            // 
            this.tbTotalTimer.Location = new System.Drawing.Point(20, 108);
            this.tbTotalTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotalTimer.Name = "tbTotalTimer";
            this.tbTotalTimer.ReadOnly = true;
            this.tbTotalTimer.Size = new System.Drawing.Size(376, 26);
            this.tbTotalTimer.TabIndex = 5;
            this.tbTotalTimer.TabStop = false;
            // 
            // tbCurrentTimer
            // 
            this.tbCurrentTimer.Location = new System.Drawing.Point(20, 38);
            this.tbCurrentTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentTimer.Name = "tbCurrentTimer";
            this.tbCurrentTimer.ReadOnly = true;
            this.tbCurrentTimer.Size = new System.Drawing.Size(376, 26);
            this.tbCurrentTimer.TabIndex = 6;
            this.tbCurrentTimer.TabStop = false;
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btStop;
            this.ClientSize = new System.Drawing.Size(416, 288);
            this.Controls.Add(this.tbCurrentTimer);
            this.Controls.Add(this.tbTotalTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Таймер ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTimer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalTimer;
        private System.Windows.Forms.TextBox tbCurrentTimer;
    }
}