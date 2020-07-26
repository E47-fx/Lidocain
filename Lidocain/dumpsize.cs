using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lidocain
{
    public partial class dumpsize : Form
    {
        public dumpsize()
        {
            InitializeComponent();
        }

        private void dumpsizeval_Scroll(object sender, EventArgs e)
        {
            if (dumpsizeval.Value == 1)
                label2.Text = dumpsizeval.Value + " Megabyte";
            else label2.Text = dumpsizeval.Value + " Megabytes";
        }

        private void dmpbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
