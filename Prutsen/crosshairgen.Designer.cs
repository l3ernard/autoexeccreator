namespace Prutsen
{
    partial class crosshairgen
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
            this.ch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ch
            // 
            this.ch.Location = new System.Drawing.Point(3, 4);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(350, 350);
            this.ch.TabIndex = 0;
            this.ch.Paint += new System.Windows.Forms.PaintEventHandler(this.ch_Paint);
            // 
            // crosshairgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 361);
            this.Controls.Add(this.ch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "crosshairgen";
            this.Text = "crosshairgen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ch;
    }
}