﻿
namespace PNC_dotnet472
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloredModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.runtimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.netPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.testResultTextbox = new System.Windows.Forms.TextBox();
            this.showXmlButton = new System.Windows.Forms.Button();
            this.openNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netPreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.startStopToolStripMenuItem,
            this.coloredModeToolStripMenuItem,
            this.evaulateToolStripMenuItem,
            this.openNetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.startStopToolStripMenuItem.Text = "&Start/Stop";
            this.startStopToolStripMenuItem.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
            // 
            // coloredModeToolStripMenuItem
            // 
            this.coloredModeToolStripMenuItem.Name = "coloredModeToolStripMenuItem";
            this.coloredModeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.coloredModeToolStripMenuItem.Text = "Change to Colored &Mode";
            this.coloredModeToolStripMenuItem.Click += new System.EventHandler(this.coloredModeToolStripMenuItem_Click);
            // 
            // evaulateToolStripMenuItem
            // 
            this.evaulateToolStripMenuItem.Name = "evaulateToolStripMenuItem";
            this.evaulateToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.evaulateToolStripMenuItem.Text = "&Evaulate";
            this.evaulateToolStripMenuItem.Click += new System.EventHandler(this.evaulateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.runtimeStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // runtimeStatusLabel
            // 
            this.runtimeStatusLabel.Name = "runtimeStatusLabel";
            this.runtimeStatusLabel.Size = new System.Drawing.Size(140, 17);
            this.runtimeStatusLabel.Text = "ETR NNN Steps @ M secs";
            this.runtimeStatusLabel.Visible = false;
            this.runtimeStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(608, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 10);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // netPreviewPictureBox
            // 
            this.netPreviewPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.netPreviewPictureBox.Location = new System.Drawing.Point(439, 27);
            this.netPreviewPictureBox.Name = "netPreviewPictureBox";
            this.netPreviewPictureBox.Size = new System.Drawing.Size(448, 487);
            this.netPreviewPictureBox.TabIndex = 3;
            this.netPreviewPictureBox.TabStop = false;
            this.netPreviewPictureBox.Click += new System.EventHandler(this.netPreviewPictureBox_Click);
            // 
            // testResultTextbox
            // 
            this.testResultTextbox.Enabled = false;
            this.testResultTextbox.Location = new System.Drawing.Point(12, 27);
            this.testResultTextbox.Name = "testResultTextbox";
            this.testResultTextbox.Size = new System.Drawing.Size(421, 20);
            this.testResultTextbox.TabIndex = 4;
            // 
            // showXmlButton
            // 
            this.showXmlButton.Enabled = false;
            this.showXmlButton.Location = new System.Drawing.Point(12, 506);
            this.showXmlButton.Name = "showXmlButton";
            this.showXmlButton.Size = new System.Drawing.Size(77, 24);
            this.showXmlButton.TabIndex = 0;
            this.showXmlButton.Text = "Show Xml";
            this.showXmlButton.UseVisualStyleBackColor = true;
            this.showXmlButton.Click += new System.EventHandler(this.showXmlButton_Click);
            // 
            // openNetToolStripMenuItem
            // 
            this.openNetToolStripMenuItem.Name = "openNetToolStripMenuItem";
            this.openNetToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openNetToolStripMenuItem.Text = "Open &Net ";
            this.openNetToolStripMenuItem.Click += new System.EventHandler(this.openNetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 555);
            this.Controls.Add(this.showXmlButton);
            this.Controls.Add(this.testResultTextbox);
            this.Controls.Add(this.netPreviewPictureBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PNC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.netPreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloredModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel runtimeStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox netPreviewPictureBox;
        private System.Windows.Forms.TextBox testResultTextbox;
        private System.Windows.Forms.Button showXmlButton;
        private System.Windows.Forms.ToolStripMenuItem openNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

