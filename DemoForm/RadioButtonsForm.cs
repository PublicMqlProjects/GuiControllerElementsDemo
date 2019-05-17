using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class RadioButtonsForm : Form
    {
        public RadioButtonsForm()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += RadioButtons_Load;
        }

        private void RadioButtons_Load(object sender, EventArgs e)
        {
            int k = 0;
        }
    }
}
