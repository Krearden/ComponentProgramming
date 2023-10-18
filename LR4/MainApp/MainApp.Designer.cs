namespace MainApp
{
    partial class MainApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FiltersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltersItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(529, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FiltersItem
            // 
            this.FiltersItem.Name = "FiltersItem";
            this.FiltersItem.Size = new System.Drawing.Size(50, 22);
            this.FiltersItem.Text = "Filters";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::MainApp.Properties.Resources.Lenna512;
            this.PictureBox.Location = new System.Drawing.Point(8, 23);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(512, 512);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 549);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FiltersItem;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

