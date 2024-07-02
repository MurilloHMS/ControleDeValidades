namespace ControleDeValidades.Views
{
    partial class Frm_AlteraProduto
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            Dtp_DataCadastro = new DateTimePicker();
            Dtp_DataValidade = new DateTimePicker();
            Txt_Fornecedor = new TextBox();
            Txt_Quantidade = new TextBox();
            Txt_CodInterno = new TextBox();
            Txt_NumNFe = new TextBox();
            Txt_Referencia = new TextBox();
            label7 = new Label();
            Txb_ID = new TextBox();
            Txt_Descricao = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Dtp_DataCadastro);
            groupBox1.Controls.Add(Dtp_DataValidade);
            groupBox1.Controls.Add(Txt_Fornecedor);
            groupBox1.Controls.Add(Txt_Quantidade);
            groupBox1.Controls.Add(Txt_CodInterno);
            groupBox1.Controls.Add(Txt_NumNFe);
            groupBox1.Controls.Add(Txt_Referencia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Txb_ID);
            groupBox1.Controls.Add(Txt_Descricao);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Do Produto";
            // 
            // button2
            // 
            button2.Location = new Point(223, 278);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(142, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dtp_DataCadastro
            // 
            Dtp_DataCadastro.Enabled = false;
            Dtp_DataCadastro.Format = DateTimePickerFormat.Short;
            Dtp_DataCadastro.Location = new Point(325, 47);
            Dtp_DataCadastro.Name = "Dtp_DataCadastro";
            Dtp_DataCadastro.Size = new Size(102, 23);
            Dtp_DataCadastro.TabIndex = 3;
            // 
            // Dtp_DataValidade
            // 
            Dtp_DataValidade.Format = DateTimePickerFormat.Short;
            Dtp_DataValidade.Location = new Point(115, 192);
            Dtp_DataValidade.Name = "Dtp_DataValidade";
            Dtp_DataValidade.Size = new Size(102, 23);
            Dtp_DataValidade.TabIndex = 3;
            // 
            // Txt_Fornecedor
            // 
            Txt_Fornecedor.Location = new Point(27, 135);
            Txt_Fornecedor.Name = "Txt_Fornecedor";
            Txt_Fornecedor.Size = new Size(400, 23);
            Txt_Fornecedor.TabIndex = 5;
            // 
            // Txt_Quantidade
            // 
            Txt_Quantidade.Location = new Point(27, 192);
            Txt_Quantidade.Name = "Txt_Quantidade";
            Txt_Quantidade.Size = new Size(69, 23);
            Txt_Quantidade.TabIndex = 2;
            // 
            // Txt_CodInterno
            // 
            Txt_CodInterno.Location = new Point(234, 189);
            Txt_CodInterno.Name = "Txt_CodInterno";
            Txt_CodInterno.Size = new Size(134, 23);
            Txt_CodInterno.TabIndex = 4;
            // 
            // Txt_NumNFe
            // 
            Txt_NumNFe.Location = new Point(234, 236);
            Txt_NumNFe.Name = "Txt_NumNFe";
            Txt_NumNFe.Size = new Size(134, 23);
            Txt_NumNFe.TabIndex = 7;
            // 
            // Txt_Referencia
            // 
            Txt_Referencia.Location = new Point(27, 236);
            Txt_Referencia.Name = "Txt_Referencia";
            Txt_Referencia.Size = new Size(190, 23);
            Txt_Referencia.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 168);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Código Interno";
            // 
            // Txb_ID
            // 
            Txb_ID.Location = new Point(27, 47);
            Txb_ID.Name = "Txb_ID";
            Txb_ID.Size = new Size(65, 23);
            Txb_ID.TabIndex = 1;
            // 
            // Txt_Descricao
            // 
            Txt_Descricao.Location = new Point(27, 91);
            Txt_Descricao.Name = "Txt_Descricao";
            Txt_Descricao.Size = new Size(400, 23);
            Txt_Descricao.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 29);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 0;
            label9.Text = "Data de Cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 215);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 0;
            label6.Text = "Número NFe ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 174);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "Data Validade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 174);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 0;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Fornecedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 29);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 0;
            label8.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 218);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Referencia ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 73);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição Produto";
            // 
            // Frm_AlteraProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 346);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_AlteraProduto";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alteração de produtos";
            Load += Frm_AlteraProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker Dtp_DataValidade;
        private TextBox Txt_Fornecedor;
        private TextBox Txt_Quantidade;
        private TextBox Txt_CodInterno;
        private TextBox Txt_NumNFe;
        private TextBox Txt_Referencia;
        private Label label7;
        private TextBox Txt_Descricao;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox Txb_ID;
        private Label label8;
        private DateTimePicker Dtp_DataCadastro;
        private Label label9;
    }
}