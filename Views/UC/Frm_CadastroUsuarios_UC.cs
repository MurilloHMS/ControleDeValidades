using ControleDeValidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_CadastroUsuarios_UC : UserControl
    {
        public Frm_CadastroUsuarios_UC()
        {
            InitializeComponent();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios users = new Usuarios();
                users.Nome = Txb_Nome.Text;
                users.Senha = Txb_Senha.Text;
                users.Email = Txb_Email.Text;
                users.ValidaClasse();
                users.Incluir();
                MessageBox.Show("Usuário Incluido com Sucesso");

            }catch(ValidationException ex)
            {
                MessageBox.Show($"{ex.Message}", "Validação cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
