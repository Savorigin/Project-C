namespace prj_2018_02_06_WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxOk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOk2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(165, 24);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 20);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            this.buttonOk.Enter += new System.EventHandler(this.buttonOk_Enter);
            // 
            // textBoxOk
            // 
            this.textBoxOk.Location = new System.Drawing.Point(27, 24);
            this.textBoxOk.Name = "textBoxOk";
            this.textBoxOk.Size = new System.Drawing.Size(100, 20);
            this.textBoxOk.TabIndex = 1;
            this.textBoxOk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 158);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxOk2
            // 
            this.textBoxOk2.Location = new System.Drawing.Point(274, 24);
            this.textBoxOk2.Multiline = true;
            this.textBoxOk2.Name = "textBoxOk2";
            this.textBoxOk2.Size = new System.Drawing.Size(217, 225);
            this.textBoxOk2.TabIndex = 3;
            this.textBoxOk2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.textBoxOk2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOk);
            this.Controls.Add(this.buttonOk);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOk2;
    }
}

