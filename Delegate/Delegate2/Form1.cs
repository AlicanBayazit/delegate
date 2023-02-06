using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ekliMesaj += new Form2.MesajGonder2(gelenMesaj);
            frm2.Show();
        }

        private void gelenMesaj(object sender)
        {
            textBox1.Text = sender.ToString();
        }
    }
}
