using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string nome;
        string endereco;
        public Form2()
        {
            InitializeComponent();
        }

        public void SetDados(string v1, string v2)
        {
            lbNome.Text = v1;
            lbEndereco.Text = v2;
        }
    }
}
