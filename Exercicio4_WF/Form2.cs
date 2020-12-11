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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = Form1.SetValueForText1;
            lbl_idade.Text = Form1.SetValueForText2;
            lbl_curso.Text = Form1.SetValueForText3;
        }
    }
}
