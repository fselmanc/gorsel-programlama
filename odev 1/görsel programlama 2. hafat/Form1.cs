using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel_programlama_2.hafat
{
    public partial class Form1 : Form          
    {                                          
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ortalama, vize, final;
                vize = Convert.ToDouble(numericUpDown1.Text);
                final = Convert.ToDouble(numericUpDown2.Text);
                ortalama = vize * 0.4 + final * 0.6;
                label3.Text = ortalama.ToString();
                if(ortalama>=50 && final>=50)
                {
                    label4.Text = "Tebrikler geçtiniz";
                }
                else
                {
                    label4.Text = "Maalesef geçemediniz";
                }
            }
            catch (Exception ex)  
            {

            }
        }
    }
}
