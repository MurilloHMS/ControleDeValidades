using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_FiltroProdutos_UC : UserControl
    {
        public Frm_FiltroProdutos_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção, não é possivel copiar a jemile julia\n\n Deseja tentar novamente sendo você mesma?", "Pirataria é Crime. Seja Original!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
    }
}
