using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;
using System.Configuration;
using System.Collections.Specialized;

namespace MainApp
{
    public partial class MainApp : Form
    {
        Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();

        public MainApp()
        {
            InitializeComponent();
            FindPlugins();
            ShowPlugins();
            CreatePluginsMenu();
        }


        //Метод - создаем диалоговое окошко, заполняем элемент DataGrid этого окошлка данными о загруженных плагинах
        private void ShowPlugins()
        {
            var dialog = new Dialog();
            dialog.DataGrid.Rows.Clear();

            foreach (var item in plugins)
            {
                VersionAttribute attr = (VersionAttribute)Attribute.GetCustomAttribute(item.Value.GetType(), typeof(VersionAttribute));
                dialog.DataGrid.Rows.Add(new object[] { 
                    item.Value.Name, item.Value.Author, attr.Major
                });
            }
            dialog.ShowDialog();
        }

        //Метод - с помощью рефлексии находит плагины в папке с приложением и загружает их сборки
        public void FindPlugins()
        {
            // папка с плагинами
            string folder = System.AppDomain.CurrentDomain.BaseDirectory;

            // dll-файлы в этой папке
            string[] files = Directory.GetFiles(folder, "*.dll");
            // список - содержит список имен реализованных плагинов
            string[] plugin_names = ConfigurationManager.AppSettings.AllKeys;
            foreach (string file in files)
            {
                if (plugin_names.Length > 0 && !plugin_names.Contains(file.Split('\\').Last().Split('.').First()))
                {
                    continue;
                }

                try
                {
                    Assembly assembly = Assembly.LoadFile(file);

                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("PluginInterface.IPlugin");

                        if (iface != null)
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
            }

        }

        //Метод - поочередно добавляем загруженные плагины в Меню
        private void CreatePluginsMenu()
        {
            foreach (var name in plugins.Keys)
            {
                var pluginItem = new ToolStripMenuItem(name, null, OnPluginClick);
                FiltersItem.DropDownItems.Add(pluginItem);
                Menu.Items.Add(FiltersItem);
            }
        }

        //Обработчик события "Нажатие на плагин в выпадающем меню"
        //Применяет фукнцию плагина Transform к изображению в PictureBox
        private void OnPluginClick(object sender, EventArgs e)
        {
            var plugin = plugins[((ToolStripMenuItem)sender).Text];
            Bitmap image = (Bitmap)PictureBox.Image;
            PictureBox.Image = null;
            plugin.Transform(image);
            PictureBox.Image = image;
        }
    }


}
