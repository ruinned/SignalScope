﻿namespace SignalScope
{
    partial class Form1
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
            this.OpenSignal_button = new System.Windows.Forms.Button();
            this.FileRead_progressBar = new System.Windows.Forms.ProgressBar();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.WaveformPlots_groupBox = new System.Windows.Forms.GroupBox();
            this.TimeUnits_comboBox = new System.Windows.Forms.ComboBox();
            this.ActiveCurve_comboBox = new System.Windows.Forms.ComboBox();
            this.WaveformPlots_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenSignal_button
            // 
            this.OpenSignal_button.Location = new System.Drawing.Point(12, 12);
            this.OpenSignal_button.Name = "OpenSignal_button";
            this.OpenSignal_button.Size = new System.Drawing.Size(75, 23);
            this.OpenSignal_button.TabIndex = 0;
            this.OpenSignal_button.Text = "Read file";
            this.OpenSignal_button.UseVisualStyleBackColor = true;
            this.OpenSignal_button.Click += new System.EventHandler(this.OpenSignal_button_Click);
            // 
            // FileRead_progressBar
            // 
            this.FileRead_progressBar.Location = new System.Drawing.Point(93, 12);
            this.FileRead_progressBar.Name = "FileRead_progressBar";
            this.FileRead_progressBar.Size = new System.Drawing.Size(1098, 23);
            this.FileRead_progressBar.TabIndex = 1;
            this.FileRead_progressBar.Click += new System.EventHandler(this.FileRead_progressBar_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 41);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1179, 750);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // WaveformPlots_groupBox
            // 
            this.WaveformPlots_groupBox.Controls.Add(this.ActiveCurve_comboBox);
            this.WaveformPlots_groupBox.Controls.Add(this.TimeUnits_comboBox);
            this.WaveformPlots_groupBox.Location = new System.Drawing.Point(12, 797);
            this.WaveformPlots_groupBox.Name = "WaveformPlots_groupBox";
            this.WaveformPlots_groupBox.Size = new System.Drawing.Size(1179, 155);
            this.WaveformPlots_groupBox.TabIndex = 3;
            this.WaveformPlots_groupBox.TabStop = false;
            this.WaveformPlots_groupBox.Text = "Waveforms";
            this.WaveformPlots_groupBox.Enter += new System.EventHandler(this.WaveformPlots_groupBox_Enter);
            // 
            // TimeUnits_comboBox
            // 
            this.TimeUnits_comboBox.FormattingEnabled = true;
            this.TimeUnits_comboBox.Location = new System.Drawing.Point(6, 19);
            this.TimeUnits_comboBox.Name = "TimeUnits_comboBox";
            this.TimeUnits_comboBox.Size = new System.Drawing.Size(75, 21);
            this.TimeUnits_comboBox.TabIndex = 0;
            this.TimeUnits_comboBox.Tag = "";
            this.TimeUnits_comboBox.Text = "Time units";
            this.TimeUnits_comboBox.SelectedIndexChanged += new System.EventHandler(this.TimeUnits_comboBox_SelectedIndexChanged);
            // 
            // ActiveCurve_comboBox
            // 
            this.ActiveCurve_comboBox.FormattingEnabled = true;
            this.ActiveCurve_comboBox.Location = new System.Drawing.Point(87, 19);
            this.ActiveCurve_comboBox.Name = "ActiveCurve_comboBox";
            this.ActiveCurve_comboBox.Size = new System.Drawing.Size(92, 21);
            this.ActiveCurve_comboBox.TabIndex = 1;
            this.ActiveCurve_comboBox.Text = "Active curve";
            this.ActiveCurve_comboBox.SelectedIndexChanged += new System.EventHandler(this.ActiveCurve_comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 964);
            this.Controls.Add(this.WaveformPlots_groupBox);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.FileRead_progressBar);
            this.Controls.Add(this.OpenSignal_button);
            this.Name = "Form1";
            this.Text = "SignalScope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WaveformPlots_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSignal_button;
        private System.Windows.Forms.ProgressBar FileRead_progressBar;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox WaveformPlots_groupBox;
        private System.Windows.Forms.ComboBox TimeUnits_comboBox;
        private System.Windows.Forms.ComboBox ActiveCurve_comboBox;
    }
}

