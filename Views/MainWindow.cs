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
        }

        private void filtrosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem CriaItemMenu(String text, string nomeDoIcone)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            return vToolTip;

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Tb_MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void importarXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void filtroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FiltroProdutos_UC filtroProdutos_UC = new Frm_FiltroProdutos_UC();
            Frm_DefaultWindows frm = new Frm_DefaultWindows(filtroProdutos_UC, "FiltroProdutos", "Filtro de Produtos");
            frm.MdiParent = this;
            frm.Show();
        }
    }


}
