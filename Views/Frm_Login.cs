using ControleDeValidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_Login : Form
    {

        private readonly Usuarios _usuarios = new Usuarios();

        public string senha;
        public string login;
        public Frm_Login()
        {
            InitializeComponent();
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteNome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            senha = Txt_Senha.Text;
            login = Txt_Usuario.Text;
        }
        
        private void AutoCompleteNome()
        {
            var colecaoAutoCompletar = new AutoCompleteStringCollection();
            try
            {
                var usuarios = _usuarios.RetornaUsuarios();
                if (usuarios is not null)
                {
                    foreach(var item in usuarios)
                    {
                        colecaoAutoCompletar.Add(item.Nome.Trim());
                        colecaoAutoCompletar.Add(item.Email.Trim());
                    }

                    Txt_Usuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    Txt_Usuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    Txt_Usuario.AutoCompleteCustomSource = colecaoAutoCompletar;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ocorreu um erro ao coletar os dados no banco! \nErro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao coletar os dados! \nErro: {ex.Message}");
            }
        }
    }
}
