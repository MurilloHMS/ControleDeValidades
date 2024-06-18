using ControleDeValidades.Models;
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
    public partial class Frm_AcessosUsuarios : Form
    {
        public MenuStrip _menuStrip;
        public string IdUsuario {get; set;}
        public string NomeUsuario {get; set;}
        public Frm_AcessosUsuarios()
        {
            InitializeComponent();
        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["Nome"].Width = 300;
            dataGridView1.Columns["Nome"].ReadOnly = true;

            dataGridView1.Columns["Descricao"].Width = 380;
            dataGridView1.Columns["Descricao"].ReadOnly = true;

            dataGridView1.Columns["Nivel"].Width = 60;
            dataGridView1.Columns["Nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nivel"].ReadOnly = true;

            DataGridViewCheckBoxColumn acesso = new DataGridViewCheckBoxColumn();
            acesso.HeaderText = "Liberado";
            acesso.Width = 60;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.ReadOnly = false;
            dataGridView1.Columns.Add(acesso);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AcessosUsuarios_Load(object sender, EventArgs e)
        {
            Opcoes opcoes = new Opcoes();
            dataGridView1.DataSource = opcoes.RetornaOpcoes();
            Txb_ID.Text = IdUsuario;
            Txb_Nome.Text = NomeUsuario;
            ConfigurarGrade();
        }
    }
}
