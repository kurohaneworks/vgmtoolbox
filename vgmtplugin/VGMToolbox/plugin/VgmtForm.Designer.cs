namespace VGMToolbox.plugin
{
    partial class VgmtForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlLabels = new System.Windows.Forms.Panel();
            this.lblProgressLabel = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDoTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(629, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 20);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(373, 19);
            // 
            // pnlLabels
            // 
            this.pnlLabels.Controls.Add(this.lblProgressLabel);
            this.pnlLabels.Controls.Add(this.lblTimeElapsed);
            this.pnlLabels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLabels.Location = new System.Drawing.Point(0, 407);
            this.pnlLabels.Name = "pnlLabels";
            this.pnlLabels.Size = new System.Drawing.Size(629, 21);
            this.pnlLabels.TabIndex = 1;
            // 
            // lblProgressLabel
            // 
            this.lblProgressLabel.AutoSize = true;
            this.lblProgressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProgressLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProgressLabel.Location = new System.Drawing.Point(61, 0);
            this.lblProgressLabel.MinimumSize = new System.Drawing.Size(532, 0);
            this.lblProgressLabel.Name = "lblProgressLabel";
            this.lblProgressLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblProgressLabel.Size = new System.Drawing.Size(532, 19);
            this.lblProgressLabel.TabIndex = 1;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeElapsed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimeElapsed.Location = new System.Drawing.Point(0, 0);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblTimeElapsed.Size = new System.Drawing.Size(61, 19);
            this.lblTimeElapsed.TabIndex = 0;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitle.Location = new System.Drawing.Point(0, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(629, 24);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Section Title";
            // 
            // tbOutput
            // 
            this.tbOutput.AcceptsReturn = true;
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbOutput.Location = new System.Drawing.Point(0, 318);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(629, 89);
            this.tbOutput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbOutput, "Double-Click to view in your default text editor.");
            this.tbOutput.DoubleClick += new System.EventHandler(this.tbOutput_DoubleClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDoTask);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 294);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(629, 24);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnDoTask
            // 
            this.btnDoTask.AutoSize = true;
            this.btnDoTask.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoTask.Location = new System.Drawing.Point(489, 0);
            this.btnDoTask.Name = "btnDoTask";
            this.btnDoTask.Size = new System.Drawing.Size(70, 24);
            this.btnDoTask.TabIndex = 1;
            this.btnDoTask.Text = "Do Task";
            this.btnDoTask.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(559, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.backgroundWorker_Cancel);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(629, 453);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.pnlLabels);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VgmtForm";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        protected System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        protected System.Windows.Forms.Panel pnlLabels;
        protected System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Label lblProgressLabel;
        protected System.Windows.Forms.Label lblTimeElapsed;
        protected System.Windows.Forms.TextBox tbOutput;
        protected System.Windows.Forms.Panel pnlButtons;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnDoTask;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        protected System.Windows.Forms.ToolTip toolTip1;
    }
}