using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transform
{
    [Version(1, 0)]
    public class RandomTransform : IPlugin
    {
        public string Name
        {
            get
            {
                return "Шум";
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
            Random rnd = new Random();

            for (int i = 0; i < bitmap.Width * bitmap.Height * 2 / 10; ++i)
            {
                bitmap.SetPixel(rnd.Next(bitmap.Width), rnd.Next(bitmap.Height), 
                    Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            }
        }
    }
}
