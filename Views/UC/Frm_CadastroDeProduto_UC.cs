using ControleDeValidades.Databases;
using ControleDeValidades.Models;
using System.ComponentModel.DataAnnotations;

using System.Data.SqlClient;


namespace ControleDeValidades.Views.UC
{
    public partial class Frm_CadastroDeProduto_UC : UserControl
    {

        private List<Produto> listaProdutos = new List<Produto>();
        public Frm_CadastroDeProduto_UC()
        {
            InitializeComponent();
            Txt_Descricao.CharacterCasing = CharacterCasing.Upper;
            Txt_Fornecedor.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteFornecedor();
        }

        private void Btn_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto = LeituraFormulario();
                produto.ValidaClasse();
                listaProdutos.Add(produto);
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
            P.PROCCODINT = string.IsNullOrWhiteSpace(Txt_CodInterno.Text) ? " " : Txt_CodInterno.Text;
            P.PROCDESCR = Txt_Descricao.Text;
            P.PROCREF = string.IsNullOrWhiteSpace(Txt_Referencia.Text) ? " " : Txt_Referencia.Text;
            P.PROCFOR = Txt_Fornecedor.Text;
            if (!string.IsNullOrEmpty(Txt_Quantidade.Text))
            {
                P.PRONQUANT = int.Parse(Txt_Quantidade.Text);
            }
            else
            {
                throw new Exception("Quantidade é Obrigatória");
            }
            P.PRODDATVAL = Dtp_DataValidade.Value;
            P.PROCNNUMNF = string.IsNullOrWhiteSpace(Txt_NumNFe.Text) ? " " : Txt_NumNFe.Text;
            return P;
        }
        private void AtualizarDataGrideView()
        {
            Dgv_Produtos.DataSource = null;
            Dgv_Produtos.DataSource = listaProdutos;
            Dgv_Produtos.Columns[0].Visible = false;
            Dgv_Produtos.Columns[1].HeaderText = "Data Lançamento";
            Dgv_Produtos.Columns[2].HeaderText = "Código Interno";
            Dgv_Produtos.Columns[3].HeaderText = "Descrição";
            Dgv_Produtos.Columns[4].HeaderText = "Referência";
            Dgv_Produtos.Columns[5].HeaderText = "Fornecedor";
            Dgv_Produtos.Columns[6].HeaderText = "Quantidade";
            Dgv_Produtos.Columns[7].HeaderText = "Data De Validade";
            Dgv_Produtos.Columns[8].Visible = false;
            Dgv_Produtos.Columns[9].HeaderText = "NFe";
            Dgv_Produtos.Columns[10].Visible = false;
            Dgv_Produtos.Columns[11].Visible = false;
            Dgv_Produtos.Columns[12].Visible = false;

            Dgv_Produtos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_Produtos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_Produtos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_Produtos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_Produtos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_Produtos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_Produtos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_Produtos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja Apagar Todos os dados preenchidos na tabela?\n\nAtenção Essa Ação NÃO é reversivel!", "Exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                LimparDados();
            }
        }

        private void LimparDados()
        {
            Dgv_Produtos.DataSource = null;
            Dgv_Produtos.Rows.Clear();
            listaProdutos.Clear();
        }

        private void AutoCompleteFornecedor()
        {
            var colecaoAutoCompletar = new AutoCompleteStringCollection();
            try
            {
                DAL<Produto> dal = new DAL<Produto>();
                var resultado = dal.ObterRegistros();
                if (resultado is not null)
                {
                    foreach (var i in resultado)
                    {
                        colecaoAutoCompletar.Add(i.PROCFOR.Trim());
                    }
                    Txt_Fornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    Txt_Fornecedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    Txt_Fornecedor.AutoCompleteCustomSource = colecaoAutoCompletar;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ocorreu um erro ao coletar os dados no banco! \nErro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao coletar os dados! \nErro: {ex.Message}");
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarProdutos();
        }

        public void SalvarProdutos()
        {
            DialogResult msg = MessageBox.Show("Deseja incluir os produtos?", "Inclusão de cadastros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in Dgv_Produtos.Rows)
                {
                    if (row.Cells[7].Value == null || string.IsNullOrWhiteSpace(row.Cells[7].Value.ToString()))
                    {
                        MessageBox.Show("A coluna 'Validades' deve estar preenchida para todos os produtos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            foreach (DataGridViewRow row in Dgv_Produtos.Rows)
            {
                Produto produto = new Produto();
                produto.PRODDATCAD = Convert.ToDateTime(row.Cells["PRODDATCAD"].Value.ToString());
                if (!string.IsNullOrWhiteSpace(row.Cells["PROCCODINT"].Value.ToString()))
                {
                    produto.PROCCODINT = row.Cells["PROCCODINT"].Value.ToString();
                }
                produto.PROCDESCR = row.Cells["PROCDESCR"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(row.Cells["PROCREF"].Value.ToString()))
                {
                    produto.PROCREF = row.Cells["PROCREF"].Value.ToString();
                }
                produto.PROCFOR = row.Cells["PROCFOR"].Value.ToString();
                produto.PRONQUANT = int.Parse(row.Cells["PRONQUANT"].Value.ToString());
                produto.PRODDATVAL = Convert.ToDateTime(row.Cells["PRODDATVAL"].Value.ToString());
                
                if (!string.IsNullOrWhiteSpace(row.Cells["PROCNNUMNF"].Value.ToString()))
                {
                    produto.PROCNNUMNF = row.Cells["PROCNNUMNF"].Value.ToString();
                }
                

                produto.Incluir();
            }

            MessageBox.Show("Dados Incluídos com sucesso!", "Inclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AutoCompleteFornecedor();
            LimparDados();
        }
    }
}
