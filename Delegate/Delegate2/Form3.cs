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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public delegate void MesajGonder(object sender);

        public MesajGonder gidenMesaj;



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gidenMesaj != null)
            {
                if(textBox1.Text != "")
                {
                    gidenMesaj(textBox1.Text);
                }
            }
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
