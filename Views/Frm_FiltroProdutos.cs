using ControleDeValidades.Views.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_DefaultWindows : Form
    {
        private readonly UserControl _UserControl;
        private readonly string _TabName;
        private readonly string _TabTexto;

        public Frm_DefaultWindows(UserControl userControl, string nomeTabPage, string textoTabPage )
        {
            InitializeComponent();
            _UserControl = userControl;
            _TabName = nomeTabPage;
            _TabTexto = textoTabPage;
            CriarJanela();
        }

        private void Frm_FiltroProdutos_Load(object sender, EventArgs e)
        {
            
        }

        private void CriarJanela()
        {            
            _UserControl.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            tp.Name = _TabName;
            tp.Text = _TabTexto;
            tp.Controls.Add(_UserControl);
            Tb_MainWindow.Controls.Add(tp);
            this.Text = _TabTexto;
        }
    }
}
