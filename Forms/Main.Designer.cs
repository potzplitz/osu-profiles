using System.ComponentModel;

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
            this.SuspendLayout();
            // 
            // authorized
            // 
            this.authorized.Location = new System.Drawing.Point(456, 32);
            this.authorized.Name = "authorized";
            this.authorized.Size = new System.Drawing.Size(220, 33);
            this.authorized.TabIndex = 0;
            this.authorized.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorized);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Label authorized;

        #endregion
    }
}