namespace ControleDeValidades.Views.UC
{
    partial class Frm_CadastroUsuarios_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label14 = new Label();
            label1 = new Label();
            Txb_Nome = new TextBox();
            label2 = new Label();
            Txb_Email = new TextBox();
            label3 = new Label();
            Txb_Senha = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Btn_Cadastro = new Button();
            button2 = new Button();
            label4 = new Label();
            Cb_Ativo = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(21, 76, 121);
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(1124, 37);
            label14.TabIndex = 1;
            label14.Text = "CADASTRO DE USUÁRIOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // Txb_Nome
            // 
            Txb_Nome.Location = new Point(15, 59);
            Txb_Nome.Name = "Txb_Nome";
            Txb_Nome.Size = new Size(382, 23);
            Txb_Nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 41);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // Txb_Email
            // 
            Txb_Email.Location = new Point(587, 59);
            Txb_Email.Name = "Txb_Email";
            Txb_Email.Size = new Size(369, 23);
            Txb_Email.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 41);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // Txb_Senha
            // 
            Txb_Senha.Location = new Point(403, 59);
            Txb_Senha.Name = "Txb_Senha";
            Txb_Senha.PasswordChar = '*';
            Txb_Senha.Size = new Size(175, 23);
            Txb_Senha.TabIndex = 3;
            Txb_Senha.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cb_Ativo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Txb_Senha);
            groupBox1.Controls.Add(Txb_Nome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Txb_Email);
            groupBox1.Location = new Point(30, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1049, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações de Login";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(35, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1044, 401);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acessos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1038, 379);
            dataGridView1.TabIndex = 0;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.Location = new Point(384, 634);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(134, 23);
            Btn_Cadastro.TabIndex = 6;
            Btn_Cadastro.Text = "Cadastrar";
            Btn_Cadastro.UseVisualStyleBackColor = true;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // button2
            // 
            button2.Location = new Point(524, 634);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(963, 41);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "Ativo";
            // 
            // Cb_Ativo
            // 
            Cb_Ativo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Ativo.FormattingEnabled = true;
            Cb_Ativo.Items.AddRange(new object[] { "Sim", "Não" });
            Cb_Ativo.Location = new Point(963, 59);
            Cb_Ativo.Name = "Cb_Ativo";
            Cb_Ativo.Size = new Size(66, 23);
            Cb_Ativo.TabIndex = 4;
            // 
            // Frm_CadastroUsuarios_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(Btn_Cadastro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Name = "Frm_CadastroUsuarios_UC";
            Size = new Size(1124, 724);
            Load += Frm_CadastroUsuarios_UC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        private Label label1;
        private TextBox Txb_Nome;
        private Label label2;
        private TextBox Txb_Email;
        private Label label3;
        private TextBox Txb_Senha;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button Btn_Cadastro;
        private Button button2;
        private DataGridView dataGridView1;
        private ComboBox Cb_Ativo;
        private Label label4;
    }
}
