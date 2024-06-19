namespace ControleDeValidades.Views
{
    partial class Frm_AcessosUsuarios
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
            label14 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            Btn_Cadastro = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label1 = new Label();
            Txb_ID = new TextBox();
            Txb_Nome = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(21, 76, 121);
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(1, -1);
            label14.Name = "label14";
            label14.Size = new Size(690, 37);
            label14.TabIndex = 2;
            label14.Text = "ACESSOS DE USUÁRIOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(666, 401);
            groupBox2.TabIndex = 6;
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
            dataGridView1.Size = new Size(660, 379);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(345, 523);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.Location = new Point(205, 523);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(134, 23);
            Btn_Cadastro.TabIndex = 8;
            Btn_Cadastro.Text = "Cadastrar";
            Btn_Cadastro.UseVisualStyleBackColor = true;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Txb_ID);
            groupBox1.Controls.Add(Txb_Nome);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 71);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 6;
            label5.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // Txb_ID
            // 
            Txb_ID.Location = new Point(6, 37);
            Txb_ID.Name = "Txb_ID";
            Txb_ID.ReadOnly = true;
            Txb_ID.Size = new Size(55, 23);
            Txb_ID.TabIndex = 8;
            // 
            // Txb_Nome
            // 
            Txb_Nome.Location = new Point(102, 37);
            Txb_Nome.Name = "Txb_Nome";
            Txb_Nome.ReadOnly = true;
            Txb_Nome.Size = new Size(525, 23);
            Txb_Nome.TabIndex = 9;
            // 
            // Frm_AcessosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 567);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(Btn_Cadastro);
            Controls.Add(groupBox2);
            Controls.Add(label14);
            Name = "Frm_AcessosUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_AcessosUsuarios_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label14;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button Btn_Cadastro;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private TextBox Txb_ID;
        private TextBox Txb_Nome;
    }
}