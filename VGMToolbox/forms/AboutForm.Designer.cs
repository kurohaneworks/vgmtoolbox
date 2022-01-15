namespace VGMToolbox.forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.linkLabelHomePage = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.linkLabelSupport = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelHomePage
            // 
            this.linkLabelHomePage.AutoSize = true;
            this.linkLabelHomePage.Location = new System.Drawing.Point(9, 171);
            this.linkLabelHomePage.Name = "linkLabelHomePage";
            this.linkLabelHomePage.Size = new System.Drawing.Size(74, 15);
            this.linkLabelHomePage.TabIndex = 0;
            this.linkLabelHomePage.TabStop = true;
            this.linkLabelHomePage.Text = "Home Page";
            this.linkLabelHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(142, 229);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Close";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tbMain
            // 
            this.tbMain.AcceptsReturn = true;
            this.tbMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMain.Location = new System.Drawing.Point(12, 13);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMain.Size = new System.Drawing.Size(331, 121);
            this.tbMain.TabIndex = 2;
            this.tbMain.Text = resources.GetString("tbMain.Text");
            // 
            // linkLabelSupport
            // 
            this.linkLabelSupport.AutoSize = true;
            this.linkLabelSupport.Location = new System.Drawing.Point(9, 191);
            this.linkLabelSupport.Name = "linkLabelSupport";
            this.linkLabelSupport.Size = new System.Drawing.Size(116, 15);
            this.linkLabelSupport.TabIndex = 3;
            this.linkLabelSupport.TabStop = true;
            this.linkLabelSupport.Text = "Support/Questions";
            this.linkLabelSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "VGMToolbox is freeware, Licensed under the MIT license.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email: vgmtoolbox@gmail.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(355, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelSupport);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.linkLabelHomePage);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About VGMToolbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelHomePage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.LinkLabel linkLabelSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}