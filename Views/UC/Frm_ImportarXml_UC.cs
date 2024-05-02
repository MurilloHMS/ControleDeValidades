using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeValidades.Models;

namespace ControleDeValidades.Views.UC
{
    public partial class Frm_ImportarXml_UC : UserControl
    {
        public Frm_ImportarXml_UC()
        {
            InitializeComponent();
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
                        Dgv_DadosXML.DataSource = dados;
                        Dgv_DadosXML.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Dgv_DadosXML.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        Dgv_DadosXML.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   

                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
