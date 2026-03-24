namespace BrainTrack1
{
    partial class BrainTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrainTrack));
            this.PageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PageButton
            // 
            this.PageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.PageButton.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PageButton.Location = new System.Drawing.Point(788, 588);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(274, 65);
            this.PageButton.TabIndex = 0;
            this.PageButton.Text = "Let\'s Get Started!";
            this.PageButton.UseVisualStyleBackColor = false;
            this.PageButton.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // BrainTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.PageButton);
            this.Name = "BrainTrack";
            this.ShowInTaskbar = false;
            this.Text = "BrainTrack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PageButton;
    }
}

