namespace DoubleGlazer
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.txtbHeight = new System.Windows.Forms.TextBox();
            this.txtbWidth = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cmbOutput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(371, 106);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(312, 22);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Enter the height of the window: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(305, 22);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Enter the width of the window: ";
            // 
            // cmbHeight
            // 
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Items.AddRange(new object[] {
            "cm",
            "inches"});
            this.cmbHeight.Location = new System.Drawing.Point(443, 29);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(66, 21);
            this.cmbHeight.TabIndex = 3;
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "cm",
            "inches"});
            this.cmbWidth.Location = new System.Drawing.Point(443, 69);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(66, 21);
            this.cmbWidth.TabIndex = 4;
            // 
            // txtbHeight
            // 
            this.txtbHeight.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbHeight.Location = new System.Drawing.Point(321, 29);
            this.txtbHeight.Name = "txtbHeight";
            this.txtbHeight.Size = new System.Drawing.Size(111, 20);
            this.txtbHeight.TabIndex = 5;
            this.txtbHeight.Text = "0";
            this.txtbHeight.Enter += new System.EventHandler(this.txtbHeight_Enter);
            // 
            // txtbWidth
            // 
            this.txtbWidth.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbWidth.Location = new System.Drawing.Point(321, 69);
            this.txtbWidth.Name = "txtbWidth";
            this.txtbWidth.Size = new System.Drawing.Size(110, 20);
            this.txtbWidth.TabIndex = 6;
            this.txtbWidth.Text = "0";
            this.txtbWidth.Enter += new System.EventHandler(this.txtbWidth_Enter);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 145);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(496, 151);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(167, 105);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(109, 18);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Output units: ";
            // 
            // cmbOutput
            // 
            this.cmbOutput.FormattingEnabled = true;
            this.cmbOutput.Items.AddRange(new object[] {
            "cm",
            "inches"});
            this.cmbOutput.Location = new System.Drawing.Point(282, 106);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(83, 21);
            this.cmbOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 309);
            this.Controls.Add(this.cmbOutput);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.txtbWidth);
            this.Controls.Add(this.txtbHeight);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.cmbHeight);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fred\'s Double Glazing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbHeight;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.TextBox txtbHeight;
        private System.Windows.Forms.TextBox txtbWidth;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cmbOutput;
    }
}

