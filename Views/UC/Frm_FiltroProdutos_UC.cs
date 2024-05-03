using ControleDeValidades.Databases;
using ControleDeValidades.Models;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_FiltroProdutos_UC : UserControl
    {
        private BindingSource bindingSource = new BindingSource();
        private List<Produto> produtos = new List<Produto>();

        public Frm_FiltroProdutos_UC()
        {
            InitializeComponent();

            Txb_Descricao.TextChanged += Txb_Descricao_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txb_Descricao.Text) && string.IsNullOrEmpty(Cb_Fornecedor.Text) && string.IsNullOrEmpty(Cb_Vencimentos.Text))
            {

            }
            else if (Cb_Vencimentos.SelectedItem == "Todos")
            {
                DAL<Produto> dal = new DAL<Produto>();
                var resultado = dal.ObterRegistros();
                PreencherInformações(resultado.ToList());
            }
        }

        private void PreencherInformações(List<Produto> resultado)
        {
            DateTime hoje = DateTime.Today;
            foreach (var produto in resultado)
            {
                TimeSpan time = produto.PRODDATVAL - hoje;
                if (time.TotalDays > 1)
                {
                    produto.PROCSTAT = $"Falta {time.TotalDays} Dias Para Vencer";
                }
                if (time.TotalDays < 0)
                {
                    produto.PROCSTAT = $"Está {Math.Abs(time.TotalDays)} Dias Vencido";
                }
                if (time.TotalDays == 1)
                {
                    produto.PROCSTAT = $"Falta {time.TotalDays} dia para vencer";
                }
                if (time.TotalDays == 0)
                {
                    produto.PROCSTAT = "Vence Hoje";
                }

            }

            produtos = resultado;
            bindingSource.DataSource = resultado;
            Dgv_FiltroProdutos.DataSource = bindingSource;


            Dgv_FiltroProdutos.DataSource = resultado;
            Dgv_FiltroProdutos.Columns[0].Visible = false;
            Dgv_FiltroProdutos.Columns[1].HeaderText = "Data Lançamento";
            Dgv_FiltroProdutos.Columns[2].HeaderText = "Código Interno";
            Dgv_FiltroProdutos.Columns[3].HeaderText = "Descrição";
            Dgv_FiltroProdutos.Columns[4].Visible = false;
            Dgv_FiltroProdutos.Columns[5].HeaderText = "Fornecedor";
            Dgv_FiltroProdutos.Columns[6].HeaderText = "Quantidade";
            Dgv_FiltroProdutos.Columns[7].HeaderText = "Data De Validade";
            Dgv_FiltroProdutos.Columns[8].HeaderText = "Status";
            Dgv_FiltroProdutos.Columns[9].HeaderText = "NFe";
            Dgv_FiltroProdutos.Columns[10].Visible = false;
            Dgv_FiltroProdutos.Columns[11].Visible = false;
            Dgv_FiltroProdutos.Columns[12].Visible = false;

            Dgv_FiltroProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Dgv_FiltroProdutos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Txb_QuantTot.Text = resultado.Count().ToString();
            int quantidadeProduto = 0;
            int vencimento30 = 0;
            int vencimento20 = 0;
            int vencimento15 = 0;
            int vencimento10 = 0;
            int vencimento3 = 0;
            int vencidos = 0;
            foreach (Produto produto in resultado)
            {
                quantidadeProduto += produto.PRONQUANT;
                TimeSpan diferenca = produto.PRODDATVAL - hoje;
                if (diferenca.TotalDays < 30 && diferenca.TotalDays > 0)
                {
                    vencimento30 += 1;

                }

                if (diferenca.TotalDays < 20 && diferenca.TotalDays > 0)
                {
                    vencimento20 += 1;
                }

                if (diferenca.TotalDays < 15 && diferenca.TotalDays > 0)
                {
                    vencimento15 += 1;
                }

                if (diferenca.TotalDays < 10 && diferenca.TotalDays > 0)
                {
                    vencimento10 += 1;
                }

                if (diferenca.TotalDays < 3 && diferenca.TotalDays > 0)
                {
                    vencimento3 += 1;
                }

                if (diferenca.TotalDays < 0 || diferenca.TotalDays == 0)
                {
                    vencidos += 1;
                }


            }

            Txb_QuantTotProd.Text = quantidadeProduto.ToString();
            Txb_Vencimento30Dias.Text = vencimento30.ToString();
            Txb_Vencimento20Dias.Text = vencimento20.ToString();
            Txb_Vencimento15Dias.Text = vencimento15.ToString();
            Txb_Vencimento10Dias.Text = vencimento10.ToString();
            Txb_Vencimento3Dias.Text = vencimento3.ToString();
            Txb_Vencidos.Text = vencidos.ToString();

            List<string> fornecedores = RecuperaFornecedores(resultado);
            foreach (var item in fornecedores)
            {
                Cb_Fornecedor.Items.Add(item);
            }

        }

        public List<string> RecuperaFornecedores(IEnumerable<Produto> resultado)
        {
            List<string> lista = new List<string>();
            foreach (Produto produto in resultado)
            {
                lista.Add(produto.PROCFOR);
            }
            return lista.Distinct().ToList();
        }

        private void Txb_Descricao_TextChanged(object sender, EventArgs e)
        {
            string filtro = Txb_Descricao.Text.ToLower();
            bindingSource.DataSource = produtos.Where(produto => produto.PROCDESCR.ToLower().Contains(filtro)).ToList();
            Dgv_FiltroProdutos.DataSource = bindingSource.DataSource;
        }
    }
}
