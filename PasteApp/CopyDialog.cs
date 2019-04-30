﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;



namespace PasteApp
{
    public partial class CopyDialog : Form
    {
        private TableLayoutPanel tlp;
        private Label lblDescription;
        private TableLayoutPanel tlpHorizontal;
        private Label lblPercentage;
        private Button btnPause;
        private Button btnCancel;
        private ProgressBar pbProgressBar;
        private Label lblSpeed;
        private Label lblCurrentFileName;
        private Label lblTimeRemaining;
        private Label lblItemsRemaining;
        
      
        public CopyDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDialog));
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrentFileName = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblItemsRemaining = new System.Windows.Forms.Label();
            this.tlpHorizontal = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tlp.SuspendLayout();
            this.tlpHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Controls.Add(this.lblDescription, 0, 0);
            this.tlp.Controls.Add(this.pbProgressBar, 0, 2);
            this.tlp.Controls.Add(this.lblCurrentFileName, 0, 4);
            this.tlp.Controls.Add(this.lblTimeRemaining, 0, 5);
            this.tlp.Controls.Add(this.lblItemsRemaining, 0, 6);
            this.tlp.Controls.Add(this.tlpHorizontal, 0, 1);
            this.tlp.Controls.Add(this.lblSpeed, 0, 3);
            this.tlp.Location = new System.Drawing.Point(25, 15);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 7;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.Size = new System.Drawing.Size(400, 190);
            this.tlp.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 5);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Copying items from  to ";
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Location = new System.Drawing.Point(3, 69);
            this.pbProgressBar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(394, 21);
            this.pbProgressBar.TabIndex = 2;
            // 
            // lblCurrentFileName
            // 
            this.lblCurrentFileName.AutoSize = true;
            this.lblCurrentFileName.Location = new System.Drawing.Point(3, 123);
            this.lblCurrentFileName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblCurrentFileName.Name = "lblCurrentFileName";
            this.lblCurrentFileName.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentFileName.TabIndex = 4;
            this.lblCurrentFileName.Text = "Name: ";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(3, 146);
            this.lblTimeRemaining.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(84, 13);
            this.lblTimeRemaining.TabIndex = 5;
            this.lblTimeRemaining.Text = "Time remaining: ";
            // 
            // lblItemsRemaining
            // 
            this.lblItemsRemaining.AutoSize = true;
            this.lblItemsRemaining.Location = new System.Drawing.Point(3, 169);
            this.lblItemsRemaining.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblItemsRemaining.Name = "lblItemsRemaining";
            this.lblItemsRemaining.Size = new System.Drawing.Size(86, 13);
            this.lblItemsRemaining.TabIndex = 6;
            this.lblItemsRemaining.Text = "Items remaining: ";
            // 
            // tlpHorizontal
            // 
            this.tlpHorizontal.ColumnCount = 4;
            this.tlpHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpHorizontal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpHorizontal.Controls.Add(this.lblPercentage, 0, 0);
            this.tlpHorizontal.Controls.Add(this.btnPause, 1, 0);
            this.tlpHorizontal.Controls.Add(this.btnCancel, 3, 0);
            this.tlpHorizontal.Location = new System.Drawing.Point(3, 26);
            this.tlpHorizontal.Name = "tlpHorizontal";
            this.tlpHorizontal.RowCount = 1;
            this.tlpHorizontal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHorizontal.Size = new System.Drawing.Size(394, 34);
            this.tlpHorizontal.TabIndex = 7;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPercentage.Location = new System.Drawing.Point(3, 8);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(100, 18);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "% complete";
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(294, 5);
            this.btnPause.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(25, 25);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(364, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(3, 102);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed: ";
            // 
            // CopyDialog
            // 
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.Controls.Add(this.tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CopyDialog";
            this.Text = "0% complete";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.tlpHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

