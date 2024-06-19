using ControleDeValidades.Models;

namespace ControleDeValidades.Views
{
    public partial class Frm_AcessosUsuarios : Form
    {
        public MenuStrip _menuStrip;
        public string IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
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
            dataGridView1.Columns["Nome"].Visible = false;

            dataGridView1.Columns["Descricao"].Width = 380;
            dataGridView1.Columns["Descricao"].ReadOnly = true;

            dataGridView1.Columns["Nivel"].Width = 60;
            dataGridView1.Columns["Nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nivel"].ReadOnly = true;

            // Adicionando a coluna de checkbox
            if (!dataGridView1.Columns.Contains("Liberado"))
            {
                DataGridViewCheckBoxColumn acesso = new DataGridViewCheckBoxColumn();
                acesso.HeaderText = "Liberado";
                acesso.Name = "Liberado";  // Nome da coluna para referência
                acesso.Width = 60;
                acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns.Add(acesso);
            }
        }

        private void Frm_AcessosUsuarios_Load(object sender, EventArgs e)
        {
            Opcoes opcoes = new Opcoes();

            Txb_ID.Text = IdUsuario;
            Txb_Nome.Text = NomeUsuario;

            dataGridView1.DataSource = opcoes.RetornaOpcoes();
            ConfigurarGrade();

            dataGridView1.ReadOnly = false;

            dataGridView1.Columns["Nome"].ReadOnly = true;
            dataGridView1.Columns["Descricao"].ReadOnly = true;
            dataGridView1.Columns["Nivel"].ReadOnly = true;

            GetOptions();

        }

        private void GetOptions() 
        {
            MenuAcessos acessos = new MenuAcessos();
            IEnumerable<MenuAcessos> menu = acessos.RetornaAcessosPorUsuario(int.Parse(IdUsuario));

            if (menu.Any()) 
            {
                // Itera sobre as linhas da DataGridView1
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Verifica se há um item correspondente na lista menu
                    if (row.Index < menu.Count())
                    {
                        // Obtém o valor booleano do atributo Liberado de menu
                        char isEnabledChar = menu.ElementAt(row.Index).Liberado;
                        bool isEnabled = CharToBool(isEnabledChar);

                        // Acessa a célula "Liberado" na linha atual
                        DataGridViewCheckBoxCell liberadoCell = row.Cells["Liberado"] as DataGridViewCheckBoxCell;

                        // Marca/desmarca a checkbox conforme o valor
                        liberadoCell.Value = isEnabled;
                    }
                }

                SetFormMode(true);
            }

            
        }

        public bool CharToBool(char valor)
        {
            return valor == 'T';
        }

        private void RegisterOptions()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                MenuAcessos acessos = new MenuAcessos();
                DataGridViewCheckBoxCell checkBox = row.Cells[4] as DataGridViewCheckBoxCell;
                acessos.Id_Opcao = int.Parse(row.Cells["Id"].Value.ToString());
                acessos.Id_Usuario = int.Parse(Txb_ID.Text);
                acessos.Liberado = Convert.ToBoolean(checkBox.Value) == true ? 'T' : 'F';
                acessos.Incluir();

            }
        }

        private void UpdateOptions()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                MenuAcessos acessos = new MenuAcessos();
                DataGridViewCheckBoxCell checkBox = row.Cells[4] as DataGridViewCheckBoxCell;
                acessos.Id_Opcao = int.Parse(row.Cells["Id"].Value.ToString());
                acessos.Id_Usuario = int.Parse(Txb_ID.Text);
                acessos.Liberado = Convert.ToBoolean(checkBox.Value) == true ? 'T' : 'F';
                acessos.Atualizar();

            }
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            if(Btn_Cadastro.Text == "Cadastrar")
            {
                RegisterOptions();
                MessageBox.Show($"Opções de usuário incluidas com sucesso para o usuario: {Txb_Nome.Text}");
                this.Close();
            }
            else
            {
                UpdateOptions();
                MessageBox.Show($"Opções de usuário atualizadas com sucesso para o usuario: {Txb_Nome.Text}");
                this.Close();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetFormMode(bool valor)
        {
            Btn_Cadastro.Text = valor == true ? "Atualizar" : "Cadastrar";
        }
    }
}
