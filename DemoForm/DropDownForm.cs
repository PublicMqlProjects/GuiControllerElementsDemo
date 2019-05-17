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
    public partial class DropDownForm : Form
    {
        public DropDownForm()
        {
            InitializeComponent();
            string text = comboBox1.Text;
            comboBox1.SelectedIndexChanged += DropDownForm_Load;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DropDownForm_Load(object sender, EventArgs e)
        {
            int k = 9;
        }
    }
}
