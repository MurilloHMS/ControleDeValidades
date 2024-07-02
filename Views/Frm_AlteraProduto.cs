using ControleDeValidades.DataSets;
using ControleDeValidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_AlteraProduto : Form
    {

        public int IdProduto { get; set; }
        public Frm_AlteraProduto()
        {
            InitializeComponent();
        }

        private Produto ColetarDados()
        {

            Produto retorno = new Produto();
            retorno.PRONID_PRO = int.Parse(Txb_ID.Text);
            retorno.PROCDESCR = Txt_Descricao.Text;
            retorno.PROCCODINT = Txt_CodInterno.Text;
            retorno.PROCFOR = Txt_Fornecedor.Text;
            retorno.PROCNNUMNF = Txt_NumNFe.Text;
            retorno.PRONQUANT = int.Parse(Txt_Quantidade.Text);
            retorno.PROCREF = Txt_Referencia.Text;
            retorno.PRODDATVAL = Dtp_DataValidade.Value;
            retorno.PRODDATCAD = Dtp_DataCadastro.Value;
            return retorno;
        }

        private void AtualizarProdutos()
        {
            Produto produto = new Produto();
            produto = ColetarDados();
            produto.Alterar();
        }

        private void Frm_AlteraProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            var retorno = produto.BuscarPorID(IdProduto);

            Txb_ID.Text = retorno.PRONID_PRO.ToString();
            Txt_Descricao.Text = retorno.PROCDESCR;
            Txt_CodInterno.Text = retorno.PROCCODINT;
            Txt_Fornecedor.Text = retorno.PROCFOR;
            Txt_NumNFe.Text = retorno.PROCNNUMNF;
            Txt_Quantidade.Text = retorno.PRONQUANT.ToString();
            Txt_Referencia.Text = retorno.PROCREF;
            Dtp_DataValidade.Text = retorno.PRODDATVAL.ToString();
            Dtp_DataCadastro.Text = retorno.PRODDATCAD.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarProdutos();
                MessageBox.Show("Cadastro Atualizado Com Sucesso!", "Alteração de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o produto: {ex.Message}", "Error Exeption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
