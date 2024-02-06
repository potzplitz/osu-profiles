using System;
using System.ComponentModel;
using System.Net.Mime;
using System.Security.Permissions;
using System.Windows.Forms;

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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pfpImg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startsearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 636);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1114, 368);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(356, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 153);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pfpImg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 156);
            this.panel2.TabIndex = 2;
            // 
            // pfpImg
            // 
            this.pfpImg.Location = new System.Drawing.Point(24, 22);
            this.pfpImg.Name = "pfpImg";
            this.pfpImg.Size = new System.Drawing.Size(109, 105);
            this.pfpImg.TabIndex = 0;
            this.pfpImg.Text = "profilepicture";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(169, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // startsearch
            // 
            this.startsearch.Location = new System.Drawing.Point(429, 68);
            this.startsearch.Margin = new System.Windows.Forms.Padding(4);
            this.startsearch.Name = "startsearch";
            this.startsearch.Size = new System.Drawing.Size(243, 36);
            this.startsearch.TabIndex = 2;
            this.startsearch.Text = "Spielersuche Starten";
            this.startsearch.UseVisualStyleBackColor = true;
            // 
            // Playersearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 768);
            this.Controls.Add(this.startsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Playersearch";
            this.Text = "Spieler Suchen";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label pfpImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button startsearch;
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;

        

        #endregion
    }
}