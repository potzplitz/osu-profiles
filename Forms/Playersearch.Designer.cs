using System.ComponentModel;

namespace osu_profiles
{
    partial class Playersearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
        public void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(-2, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 517);
            this.panel1.TabIndex = 1;
            // 
            // startsearch
            // 
            this.startsearch.Location = new System.Drawing.Point(322, 55);
            this.startsearch.Name = "startsearch";
            this.startsearch.Size = new System.Drawing.Size(182, 29);
            this.startsearch.TabIndex = 2;
            this.startsearch.Text = "Spielersuche Starten";
            this.startsearch.UseVisualStyleBackColor = true;
            // 
            // Playersearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 624);
            this.Controls.Add(this.startsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Playersearch";
            this.Text = "Spieler Suchen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button startsearch;
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}