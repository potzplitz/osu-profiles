﻿using System.ComponentModel;

namespace osu_profiles
{
    partial class Main
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
        private void InitializeComponent()
        {
            this.authorized = new System.Windows.Forms.Label();
            this.ButtonAuthorize = new System.Windows.Forms.Button();
            this.rank = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorized
            // 
            this.authorized.Location = new System.Drawing.Point(0, 0);
            this.authorized.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorized.Name = "authorized";
            this.authorized.Size = new System.Drawing.Size(148, 18);
            this.authorized.TabIndex = 0;
            this.authorized.Text = "nicht autorisiert";
            this.authorized.Click += new System.EventHandler(this.authorized_Click);
            // 
            // ButtonAuthorize
            // 
            this.ButtonAuthorize.Location = new System.Drawing.Point(167, 103);
            this.ButtonAuthorize.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAuthorize.Name = "ButtonAuthorize";
            this.ButtonAuthorize.Size = new System.Drawing.Size(340, 54);
            this.ButtonAuthorize.TabIndex = 1;
            this.ButtonAuthorize.Text = "Autorisieren";
            this.ButtonAuthorize.UseVisualStyleBackColor = true;
            this.ButtonAuthorize.Click += new System.EventHandler(this.ButtonAuthorize_Click);
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(0, 18);
            this.rank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(109, 18);
            this.rank.TabIndex = 2;
            this.rank.Text = "Rang";
            this.rank.Click += new System.EventHandler(this.rank_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.authorized);
            this.panel1.Controls.Add(this.rank);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 36);
            this.panel1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonAuthorize);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Autorisieren";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;

        public System.Windows.Forms.Label rank;

        public System.Windows.Forms.Button ButtonAuthorize;

        public System.Windows.Forms.Label authorized;

        #endregion
    }
}