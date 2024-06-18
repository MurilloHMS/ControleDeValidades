using System.ComponentModel.DataAnnotations;
using ControleDeValidades.Models;

namespace ControleDeValidades.Views
{
    public partial class Frm_CadastroUsuarios : Form
    {
        public Frm_CadastroUsuarios()
        {
            InitializeComponent();
            SetupCharacterCasing();
        }

        private void SetupCharacterCasing()
        {
            Txb_Email.CharacterCasing = CharacterCasing.Upper;
            Txb_Nome.CharacterCasing = CharacterCasing.Upper;
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            if (Btn_Register.Text == "Cadastrar")
            {
                RegisterUser();
            }
            else
            {
                UpdateUser();
            }
        }
        private void UpdateUser()
        {
            try
            {
                var users = CollectData(true);
                users.ValidaClasse();
                users.Atualizar();
                MessageBox.Show("Usuário atualizado com Sucesso");
                ResetForm();
                SetFormMode(true);

            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"{ex.Message}", "Validação atualizaçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RegisterUser()
        {
            try
            {
                
                var users = CollectData(false);
                users.ValidaClasse();
                users.Incluir();
                MessageBox.Show("Usuário Incluido com Sucesso");
                ResetForm();
                SetFormMode(false);

            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"{ex.Message}", "Validação cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Usuarios CollectData(bool isUpdate)
        {
            return new Usuarios
            {
                ID = isUpdate && int.TryParse(Txt_ID.Text, out int id) ? id : 0,
                Nome = Txb_Nome.Text,
                Senha = Txb_Senha.Text,
                Email = Txb_Email.Text,
                Ativo = Cb_Ativo.SelectedIndex == 0 ? 'T' : 'F'
            };
        }

        private void FillUser(int id, string nome, string email, string senha, char ativo)
        {
            Txt_ID.Text = id.ToString();
            Txb_Nome.Text = nome;
            Txb_Senha.Text = senha;
            Txb_Email.Text = email;
            Cb_Ativo.SelectedIndex = ativo == 'T' ? 0 : 1;
        }

        private void ResetForm()
        {
            Txt_ID.Text = string.Empty;
            Txb_Nome.Text = string.Empty;
            Txb_Senha.Text = string.Empty;
            Txb_Email.Text = string.Empty;
        }

        private void SearchUser()
        {
            Frm_Busca finder = new Frm_Busca();
            finder.ShowDialog();

            int id = finder.idSelect;
            string nome = finder.NomeSelect;
            string email = finder.EmailSelect;
            string senha = finder.SenhaSelect;
            char ativo = finder.AtivoSelect;

            if (finder.DialogResult == DialogResult.OK)
            {
                FillUser(id, nome, email, senha, ativo);
                SetFormMode(true);
            }
        }

        private void Cbx_VisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Txb_Senha.UseSystemPasswordChar = Cbx_VisualizarSenha.Checked ? false : true;
        }

        private void Btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_ID.Text))
            {
                DialogResult msg = MessageBox.Show($"Atenção, Essa Opção excluirá o usuário {Txb_Nome.Text}.\n Tem certeza que deseja excluir? \n Essa operação é irreversivel", "Exclusão de usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg is DialogResult.Yes) 
                {
                    
                    var resultado = CollectData(true);
                    resultado.Deletar();
                    ResetForm();

                }
            }
        }

        private void Btn_Acessos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_ID.Text) && !string.IsNullOrWhiteSpace(Txb_Nome.Text))
            {
                Frm_AcessosUsuarios frm = new Frm_AcessosUsuarios();
                frm.IdUsuario = Txt_ID.Text;
                frm.NomeUsuario = Txb_Nome.Text;
                frm.ShowDialog();
            }

        }

        private void SetFormMode(bool valor)
        {
            Btn_Register.Text = valor == true ? "Atualizar" : "Cadastrar";
        }

        
    }
}
