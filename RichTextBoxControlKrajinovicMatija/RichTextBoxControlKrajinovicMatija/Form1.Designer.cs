namespace RichTextBoxControlKrajinovicMatija
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.citaj = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(324, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 127);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // citaj
            // 
            this.citaj.Location = new System.Drawing.Point(324, 65);
            this.citaj.Name = "citaj";
            this.citaj.Size = new System.Drawing.Size(75, 23);
            this.citaj.TabIndex = 1;
            this.citaj.Text = "Citaj";
            this.citaj.UseVisualStyleBackColor = true;
            this.citaj.Click += new System.EventHandler(this.citaj_Click);
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(362, 325);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(75, 23);
            this.spremi.TabIndex = 3;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(405, 65);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(75, 23);
            this.brisi.TabIndex = 4;
            this.brisi.Text = "Brisi";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu
            // 
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(84, 20);
            this.StripMenu.Text = "O programu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.citaj);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button citaj;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenu;
    }
}

