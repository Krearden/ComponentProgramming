using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControlsApplication
{
    public partial class RGB : UserControl
    {
        private Color _color = Color.FromArgb(0, 0, 0);

        public Color ColorWidget
        {
            get
            {
                return pictureBox1.BackColor;
            }
            set
            {
                _color = value;
                pictureBox1.BackColor = value;
                txtBoxRed.Text = DexBtn.Checked ? value.R.ToString() : value.R.ToString("X");
                txtBoxGreen.Text = DexBtn.Checked ? value.G.ToString() : value.G.ToString("X");
                txtBoxBlue.Text = DexBtn.Checked ? value.B.ToString() : value.B.ToString("X");
            }
        }

        public RGB()
        {
            InitializeComponent();
            ChangeColor();
        }
        // Метод "событие", реализующее смену цветов
        public void ChangeColor()
        {
            int R, G, B;

            // Десятичный конвертер
            if (DexBtn.Checked)
            {
                R = int.Parse(txtBoxRed.Text);
                G = int.Parse(txtBoxGreen.Text);
                B = int.Parse(txtBoxBlue.Text);
                ColorWidget = Color.FromArgb(R, G, B);
            }
            // Шестнадцетиричный конвертер
            else if (HexBtn.Checked)
            {
                R = Convert.ToInt32(txtBoxRed.Text, 16);
                G = Convert.ToInt32(txtBoxGreen.Text, 16);
                B = Convert.ToInt32(txtBoxBlue.Text, 16);
                ColorWidget = Color.FromArgb(R, G, B);
            }
        }

        private void txtBoxRed_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRed.Text != "" && txtBoxGreen.Text != "" && txtBoxBlue.Text != "")
            {
                ChangeColor();
            }
        }

        private void txtBoxGreen_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRed.Text != "" && txtBoxGreen.Text != "" && txtBoxBlue.Text != "")
            {
                ChangeColor();
            }
        }

        private void txtBoxBlue_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRed.Text != "" && txtBoxGreen.Text != "" && txtBoxBlue.Text != "")
            {
                ChangeColor();
            }
        }

        private void HexBtn_Click(object sender, EventArgs e)
        {
            ConvertDecToHex();
            txtBoxRed.DecOrHex = "Hex";
            txtBoxGreen.DecOrHex = "Hex";
            txtBoxBlue.DecOrHex = "Hex";
            DexBtn.Enabled = true;
        }

        private void DexBtn_Click(object sender, EventArgs e)
        {
            ConvertHexToDec();
            txtBoxRed.DecOrHex = "Dec";
            txtBoxGreen.DecOrHex = "Dec";
            txtBoxBlue.DecOrHex = "Dec";
            HexBtn.Enabled = true;
        }

        private void ConvertHexToDec()
        {
            if (txtBoxRed.Text != "" && txtBoxGreen.Text != "" && txtBoxBlue.Text != "")
            {
                int red = Convert.ToInt32(txtBoxRed.Text, 16);
                int green = Convert.ToInt32(txtBoxGreen.Text, 16);
                int blue = Convert.ToInt32(txtBoxBlue.Text, 16);

                // Отключаем обработчик изменения текста
                txtBoxRed.TextChanged -= txtBoxRed_TextChanged;
                txtBoxBlue.TextChanged -= txtBoxBlue_TextChanged;
                txtBoxGreen.TextChanged -= txtBoxGreen_TextChanged;

                txtBoxRed.Text = red.ToString();
                txtBoxGreen.Text = green.ToString();
                txtBoxBlue.Text = blue.ToString();

                // Включаем обработчик изменения текста
                txtBoxRed.TextChanged += txtBoxRed_TextChanged;
                txtBoxBlue.TextChanged += txtBoxBlue_TextChanged;
                txtBoxGreen.TextChanged += txtBoxGreen_TextChanged;
            }
        }
        private void ConvertDecToHex()
        {
            if (txtBoxRed.Text != "" && txtBoxGreen.Text != "" && txtBoxBlue.Text != "")
            {
                int red = int.Parse(txtBoxRed.Text);
                int green = int.Parse(txtBoxGreen.Text);
                int blue = int.Parse(txtBoxBlue.Text);

                // Отключаем обработчик изменения текста
                txtBoxRed.TextChanged -= txtBoxRed_TextChanged;
                txtBoxBlue.TextChanged -= txtBoxBlue_TextChanged;
                txtBoxGreen.TextChanged -= txtBoxGreen_TextChanged;

                txtBoxRed.Text = red.ToString("X");
                txtBoxGreen.Text = green.ToString("X");
                txtBoxBlue.Text = blue.ToString("X");

                // Включаем обработчик изменения текста
                txtBoxRed.TextChanged += txtBoxRed_TextChanged;
                txtBoxBlue.TextChanged += txtBoxBlue_TextChanged;
                txtBoxGreen.TextChanged += txtBoxGreen_TextChanged;
            }
        }
    }
}

