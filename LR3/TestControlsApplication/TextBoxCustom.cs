using System.ComponentModel;

namespace TestControlsApplication
{
    public partial class TextBoxCustom : TextBox
    {
        public string DecOrHex = "Dec";
        public TextBoxCustom()
        {
            InitializeComponent();
        }
        public TextBoxCustom(IContainer container)
        {
            container.Add(this);
            Text = "0";
            InitializeComponent();          
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Проверяем, были ли нажаты клавиши Ctrl и V одновременно
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Вставляем текст из буфера обмена
                if (Clipboard.ContainsText())
                {
                    string str = Clipboard.GetText();
                    int res;
                    try
                    {
                        res = DecOrHex == "Dec" ? Convert.ToInt32(str) : Convert.ToInt32(str, 16);
                    }
                    catch
                    {
                        res = 0;
                    }
                    if (res <= 255 && res >= 0)
                        str = res.ToString();
                    else if (res < 0)
                        str = "0";
                    else
                        str = "255";
                    Text = str;
                }
            }

            // Вызываем базовую реализацию OnKeyDown
            base.OnKeyDown(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (DecOrHex == "Dec")
            {
                if (e.KeyChar == '\b' || char.IsDigit(e.KeyChar))
                {
                    if (e.KeyChar == '\b')
                        base.OnKeyPress(e);
                    else if (СonvertDecToInt(e.KeyChar) <= 255 && СonvertDecToInt(e.KeyChar) > 0)   // Число можно интерпритировать как насыщенность цвет
                        base.OnKeyPress(e);
                    else if (СonvertDecToInt(e.KeyChar) > 255)  // Число больше допустимой насыщенности
                    {
                        this.Text = "255";  // Устанавливаем максимально допустимую насыщенность
                        e.Handled = true;   // Имитируем отработку события
                    }
                    else if (СonvertDecToInt(e.KeyChar) < 0)  // Число меньше допустимой насыщенности
                    {
                        this.Text = "0";    // Устанавливаем минимально допустимую насыщенность
                        e.Handled = true;   // Имитируем отработку события
                    }
                    else
                        e.Handled = true;   // Имитируем отработку события
                }
                else
                {
                    e.Handled = true;   // Имитируем отработку события
                }
            }
            else if (DecOrHex == "Hex")
            {
                if (e.KeyChar == '\b' || char.IsDigit(e.KeyChar) || IsHexDigit(e.KeyChar))
                {
                    if (e.KeyChar == '\b')
                        base.OnKeyPress(e); // Имитируем отработку события
                    else if (ConvertHexToInt(e.KeyChar) <= 255 && ConvertHexToInt(e.KeyChar) >= 0)
                        base.OnKeyPress(e);
                    else if (ConvertHexToInt(e.KeyChar) > 255)  // Число больше допустимой насыщенности
                    {
                        this.Text = "FF";   // Устанавливаем максимально допустимую насыщенность
                        e.Handled = true;   // Имитируем отработку события
                    }
                    else if (ConvertHexToInt(e.KeyChar) < 0)  // Число меньше допустимой насыщенности
                    {
                        this.Text = "0";   // Устанавливаем минимально допустимую насыщенность
                        e.Handled = true;   // Имитируем отработку события
                    }
                    else
                        e.Handled = true;
                }
                else
                    e.Handled = true; // Разрешаем только цифры dec и hex
            }
        }
        private bool IsHexDigit(char c)
        {
            return (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        }
        private int СonvertDecToInt(char simbol)
        {
            string str = Text + simbol.ToString();           
            return int.Parse(str);
        }
        private int ConvertHexToInt(char simbol)
        {
            string str = Text + simbol.ToString();
            return Convert.ToInt32(str, 16);
        }
    }
}
