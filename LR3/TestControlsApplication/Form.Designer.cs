namespace TestControlsApplication
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rgb1 = new TestControlsApplication.RGB();
            this.SuspendLayout();
            // 
            // rgb1
            // 
            this.rgb1.Location = new System.Drawing.Point(0, 12);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(364, 163);
            this.rgb1.TabIndex = 5;
            this.rgb1.Load += new System.EventHandler(this.rgb1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 176);
            this.Controls.Add(this.rgb1);
            this.MaximumSize = new System.Drawing.Size(381, 215);
            this.MinimumSize = new System.Drawing.Size(381, 215);
            this.Name = "Form1";
            this.Text = "LR3 - Color Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RGB rgb1;
    }
}