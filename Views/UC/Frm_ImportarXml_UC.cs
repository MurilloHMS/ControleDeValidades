using ControleDeValidades.Models;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_ImportarXml_UC : UserControl
    {
        public Frm_ImportarXml_UC()
        {
            InitializeComponent();
            Dgv_DadosXML.EditingControlShowing += Dgv_DadosXML_EditingControlShowing;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Arquivos XML (*.xml)|*.xml|Todos os Arquivos (*.*)|*.*";
                    ofd.Title = "Selecione um arquivo XML";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string pathXml = ofd.FileName;
                        Txb_ChaveNFe.Text = pathXml;
                        NFeData data = new NFeData();
                        var dados = data.ReturnDados(pathXml);

                        Txb_RzSocial.Text = data.Fornecedor;
                        TxB_Cnpj.Text = data.CNPJ;
                        Txb_ChaveNFe.Text = data.ChaveNFe;
                        Txb_NumNfe.Text = data.NumeroNFe;
                        Dtp_DataEmissao.Value = data.DataEmissao;

                        Dgv_DadosXML.DataSource = dados;

                        Dgv_DadosXML.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[3].Visible = false;
                        Dgv_DadosXML.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Dgv_DadosXML.Columns[8].Visible = false;
                        Dgv_DadosXML.Columns[9].Visible = false;
                        Dgv_DadosXML.Columns[10].Visible = false;
                        Dgv_DadosXML.Columns[11].Visible = false;
                        Dgv_DadosXML.Columns[12].Visible = false;



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdicionarDadosAoBanco();
        }

        private void AdicionarDadosAoBanco()
        {
            DialogResult msg = MessageBox.Show("Deseja incluir os produtos Selecionados?", "Inclusão de cadastros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in Dgv_DadosXML.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkBox.Value) == true)
                    {
                        if (row.Cells["Validades"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Validades"].Value.ToString()))
                        {
                            MessageBox.Show("A coluna 'Validades' deve estar preenchida para todos os produtos selecionados.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                foreach (DataGridViewRow row in Dgv_DadosXML.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(checkBox.Value) == true)
                    {
                        Produto produto = new Produto();
                        produto.PROCREF = row.Cells["Referência"].Value.ToString();
                        produto.PROCDESCR = row.Cells["Descrição"].Value.ToString();
                        produto.PRONQUANT = int.Parse(row.Cells["Quantidade"].Value.ToString());
                        produto.PROCFOR = row.Cells["Fornecedor"].Value.ToString();
                        produto.PRODDATVAL = Convert.ToDateTime(row.Cells["Validades"].Value.ToString());
                        produto.PRODDATCAD = Dtp_DataEntrada.Value;
                        produto.PROCCODINT = row.Cells["CODINT"].Value?.ToString() ?? string.Empty;
                        produto.PROCNNUMNF = Txb_NumNfe.Text;

                        produto.Incluir();
                    }
                }

                MessageBox.Show("Dados Incluídos com sucesso!", "Inclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in Dgv_DadosXML.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBox != null)
                {
                    checkBox.Value = true;
                }
            }
            AdicionarDadosAoBanco();

        }

        private void Dgv_DadosXML_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (Dgv_DadosXML.CurrentCell.ColumnIndex == Dgv_DadosXML.Columns["Validades"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= TextBox_KeyPress;
                    tb.KeyPress += TextBox_KeyPress;
                    tb.TextChanged -= TextBox_TextChanged;
                    tb.TextChanged += TextBox_TextChanged;
                    tb.Leave -= TextBox_Leave;
                    tb.Leave += TextBox_Leave;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas dígitos e caracteres de controle (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                string text = tb.Text.Replace("/", "");
                if (text.Length > 2) text = text.Insert(2, "/");
                if (text.Length > 5) text = text.Insert(5, "/");

                tb.TextChanged -= TextBox_TextChanged; // Evitar loop infinito
                tb.Text = text;
                tb.SelectionStart = tb.Text.Length; // Mover o cursor para o fim
                tb.TextChanged += TextBox_TextChanged;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(tb.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    tb.Text = parsedDate.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("Data inválida. Por favor, insira a data no formato dd/MM/yyyy.");
                    tb.Focus();
                }
            }
        }
    }
}
