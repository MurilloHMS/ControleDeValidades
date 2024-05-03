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

            ConectarNoSistema();
        }

        private void alteraOpcoes(bool valor)
        {
            produtoToolStripMenuItem1.Enabled = valor;
            importarXMLToolStripMenuItem1.Enabled = valor;
            filtroProdutosToolStripMenuItem.Enabled = valor;

        }

        public void ConectarNoSistema()
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();

            if (frm_Login.DialogResult == DialogResult.OK)
            {
                string senha = frm_Login.senha;
                string usuario = frm_Login.login;

                if (Validacao.ValidaSenhaLogin(usuario, senha))
                {
                    alteraOpcoes(true);

                }
                else
                {
                    MessageBox.Show("Senha Inválida!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void importarXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ImportarXml_UC importarXml_UC = new Frm_ImportarXml_UC();
            Frm_DefaultWindows frm = new Frm_DefaultWindows(importarXml_UC, "ImportarXML", "Importação XML");
            frm.MdiParent = this;
            frm.Show();
        }

        private void filtroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FiltroProdutos_UC filtroProdutos_UC = new Frm_FiltroProdutos_UC();
            Frm_DefaultWindows frm = new Frm_DefaultWindows(filtroProdutos_UC, "FiltroProdutos", "Filtro de Produtos");
            frm.MdiParent = this;
            frm.Show();
        }

        private void loginSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConectarNoSistema();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroUsuarios_UC cadastroUsuarios_UC = new Frm_CadastroUsuarios_UC();
            Frm_DefaultWindows frm = new Frm_DefaultWindows(cadastroUsuarios_UC, "CadastroUsuarios", "Cadastro de Usuários");
            frm.MdiParent = this;
            frm.Show();
        }
    }


}
