namespace ControleDeValidades.Views
{
    partial class Frm_CadastroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroUsuarios));
            groupBox1 = new GroupBox();
            Cbx_VisualizarSenha = new CheckBox();
            Btn_BuscarUsuario = new Button();
            Cb_Ativo = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            Txb_Senha = new TextBox();
            Txt_ID = new TextBox();
            Txb_Nome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            Txb_Email = new TextBox();
            groupBox2 = new GroupBox();
            Btn_Acessos = new Button();
            Btn_Excluir = new Button();
            Btn_Register = new Button();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cbx_VisualizarSenha);
            groupBox1.Controls.Add(Btn_BuscarUsuario);
            groupBox1.Controls.Add(Cb_Ativo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Txb_Senha);
            groupBox1.Controls.Add(Txt_ID);
            groupBox1.Controls.Add(Txb_Nome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Txb_Email);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 259);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações de Login";
            // 
            // Cbx_VisualizarSenha
            // 
            Cbx_VisualizarSenha.AutoSize = true;
            Cbx_VisualizarSenha.Location = new Point(17, 225);
            Cbx_VisualizarSenha.Name = "Cbx_VisualizarSenha";
            Cbx_VisualizarSenha.Size = new Size(110, 19);
            Cbx_VisualizarSenha.TabIndex = 6;
            Cbx_VisualizarSenha.Text = "Visualizar Senha";
            Cbx_VisualizarSenha.UseVisualStyleBackColor = true;
            Cbx_VisualizarSenha.CheckedChanged += Cbx_VisualizarSenha_CheckedChanged;
            // 
            // Btn_BuscarUsuario
            // 
            Btn_BuscarUsuario.Location = new Point(78, 59);
            Btn_BuscarUsuario.Name = "Btn_BuscarUsuario";
            Btn_BuscarUsuario.Size = new Size(29, 23);
            Btn_BuscarUsuario.TabIndex = 5;
            Btn_BuscarUsuario.Text = "...";
            Btn_BuscarUsuario.UseVisualStyleBackColor = true;
            Btn_BuscarUsuario.Click += Btn_BuscarUsuario_Click;
            // 
            // Cb_Ativo
            // 
            Cb_Ativo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Ativo.FormattingEnabled = true;
            Cb_Ativo.Items.AddRange(new object[] { "Sim", "Não" });
            Cb_Ativo.Location = new Point(277, 197);
            Cb_Ativo.Name = "Cb_Ativo";
            Cb_Ativo.Size = new Size(66, 23);
            Cb_Ativo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 41);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 2;
            label5.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 91);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // Txb_Senha
            // 
            Txb_Senha.Location = new Point(17, 197);
            Txb_Senha.Name = "Txb_Senha";
            Txb_Senha.Size = new Size(175, 23);
            Txb_Senha.TabIndex = 4;
            Txb_Senha.UseSystemPasswordChar = true;
            // 
            // Txt_ID
            // 
            Txt_ID.Location = new Point(17, 59);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.Size = new Size(55, 23);
            Txt_ID.TabIndex = 1;
            // 
            // Txb_Nome
            // 
            Txb_Nome.Location = new Point(17, 109);
            Txb_Nome.Name = "Txb_Nome";
            Txb_Nome.Size = new Size(332, 23);
            Txb_Nome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 179);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 179);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "Ativo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 135);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // Txb_Email
            // 
            Txb_Email.Location = new Point(17, 153);
            Txb_Email.Name = "Txb_Email";
            Txb_Email.Size = new Size(332, 23);
            Txb_Email.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_Acessos);
            groupBox2.Controls.Add(Btn_Excluir);
            groupBox2.Controls.Add(Btn_Register);
            groupBox2.Location = new Point(12, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 46);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // Btn_Acessos
            // 
            Btn_Acessos.Location = new Point(277, 17);
            Btn_Acessos.Name = "Btn_Acessos";
            Btn_Acessos.Size = new Size(119, 23);
            Btn_Acessos.TabIndex = 9;
            Btn_Acessos.Text = "Acessos";
            Btn_Acessos.UseVisualStyleBackColor = true;
            Btn_Acessos.Click += Btn_Acessos_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(141, 17);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(119, 23);
            Btn_Excluir.TabIndex = 8;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            Btn_Excluir.Click += Btn_Cancelar_Click;
            // 
            // Btn_Cadastro
            // 
            Btn_Register.Location = new Point(6, 17);
            Btn_Register.Name = "Btn_Cadastro";
            Btn_Register.Size = new Size(119, 23);
            Btn_Register.TabIndex = 7;
            Btn_Register.Text = "Cadastrar";
            Btn_Register.UseVisualStyleBackColor = true;
            Btn_Register.Click += Btn_Cadastro_Click;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(21, 76, 121);
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(432, 37);
            label14.TabIndex = 7;
            label14.Text = "CADASTRO DE USUÁRIOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Frm_CadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 387);
            Controls.Add(label14);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_CadastroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Cbx_VisualizarSenha;
        private Button Btn_BuscarUsuario;
        private ComboBox Cb_Ativo;
        private Label label5;
        private Label label1;
        private TextBox Txb_Senha;
        private TextBox Txt_ID;
        private TextBox Txb_Nome;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox Txb_Email;
        private GroupBox groupBox2;
        private Button Btn_Acessos;
        private Button Btn_Excluir;
        private Button Btn_Register;
        private Label label14;
    }
}