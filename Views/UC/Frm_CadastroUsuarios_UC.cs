using ControleDeValidades.Models;
using System.ComponentModel.DataAnnotations;


namespace ControleDeValidades.Views.UC
{
    public partial class Frm_CadastroUsuarios_UC : UserControl
    {
        public MenuStrip _menuStrip;
        public Frm_CadastroUsuarios_UC()
        {
            InitializeComponent();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios users = new Usuarios();
                users.Nome = Txb_Nome.Text;
                users.Senha = Txb_Senha.Text;
                users.Email = Txb_Email.Text;
                users.ValidaClasse();
                users.Incluir();
                MessageBox.Show("Usuário Incluido com Sucesso");

            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"{ex.Message}", "Validação cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Frm_CadastroUsuarios_UC_Load(object sender, EventArgs e)
        {
            var opcoes = Opcoes.Criar(_menuStrip);
            dataGridView1.DataSource = opcoes.ToList();            
            ConfigurarGrade();
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

            var acesso = new DataGridViewCheckBoxColumn();
            acesso.HeaderText = "Liberado";
            acesso.Width = 60;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(acesso);
        }
    }
}
