using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            double topla, çıkar, çarp, böl;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                topla = sayı1 + sayı2;
                label4.Text = topla.ToString();

            }
            if(radioButton2.Checked==true)
            {
                çıkar = sayı1 - sayı2;
                label4.Text = çıkar.ToString();
            }
            if(radioButton3.Checked==true)
            {
                çarp = sayı1 * sayı2;
                label4.Text = çarp.ToString();
            }
            if(radioButton4.Checked==true)
            {
                böl = sayı1 / sayı2;
                label4.Text = böl.ToString();
            }
            


        }
    }
}
