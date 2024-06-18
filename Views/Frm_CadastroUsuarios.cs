using System.ComponentModel.DataAnnotations;
using ControleDeValidades.Models;

namespace ControleDeValidades.Views
{
    public partial class Frm_CadastroUsuarios : Form
    {
        public Frm_CadastroUsuarios()
        {
            InitializeComponent();
            Txb_Email.CharacterCasing = CharacterCasing.Upper;
            Txb_Nome.CharacterCasing = CharacterCasing.Upper;
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Enabled == false && Btn_Cadastro.Text == "Cadastrar")
            {
                CadastrarUsuario();
            }
            else
            {
                AtualizarCadastro();
            }
        }
        private void AtualizarCadastro()
        {
            try
            {
                Usuarios users = new Usuarios();
                users = ColetaDados(true);
                users.ValidaClasse();
                users.Atualizar();
                MessageBox.Show("Usuário atualizado com Sucesso");
                LimparDados();
                AtualizarElementos(true);

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
        private void CadastrarUsuario()
        {
            try
            {
                Usuarios users = new Usuarios();
                users = ColetaDados(false);
                users.ValidaClasse();
                users.Incluir();
                MessageBox.Show("Usuário Incluido com Sucesso");
                LimparDados();
                AtualizarElementos(false);

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

        private Usuarios ColetaDados(bool i)
        {
            Usuarios users = new Usuarios();
            if (i)
            {
                users.ID = int.Parse(Txt_ID.Text);
            }
            users.Nome = Txb_Nome.Text;
            users.Senha = Txb_Senha.Text;
            users.Email = Txb_Email.Text;
            users.Ativo = Cb_Ativo.SelectedIndex == 0 ? 'T' : 'F';
            return users;
        }

        private void PreencherUsuario(int id, string nome, string email, string senha, char ativo)
        {
            Txt_ID.Text = Convert.ToString(id);
            Txb_Nome.Text = nome;
            Txb_Senha.Text = senha;
            Txb_Email.Text = email;

            Cb_Ativo.SelectedIndex = ativo == 'T' ? 0 : 1;
        }

        private void LimparDados()
        {
            Txt_ID.Text = string.Empty;
            Txb_Nome.Text = string.Empty;
            Txb_Senha.Text = string.Empty;
            Txb_Email.Text = string.Empty;
        }

        private void BuscarUsuario()
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
                PreencherUsuario(id, nome, email, senha, ativo);
                AtualizarElementos(true);
            }
        }

        private void Cbx_VisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Txb_Senha.UseSystemPasswordChar = Cbx_VisualizarSenha.Checked ? false : true;
        }

        private void Btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_ID.Text))
            {
                DialogResult msg = MessageBox.Show($"Atenção, Essa Opção excluirá o usuário {Txb_Nome.Text}.\n Tem certeza que deseja excluir? \n Essa operação é irreversivel", "Exclusão de usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg is DialogResult.Yes) 
                {
                    int id = int.Parse(Txt_ID.Text);
                    Usuarios resultado = new Usuarios();
                    resultado = ColetaDados(true);
                    resultado.Deletar();
                    LimparDados();

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

        private void AtualizarElementos(bool valor)
        {
            Btn_Cadastro.Text = valor == true ? "Atualizar" : "Cadastrar";
        }

        
    }
}
