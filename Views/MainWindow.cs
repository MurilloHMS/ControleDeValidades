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

                }
                else
                {
                    MessageBox.Show($"{validacao.mensagem}", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cadastroUsuarios_UC._menuStrip = menuStrip1;
            frm.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CadastroDeProduto_UC cadastroDeProduto_UC = new Frm_CadastroDeProduto_UC();
            Frm_DefaultWindows frm = new Frm_DefaultWindows(cadastroDeProduto_UC, "CadastroProdutos", "Cadastro de Produtos");
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }


}
