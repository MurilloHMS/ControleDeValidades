namespace ControleDeValidades.Views.UC
{
    partial class Frm_CadastroDeProduto_UC
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
            groupBox1 = new GroupBox();
            Dtp_DataValidade = new DateTimePicker();
            Txt_Fornecedor = new TextBox();
            Txt_Quantidade = new TextBox();
            Txt_CodInterno = new TextBox();
            Txt_NumNFe = new TextBox();
            Txt_Referencia = new TextBox();
            label7 = new Label();
            Txt_Descricao = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Btn_Inserir = new Button();
            Btn_Excluir = new Button();
            groupBox2 = new GroupBox();
            Btn_Salvar = new Button();
            groupBox3 = new GroupBox();
            Dgv_Produtos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Produtos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Dtp_DataValidade);
            groupBox1.Controls.Add(Txt_Fornecedor);
            groupBox1.Controls.Add(Txt_Quantidade);
            groupBox1.Controls.Add(Txt_CodInterno);
            groupBox1.Controls.Add(Txt_NumNFe);
            groupBox1.Controls.Add(Txt_Referencia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Txt_Descricao);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Do Produto";
            // 
            // Dtp_DataValidade
            // 
            Dtp_DataValidade.Format = DateTimePickerFormat.Short;
            Dtp_DataValidade.Location = new Point(536, 50);
            Dtp_DataValidade.Name = "Dtp_DataValidade";
            Dtp_DataValidade.Size = new Size(102, 23);
            Dtp_DataValidade.TabIndex = 3;
            // 
            // Txt_Fornecedor
            // 
            Txt_Fornecedor.Location = new Point(31, 94);
            Txt_Fornecedor.Name = "Txt_Fornecedor";
            Txt_Fornecedor.Size = new Size(400, 23);
            Txt_Fornecedor.TabIndex = 5;
            // 
            // Txt_Quantidade
            // 
            Txt_Quantidade.Location = new Point(448, 50);
            Txt_Quantidade.Name = "Txt_Quantidade";
            Txt_Quantidade.Size = new Size(69, 23);
            Txt_Quantidade.TabIndex = 2;
            // 
            // Txt_CodInterno
            // 
            Txt_CodInterno.Location = new Point(655, 47);
            Txt_CodInterno.Name = "Txt_CodInterno";
            Txt_CodInterno.Size = new Size(134, 23);
            Txt_CodInterno.TabIndex = 4;
            // 
            // Txt_NumNFe
            // 
            Txt_NumNFe.Location = new Point(655, 94);
            Txt_NumNFe.Name = "Txt_NumNFe";
            Txt_NumNFe.Size = new Size(134, 23);
            Txt_NumNFe.TabIndex = 7;
            // 
            // Txt_Referencia
            // 
            Txt_Referencia.Location = new Point(448, 94);
            Txt_Referencia.Name = "Txt_Referencia";
            Txt_Referencia.Size = new Size(190, 23);
            Txt_Referencia.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(655, 26);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Código Interno";
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(31, 50);
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(400, 23);
            Txt_Descricao.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(655, 73);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 0;
            label6.Text = "Número NFe (Opcional)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 32);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "Data Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 32);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 0;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 76);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 76);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 0;
            label2.Text = "Referencia (Opcional)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição Produto";
            // 
            // Btn_Inserir
            // 
            Btn_Inserir.Location = new Point(46, 32);
            Btn_Inserir.Name = "Btn_Inserir";
            Btn_Inserir.Size = new Size(140, 23);
            Btn_Inserir.TabIndex = 8;
            Btn_Inserir.Text = "&Inserir";
            Btn_Inserir.UseVisualStyleBackColor = true;
            Btn_Inserir.Click += Btn_Inserir_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(46, 73);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(140, 23);
            Btn_Excluir.TabIndex = 9;
            Btn_Excluir.Text = "&Limpar Tabela";
            Btn_Excluir.UseVisualStyleBackColor = true;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_Salvar);
            groupBox2.Controls.Add(Btn_Inserir);
            groupBox2.Controls.Add(Btn_Excluir);
            groupBox2.Location = new Point(868, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 151);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controles";
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(46, 112);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(140, 23);
            Btn_Salvar.TabIndex = 10;
            Btn_Salvar.Text = "&Salvar Produtos";
            Btn_Salvar.UseVisualStyleBackColor = true;
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Dgv_Produtos);
            groupBox3.Location = new Point(17, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1085, 456);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produtos";
            // 
            // Dgv_Produtos
            // 
            Dgv_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Produtos.Dock = DockStyle.Fill;
            Dgv_Produtos.Location = new Point(3, 19);
            Dgv_Produtos.Name = "Dgv_Produtos";
            Dgv_Produtos.Size = new Size(1079, 434);
            Dgv_Produtos.TabIndex = 0;
            // 
            // Frm_CadastroDeProduto_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroDeProduto_UC";
            Size = new Size(1124, 724);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Txt_Descricao;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Dtp_DataValidade;
        private TextBox Txt_Fornecedor;
        private TextBox Txt_Referencia;
        private TextBox Txt_NumNFe;
        private Button Btn_Inserir;
        private Button Btn_Excluir;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView Dgv_Produtos;
        private Button Btn_Salvar;
        private TextBox Txt_CodInterno;
        private Label label7;
        private TextBox Txt_Quantidade;
    }
}
