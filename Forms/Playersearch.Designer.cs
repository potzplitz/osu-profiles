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
            this.rank = new System.Windows.Forms.Label();
            this.pfpImg = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.startsearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.meRank = new System.Windows.Forms.Label();
            this.meName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel2.Controls.Add(this.rank);
            this.panel2.Controls.Add(this.pfpImg);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 156);
            this.panel2.TabIndex = 2;
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(169, 78);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(148, 34);
            this.rank.TabIndex = 2;
            this.rank.Text = "rank";
            // 
            // pfpImg
            // 
            this.pfpImg.Location = new System.Drawing.Point(24, 22);
            this.pfpImg.Name = "pfpImg";
            this.pfpImg.Size = new System.Drawing.Size(109, 105);
            this.pfpImg.TabIndex = 0;
            this.pfpImg.Text = "profilepicture";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(170, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 35);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Salmon;
            this.panel5.Controls.Add(this.meRank);
            this.panel5.Controls.Add(this.meName);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 46);
            this.panel5.TabIndex = 3;
            // 
            // meRank
            // 
            this.meRank.Location = new System.Drawing.Point(5, 24);
            this.meRank.Name = "meRank";
            this.meRank.Size = new System.Drawing.Size(75, 19);
            this.meRank.TabIndex = 1;
            this.meRank.Text = "rank";
            // 
            // meName
            // 
            this.meName.Location = new System.Drawing.Point(4, 5);
            this.meName.Name = "meName";
            this.meName.Size = new System.Drawing.Size(77, 20);
            this.meName.TabIndex = 0;
            this.meName.Text = "name";
            this.meName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Playersearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.startsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Load += new System.EventHandler(this.Playersearch_Load);
            this.Name = "Playersearch";
            this.Text = "Spieler Suchen";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label meName;
        public System.Windows.Forms.Label meRank;

        private System.Windows.Forms.Label name;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label pfpImg;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button startsearch;
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;

        

        #endregion
    }
}