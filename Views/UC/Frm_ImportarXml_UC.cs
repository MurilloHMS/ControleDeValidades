using ControleDeValidades.Models;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_ImportarXml_UC : UserControl
    {
        public Frm_ImportarXml_UC()
        {
            InitializeComponent();

            AdicionarColunaDateTimePicker();
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
                        produto.PROCCODINT = row.Cells["CODINT"].Value.ToString();
                        produto.PROCNNUMNF = Txb_NumNfe.Text;

                        produto.Incluir();
                    }
                }

                MessageBox.Show("Dados Incluídos com sucesso!", "Inclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdicionarColunaDateTimePicker()
        {
            var datePickerColumn = new DataGridViewColumn(new DataGridViewDateTimePickerCell());
            datePickerColumn.HeaderText = "Validades";
            datePickerColumn.Name = "Validades";
            Dgv_DadosXML.Columns.Add(datePickerColumn);
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
    }

    public class DataGridViewDateTimePickerCell : DataGridViewTextBoxCell
    {
        public DataGridViewDateTimePickerCell()
        {
            this.Style.Format = "dd/MM/yyyy";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var picker = DataGridView.EditingControl as DateTimePicker;

            if (picker != null)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "dd/MM/yyyy";
            }
        }

        public override Type EditType => typeof(DataGridViewDateTimePickerEditingControl);

        public override object DefaultNewRowValue => DateTime.Now.Date;

        public override object Clone()
        {
            var cell = base.Clone() as DataGridViewDateTimePickerCell;
            return cell;
        }
    }

    public class DataGridViewDateTimePickerEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        public DataGridViewDateTimePickerEditingControl()
        {
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyyy";
        }

        private DataGridView dataGridView;
        private bool valueChanged = false;
        private int rowIndex;
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridView; }
            set { dataGridView = value; }
        }

        public object EditingControlFormattedValue
        {
            get { return this.Value.ToShortDateString(); }
            set
            {
                if (value is string)
                {
                    this.Value = DateTime.Parse((string)value);
                }
            }
        }

        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public Cursor EditingPanelCursor
        {
            get { return base.Cursor; }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
