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
    }


}
