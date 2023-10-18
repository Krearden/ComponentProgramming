using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControlNew
{
    public partial class NumBox : TextBox
    {
        public NumBox()
        {
            InitializeComponent();
        }

        public NumBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            double x;
            if (!double.TryParse(Text, out x))
                ForeColor = Color.Red;
            else
                ForeColor = Color.Black;
            base.OnTextChanged(e);
        }

    }
}
