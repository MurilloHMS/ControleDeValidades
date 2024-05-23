using ControleDeValidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_CadastroDeProduto_UC : UserControl
    {
        private List<Produto> produtos = new List<Produto>();
        public Frm_CadastroDeProduto_UC()
        {
            InitializeComponent();
        }

        private void Btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto = LeituraFormulario();
                produto.ValidaClasse();              
                produtos.Add(produto);
                AtualizarDataGrideView();
                LimparCampos();
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Validador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Produto LeituraFormulario()
        {
            Produto P = new Produto();
            P.PRODDATCAD = DateTime.Now;
            P.PROCCODINT = string.IsNullOrWhiteSpace(Txt_CodInterno.Text) ? null : Txt_CodInterno.Text;
            P.PROCDESCR = Txt_Descricao.Text;
            P.PROCREF = string.IsNullOrWhiteSpace(Txt_Referencia.Text) ? null : Txt_Referencia.Text;
            P.PROCFOR = string.IsNullOrWhiteSpace(Txt_Fornecedor.Text) ? null : Txt_Fornecedor.Text;
            if (!string.IsNullOrEmpty(Txt_Quantidade.Text))
            {
                P.PRONQUANT = int.Parse(Txt_Quantidade.Text);
            }
            else
            {
                throw new Exception("Quantidade é Obrigatória");
            }
            P.PRODDATVAL = Dtp_DataValidade.Value;
            P.PROCNNUMNF = string.IsNullOrWhiteSpace(Txt_NumNFe.Text) ? null : Txt_NumNFe.Text;
            return P;
        }
        private void AtualizarDataGrideView()
        {
            Dgv_Produtos.DataSource = null;
            Dgv_Produtos.DataSource = produtos;
        }
        
        private void LimparCampos()
        {
            Txt_CodInterno.Clear();
            Txt_Descricao.Clear();
            Txt_Fornecedor.Clear();
            Txt_NumNFe.Clear();
            Txt_Referencia.Clear();
            Txt_Quantidade.Clear();
            Dtp_DataValidade.Value = DateTime.Today;
        }
    }
}
