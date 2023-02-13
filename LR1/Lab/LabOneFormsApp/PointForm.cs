using Newtonsoft.Json;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Point = PointLib.Point;

namespace LabOneFormsApp
{
    public partial class Form1 : Form
    {
        private Point[] points = null;
        private Point3D[] points3d = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            points = new Point[5];
            var rnd = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = rnd.Next(3) % 2 == 0 ? new Point() : new Point3D();
            }
            listBox.DataSource = points;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (points == null)
                return;
            Array.Sort(points);
            listBox.DataSource = null;
            listBox.DataSource = points;
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "SOAP|*.soap|XML|*.xml|JSON|*.json|Binary|*.bin";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
            {
                switch (Path.GetExtension(dlg.FileName))
                {
                    case ".bin":
                        var bf = new BinaryFormatter();
                        bf.Serialize(fs, points);
                        break;
                    case ".soap":
                        var sf = new SoapFormatter();
                        sf.Serialize(fs, points);
                        break;
                    case ".xml":
                        var xf = new XmlSerializer(typeof(Point[]), new[] { typeof(Point3D) });
                        xf.Serialize(fs, points);
                        break;
                    case ".json":
                        var jf = new JsonSerializer();
                        using (var w = new StreamWriter(fs))
                            jf.Serialize(w, points);
                        break;
                }
            }
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "SOAP|*.soap|XML|*.xml|JSON|*.json|Binary|*.bin";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            using (var fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
            {
                switch (Path.GetExtension(dlg.FileName))
                {
                    case ".bin":
                        var bf = new BinaryFormatter();
                        points = (Point[])bf.Deserialize(fs);
                        break;
                    case ".soap":
                        var sf = new SoapFormatter();
                        points = (Point[])sf.Deserialize(fs);
                        break;
                    case ".xml":
                        var xf = new XmlSerializer(typeof(Point[]), new[] { typeof(Point3D) });
                        points = (Point[])xf.Deserialize(fs);
                        break;
                    case ".json":
                        var reader = new StreamReader(fs).ReadToEnd();
                        var jsonFile = JsonConvert.DeserializeObject<List<Dictionary<string, int>>>(reader);

                        if (jsonFile != null)
                        {
                            points = new Point[jsonFile.Count];

                            for (int i = 0; i < jsonFile.Count; i++)
                            {
                                var pointDict = jsonFile[i];

                                switch (pointDict.Count)
                                {
                                    case 2:
                                        points[i] = new Point(pointDict["X"], pointDict["Y"]);
                                        break;

                                    case 3:
                                        points[i] = new Point3D(pointDict["X"], pointDict["Y"], pointDict["Z"]);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            points = null;
                        }
                        //var jf = new JsonSerializer();
                        //var reader = new StreamReader(fs).ReadToEnd();
                        //var jsonFile = JsonConvert.DeserializeObject<List<Dictionary<string, int>>>(reader);
                        //if (jsonFile != null)
                        //{
                        //    points = new Point[jsonFile.Count];
                        //    for (int i = 0; i < jsonFile.Count; i++)
                        //    {
                        //        if (jsonFile[i].Count == 2)
                        //        {
                        //            points[i] = new Point(jsonFile[i]["X"], jsonFile[i]["Y"]);
                        //        }
                        //        else if (jsonFile[i].Count == 3)
                        //        {
                        //            points[i] = new Point3D(jsonFile[i]["X"], jsonFile[i]["Y"], jsonFile[i]["Z"]);
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    points = new Point[1];
                        //}

                        break;
                        //суть проблемы - при десериализации программа создает новые объекты point3d с тремя переменными.
                        //причем в файле могут быть оъекты point только с двумя переменными
                        //элементы point создаются как point3d
                }
            }

            listBox.DataSource = null;
            listBox.DataSource = points;
        }
    }
}