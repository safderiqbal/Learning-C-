namespace LearningWindows
{
    partial class First
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
            this.bExit = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.mTitleBar = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mINew = new System.Windows.Forms.ToolStripMenuItem();
            this.mIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(332, 314);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bStart
            // 
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Location = new System.Drawing.Point(13, 314);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // mTitleBar
            // 
            this.mTitleBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile});
            this.mTitleBar.Location = new System.Drawing.Point(0, 0);
            this.mTitleBar.Name = "mTitleBar";
            this.mTitleBar.Size = new System.Drawing.Size(419, 24);
            this.mTitleBar.TabIndex = 3;
            this.mTitleBar.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mINew,
            this.mIExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(37, 20);
            this.mFile.Text = "File";
            // 
            // mINew
            // 
            this.mINew.Name = "mINew";
            this.mINew.Size = new System.Drawing.Size(152, 22);
            this.mINew.Text = "New";
            // 
            // mIExit
            // 
            this.mIExit.Name = "mIExit";
            this.mIExit.Size = new System.Drawing.Size(152, 22);
            this.mIExit.Text = "Exit";
            this.mIExit.Click += new System.EventHandler(this.mIExit_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(419, 349);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.mTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mTitleBar;
            this.Name = "First";
            this.Text = "YOLO";
            this.mTitleBar.ResumeLayout(false);
            this.mTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.MenuStrip mTitleBar;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mINew;
        private System.Windows.Forms.ToolStripMenuItem mIExit;

    }
}

