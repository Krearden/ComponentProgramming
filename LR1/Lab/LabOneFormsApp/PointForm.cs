using Point = PointLib.Point;

namespace LabOneFormsApp
{
    public partial class Form1 : Form
    {
        private Point[] points = null;
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
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();

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
    }
}