using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}



