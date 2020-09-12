using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_form
{
    public partial class Form1 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listpanel[--index].BringToFront();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
                listpanel[++index].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel[index].BringToFront();
        }
    }
}
