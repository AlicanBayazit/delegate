using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void Form2dekiLabelaDataGonder(string metin);
        public Form2dekiLabelaDataGonder form2DekiLabelaDataGonder;
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            // datayı burdan gönderdiğimiz için ve burdan başladığımız için form2DekiLabelaDataGonder kısmı this ile sol tarafta olmaı
            this.form2DekiLabelaDataGonder += new Form2dekiLabelaDataGonder(frm2.Form2_Form1denDatamGelmis);
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //// datayı burdan gönderdiğimiz için ve burdan başladığımız için form2DekiLabelaDataGonder kısmı this ile sol tarafta olmaı
            //this.form2DekiLabelaDataGonder += new Form2dekiLabelaDataGonder(frm2.Form2_Form1denDatamGelmis);
            //form2DekiLabelaDataGonder(textBox1.Text);
            //frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // butona yazılmış şekildeyken burdan çağırınca çalışmıyor, en az bir kere çalışmış olması gerektiği için form load da çalıştırıp
            // burda veri eklemeyi yapabildik
            form2DekiLabelaDataGonder(textBox1.Text);
        }
    }
}
