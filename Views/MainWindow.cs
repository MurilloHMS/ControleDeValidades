using ControleDeValidades.Models;
using ControleDeValidades.Views;
using ControleDeValidades.Views.UC;

namespace ControleDeValidades
{
    public partial class MainWindow : Form
    {
        private int IdUsuario;
        public MainWindow()
        {
            InitializeComponent();
        }



        public bool CharToBool(char valor)
        {
            return valor == 'T';
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
                    IdUsuario = validacao.IdUsuario;
                    alteraOpcoes();
                    MessageBox.Show($"{validacao.mensagem}", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LabelMenu.Text += usuario;
                }
                else
                {
                    MessageBox.Show($"{validacao.mensagem}", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void alteraOpcoes()
        {
            MenuAcessos acessos = new MenuAcessos();
            IEnumerable<MenuAcessos> menu = acessos.RetornaAcessosPorUsuario(IdUsuario);
            IEnumerable<char> valores = menu.Select(x => x.Liberado);

            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>
            {
                loginSistemaToolStripMenuItem,
                desconectarToolStripMenuItem,
                produtoToolStripMenuItem1,
                importarXMLToolStripMenuItem1,
                usuáriosToolStripMenuItem,
                filtroProdutosToolStripMenuItem
            };

            int count = Math.Min(menuItems.Count, valores.Count());

            for (int index = 0; index < count; index++)
            {
                char valor = valores.ElementAt(index); // Pegar o valor correspondente
                bool isEnabled = CharToBool(valor); // Converter char para bool
                menuItems[index].Enabled = isEnabled;


            }

            loginSistemaToolStripMenuItem.Enabled = false;
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

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
