using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_Login : Form
    {

        public string senha;
        public string login;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            senha = Txt_Senha.Text;
            login = Txt_Usuario.Text;
        }
    }
}
