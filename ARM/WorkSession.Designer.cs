﻿namespace ARM
{
    partial class WorkSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSession));
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.ll1 = new System.Windows.Forms.LinkLabel();
            this.show_timeBtn = new System.Windows.Forms.Button();
            this.l3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(12, 32);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(86, 20);
            this.dtStart.TabIndex = 0;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(107, 32);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(90, 20);
            this.dtEnd.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(9, 16);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(89, 13);
            this.l1.TabIndex = 2;
            this.l1.Text = "Начало периода";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(104, 16);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(83, 13);
            this.l2.TabIndex = 3;
            this.l2.Text = "Конец периода";
            // 
            // ll1
            // 
            this.ll1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ll1.AutoSize = true;
            this.ll1.Location = new System.Drawing.Point(92, 94);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(0, 13);
            this.ll1.TabIndex = 4;
            this.ll1.Visible = false;
            // 
            // show_timeBtn
            // 
            this.show_timeBtn.Location = new System.Drawing.Point(217, 20);
            this.show_timeBtn.Name = "show_timeBtn";
            this.show_timeBtn.Size = new System.Drawing.Size(50, 32);
            this.show_timeBtn.TabIndex = 5;
            this.show_timeBtn.Text = "Ok";
            this.show_timeBtn.UseVisualStyleBackColor = true;
            this.show_timeBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(12, 69);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(184, 13);
            this.l3.TabIndex = 6;
            this.l3.Text = "За указанный период вы работали";
            this.l3.Visible = false;
            // 
            // WorkSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 116);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.show_timeBtn);
            this.Controls.Add(this.ll1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт рабочего времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.LinkLabel ll1;
        private System.Windows.Forms.Button show_timeBtn;
        private System.Windows.Forms.Label l3;
    }
}