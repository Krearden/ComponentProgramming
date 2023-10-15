using PluginInterface;
using System.Drawing;

namespace Transforms
{
    [Version(1, 0)]
    public class ColorfulToGrayTransform : IPlugin
    {
        public string Name
        {
            get
            {
                return "Преобразовать цветное изображение в оттенки серого";
            }
        }

        public string Author
        {
            get
            {
                return "Me";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            // Перебираем каждый пиксель в изображении
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    // Получаем цвет текущего пикселя
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Вычисляем среднее значение RGB компонентов пикселя для получение серого цвета.
                    // Используем весовые коэффициенты
                    int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                    // Создаем новый цвет, установив все компоненты равными среднему значению
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    // Устанавливаем новый цвет для пикселя
                    bitmap.SetPixel(x, y, grayColor);
                }
            }
        }

    }
}