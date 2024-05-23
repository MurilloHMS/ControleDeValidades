namespace ControleDeValidades.Views.UC
{
    partial class Frm_ImportarXml_UC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            Txb_NumNfe = new TextBox();
            TxB_Cnpj = new TextBox();
            label7 = new Label();
            Dtp_DataEntrada = new DateTimePicker();
            Dtp_DataEmissao = new DateTimePicker();
            Txb_RzSocial = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            Txb_ChaveNFe = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Dgv_DadosXML = new DataGridView();
            Dgv_Check = new DataGridViewCheckBoxColumn();
            CODINT = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_DadosXML).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(Txb_NumNfe);
            groupBox1.Controls.Add(TxB_Cnpj);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Dtp_DataEntrada);
            groupBox1.Controls.Add(Dtp_DataEmissao);
            groupBox1.Controls.Add(Txb_RzSocial);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Txb_ChaveNFe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1137, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados NFe";
            // 
            // Txb_NumNfe
            // 
            Txb_NumNfe.Location = new Point(885, 110);
            Txb_NumNfe.Name = "Txb_NumNfe";
            Txb_NumNfe.Size = new Size(82, 23);
            Txb_NumNfe.TabIndex = 13;
            // 
            // TxB_Cnpj
            // 
            TxB_Cnpj.Location = new Point(439, 110);
            TxB_Cnpj.Name = "TxB_Cnpj";
            TxB_Cnpj.Size = new Size(180, 23);
            TxB_Cnpj.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 92);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "CNPJ";
            // 
            // Dtp_DataEntrada
            // 
            Dtp_DataEntrada.Format = DateTimePickerFormat.Short;
            Dtp_DataEntrada.Location = new Point(747, 110);
            Dtp_DataEntrada.Name = "Dtp_DataEntrada";
            Dtp_DataEntrada.Size = new Size(106, 23);
            Dtp_DataEntrada.TabIndex = 10;
            // 
            // Dtp_DataEmissao
            // 
            Dtp_DataEmissao.Format = DateTimePickerFormat.Short;
            Dtp_DataEmissao.Location = new Point(635, 110);
            Dtp_DataEmissao.Name = "Dtp_DataEmissao";
            Dtp_DataEmissao.Size = new Size(106, 23);
            Dtp_DataEmissao.TabIndex = 9;
            // 
            // Txb_RzSocial
            // 
            Txb_RzSocial.Location = new Point(42, 110);
            Txb_RzSocial.Name = "Txb_RzSocial";
            Txb_RzSocial.Size = new Size(368, 23);
            Txb_RzSocial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(885, 92);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 6;
            label5.Text = "Nota Fiscal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(747, 92);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Data Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(635, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Data Emissão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 92);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Razão Social";
            // 
            // button1
            // 
            button1.Location = new Point(855, 45);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 2;
            button1.Text = "Importar XML";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Txb_ChaveNFe
            // 
            Txb_ChaveNFe.Location = new Point(42, 46);
            Txb_ChaveNFe.Name = "Txb_ChaveNFe";
            Txb_ChaveNFe.Size = new Size(774, 23);
            Txb_ChaveNFe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Chave Nfe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Dgv_DadosXML);
            groupBox2.Location = new Point(3, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1140, 459);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos XML";
            // 
            // Dgv_DadosXML
            // 
            Dgv_DadosXML.AllowUserToAddRows = false;
            Dgv_DadosXML.AllowUserToDeleteRows = false;
            Dgv_DadosXML.AllowUserToOrderColumns = true;
            Dgv_DadosXML.BackgroundColor = SystemColors.Control;
            Dgv_DadosXML.BorderStyle = BorderStyle.None;
            Dgv_DadosXML.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Dgv_DadosXML.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            Dgv_DadosXML.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 76, 121);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(21, 76, 121);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv_DadosXML.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_DadosXML.ColumnHeadersHeight = 30;
            Dgv_DadosXML.Columns.AddRange(new DataGridViewColumn[] { Dgv_Check, CODINT });
            Dgv_DadosXML.Cursor = Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgv_DadosXML.DefaultCellStyle = dataGridViewCellStyle2;
            Dgv_DadosXML.Dock = DockStyle.Fill;
            Dgv_DadosXML.EnableHeadersVisualStyles = false;
            Dgv_DadosXML.GridColor = Color.White;
            Dgv_DadosXML.Location = new Point(3, 19);
            Dgv_DadosXML.Name = "Dgv_DadosXML";
            Dgv_DadosXML.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 76, 121);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Dgv_DadosXML.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Dgv_DadosXML.RowHeadersVisible = false;
            Dgv_DadosXML.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_DadosXML.Size = new Size(1134, 437);
            Dgv_DadosXML.TabIndex = 0;
            // 
            // Dgv_Check
            // 
            Dgv_Check.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Dgv_Check.HeaderText = "Selecionar";
            Dgv_Check.Name = "Dgv_Check";
            Dgv_Check.Resizable = DataGridViewTriState.True;
            Dgv_Check.SortMode = DataGridViewColumnSortMode.Automatic;
            Dgv_Check.Width = 70;
            // 
            // CODINT
            // 
            CODINT.HeaderText = "Código Interno";
            CODINT.Name = "CODINT";
            // 
            // button2
            // 
            button2.Location = new Point(314, 637);
            button2.Name = "button2";
            button2.Size = new Size(222, 23);
            button2.TabIndex = 2;
            button2.Text = "Importar Produtos Selecionados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(542, 637);
            button3.Name = "button3";
            button3.Size = new Size(222, 23);
            button3.TabIndex = 2;
            button3.Text = "Importar Todos Os Produtos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Frm_ImportarXml_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_ImportarXml_UC";
            Size = new Size(1146, 724);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_DadosXML).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox Txb_ChaveNFe;
        private Label label1;
        private DateTimePicker Dtp_DataEntrada;
        private DateTimePicker Dtp_DataEmissao;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView Dgv_DadosXML;
        private Button button2;
        private Button button3;
        private TextBox Txb_NumNfe;
        private TextBox TxB_Cnpj;
        private Label label7;
        private TextBox Txb_RzSocial;
        private Label label5;
        private Label label2;
        private DataGridViewCheckBoxColumn Dgv_Check;
        private DataGridViewTextBoxColumn CODINT;
    }
}
