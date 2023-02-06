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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void MesajGonder2(object sender);
        public MesajGonder2 ekliMesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.gidenMesaj += new Form3.MesajGonder(gelenVeri);
            frm3.Show();
            button1.Visible = false;
            button2.Visible = true;
            textBox1.ReadOnly = false;
        }

        private void gelenVeri(object sender)
        {
            textBox1.Text = sender.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekliMesaj != null)
            {
                ekliMesaj(textBox1.Text);
            }
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
