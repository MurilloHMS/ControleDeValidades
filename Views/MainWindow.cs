using ControleDeValidades.Models;
using ControleDeValidades.Views;
using ControleDeValidades.Views.UC;

namespace ControleDeValidades
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            alteraOpcoes(false);

        }

        private void alteraOpcoes(bool valor)
        {
            produtoToolStripMenuItem1.Enabled = valor;
            importarXMLToolStripMenuItem1.Enabled = valor;
            filtroProdutosToolStripMenuItem.Enabled = valor;
            desconectarToolStripMenuItem.Enabled = valor;
            usuáriosToolStripMenuItem.Enabled = valor;

            switch (valor)
            {
                case true:
                    loginSistemaToolStripMenuItem.Enabled = false;
                    break;
                case false:
                    loginSistemaToolStripMenuItem.Enabled = true;
                    break;
            }

        }

        public void ConectarNoSistema()
        {

            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            var validacao = new Validacao();

            if (frm_Login.DialogResult == DialogResult.OK)
            {
                string senha = frm_Login.senha;
                string usuario = frm_Login.login;
                

                if (validacao.ValidaSenhaLogin(usuario, senha))
                {
                    alteraOpcoes(true);
                    MessageBox.Show($"{validacao.mensagem}", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LabelMenu.Text += usuario;
                }
                else
                {
                    MessageBox.Show($"{validacao.mensagem}", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ChamarFormulario(UserControl userControl, string nome, string texto)
        {
            Frm_DefaultWindows frm = new Frm_DefaultWindows(userControl, nome, texto);
            frm.MdiParent = this;
            frm.Show();
        }
        private void importarXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChamarFormulario(new Frm_ImportarXml_UC(), "ImportarXML", "Importação XML");
        }

        private void filtroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarFormulario(new Frm_FiltroProdutos_UC(), "FiltroProdutos", "Filtro de Produtos");
        }

        private void loginSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConectarNoSistema();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroUsuarios cadastroUsuarios = new Frm_CadastroUsuarios();
            cadastroUsuarios.ShowDialog();
            
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChamarFormulario(new Frm_CadastroDeProduto_UC(), "CadastroProdutos", "Cadastro de Produtos");
        }

    }
}
