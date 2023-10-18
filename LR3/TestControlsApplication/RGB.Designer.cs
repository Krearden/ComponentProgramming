namespace TestControlsApplication
{
    partial class RGB
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            RedLabel = new Label();
            GreenLabel = new Label();
            BlueLabel = new Label();
            DexBtn = new RadioButton();
            HexBtn = new RadioButton();
            pictureBox1 = new PictureBox();
            txtBoxRed = new TextBoxCustom(components);
            txtBoxGreen = new TextBoxCustom(components);
            txtBoxBlue = new TextBoxCustom(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RedLabel
            // 
            RedLabel.AutoSize = true;
            RedLabel.Location = new Point(13, 19);
            RedLabel.Name = "RedLabel";
            RedLabel.Size = new Size(56, 15);
            RedLabel.TabIndex = 3;
            RedLabel.Text = "Красный";
            // 
            // GreenLabel
            // 
            GreenLabel.AutoSize = true;
            GreenLabel.Location = new Point(13, 48);
            GreenLabel.Name = "GreenLabel";
            GreenLabel.Size = new Size(63, 15);
            GreenLabel.TabIndex = 4;
            GreenLabel.Text = "Зеленный";
            // 
            // BlueLabel
            // 
            BlueLabel.AutoSize = true;
            BlueLabel.Location = new Point(13, 77);
            BlueLabel.Name = "BlueLabel";
            BlueLabel.Size = new Size(43, 15);
            BlueLabel.TabIndex = 5;
            BlueLabel.Text = "Синий";
            // 
            // DexBtn
            // 
            DexBtn.AutoSize = true;
            DexBtn.Checked = true;
            DexBtn.Location = new Point(13, 115);
            DexBtn.Name = "DexBtn";
            DexBtn.Size = new Size(45, 19);
            DexBtn.TabIndex = 6;
            DexBtn.TabStop = true;
            DexBtn.Text = "Dec";
            DexBtn.UseVisualStyleBackColor = true;          
            DexBtn.Click += DexBtn_Click;
            // 
            // HexBtn
            // 
            HexBtn.AutoSize = true;
            HexBtn.Location = new Point(82, 115);
            HexBtn.Name = "HexBtn";
            HexBtn.Size = new Size(46, 19);
            HexBtn.TabIndex = 7;
            HexBtn.Text = "Hex";
            HexBtn.UseVisualStyleBackColor = true;
            HexBtn.Click += HexBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(193, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 96);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtBoxRed
            // 
            txtBoxRed.ForeColor = Color.Black;
            txtBoxRed.Location = new Point(82, 16);
            txtBoxRed.Name = "txtBoxRed";
            txtBoxRed.Size = new Size(64, 23);
            txtBoxRed.TabIndex = 9;
            txtBoxRed.TextChanged += txtBoxRed_TextChanged;
            // 
            // txtBoxGreen
            // 
            txtBoxGreen.ForeColor = Color.Black;
            txtBoxGreen.Location = new Point(82, 45);
            txtBoxGreen.Name = "txtBoxGreen";
            txtBoxGreen.Size = new Size(64, 23);
            txtBoxGreen.TabIndex = 10;
            txtBoxGreen.TextChanged += txtBoxGreen_TextChanged;
            // 
            // txtBoxBlue
            // 
            txtBoxBlue.ForeColor = Color.Black;
            txtBoxBlue.Location = new Point(82, 74);
            txtBoxBlue.Name = "txtBoxBlue";
            txtBoxBlue.Size = new Size(64, 23);
            txtBoxBlue.TabIndex = 11;
            txtBoxBlue.TextChanged += txtBoxBlue_TextChanged;
            // 
            // RGB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtBoxBlue);
            Controls.Add(txtBoxGreen);
            Controls.Add(txtBoxRed);
            Controls.Add(pictureBox1);
            Controls.Add(HexBtn);
            Controls.Add(DexBtn);
            Controls.Add(BlueLabel);
            Controls.Add(GreenLabel);
            Controls.Add(RedLabel);
            Name = "RGB";
            Size = new Size(338, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RedLabel;
        private Label GreenLabel;
        private Label BlueLabel;
        private PictureBox pictureBox1;
        private TextBoxCustom txtBoxRed;
        private TextBoxCustom txtBoxGreen;
        private TextBoxCustom txtBoxBlue;
        public RadioButton DexBtn;
        public RadioButton HexBtn;
    }
}
