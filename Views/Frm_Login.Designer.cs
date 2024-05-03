namespace ControleDeValidades.Views
{
    partial class Frm_Login
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
            Llbl_Forgot = new LinkLabel();
            Txt_Senha = new TextBox();
            Txt_Usuario = new TextBox();
            button1 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // Llbl_Forgot
            // 
            Llbl_Forgot.AutoSize = true;
            Llbl_Forgot.Location = new Point(83, 112);
            Llbl_Forgot.Name = "Llbl_Forgot";
            Llbl_Forgot.Size = new Size(106, 15);
            Llbl_Forgot.TabIndex = 13;
            Llbl_Forgot.TabStop = true;
            Llbl_Forgot.Text = "Esqueceu a Senha?";
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(39, 86);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.PlaceholderText = "Senha";
            Txt_Senha.Size = new Size(196, 23);
            Txt_Senha.TabIndex = 12;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.Location = new Point(39, 44);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.PlaceholderText = "Nome de Usuário ou E-mail";
            Txt_Usuario.Size = new Size(196, 23);
            Txt_Usuario.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 76, 121);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(39, 130);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 10;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 185);
            Controls.Add(Llbl_Forgot);
            Controls.Add(Txt_Senha);
            Controls.Add(Txt_Usuario);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Login";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel Llbl_Forgot;
        private TextBox Txt_Senha;
        private TextBox Txt_Usuario;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}