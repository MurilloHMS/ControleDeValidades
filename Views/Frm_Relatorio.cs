using ControleDeValidades.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_Relatorio : Form
    {
        private List<Produto> listaProdutos;

        public Frm_Relatorio(List<Produto> produtos)
        {
            InitializeComponent();

            
            listaProdutos = produtos;

            
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            
            var rds = new ReportDataSource("Produto", listaProdutos);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);

            reportViewer2.LocalReport.ReportEmbeddedResource = "ControleDeValidades.Relatorios.RelatorioProdutos.rdlc";
            
            reportViewer2.RefreshReport();
        }
    }
}
