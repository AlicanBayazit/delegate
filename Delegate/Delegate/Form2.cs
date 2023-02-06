using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Veriyi nerden göndereceğimizi düşünüp ona göre orda delegate tanımlıyoruz
        // göndericeğim,z mesajı içeren textbox form2de olduğu ve
        //  bu bilgiyi form2den form1e ileticeğimiz için form2 içinde delegate tanımladık
        // içine object sender yazarak bir şey göndericeğimi berirtiyorum
        public delegate void MesajGonder(object sender); // declare delegate 
        // sql deki declare kısmıi tanımladığımız yer burası

        // değişken kısmı da burası
        public MesajGonder mesajGonder;  // delegate variable
        // delegate'i bir değişkende tanımladık

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delegate aslında içinde method taşıyor, bu yüzden null kontrolü yazıyoruz
            if (mesajGonder != null)
            {
                mesajGonder(textBox1.Text);
            }
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
