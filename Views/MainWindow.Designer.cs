namespace ControleDeValidades
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolStripMenuItem filtroProdutosToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            loginSistemaToolStripMenuItem = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            importarXMLToolStripMenuItem1 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            janelasToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LabelMenu = new ToolStripStatusLabel();
            filtroProdutosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, cadastrosToolStripMenuItem, janelasToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1123, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginSistemaToolStripMenuItem, desconectarToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // loginSistemaToolStripMenuItem
            // 
            loginSistemaToolStripMenuItem.Image = Properties.Resources.Connected_People;
            loginSistemaToolStripMenuItem.Name = "loginSistemaToolStripMenuItem";
            loginSistemaToolStripMenuItem.Size = new Size(180, 22);
            loginSistemaToolStripMenuItem.Text = "Login Sistema";
            loginSistemaToolStripMenuItem.Click += loginSistemaToolStripMenuItem_Click;
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(180, 22);
            desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem1, importarXMLToolStripMenuItem1, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Enabled = false;
            produtoToolStripMenuItem1.Image = Properties.Resources.New_Product_1;
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            produtoToolStripMenuItem1.Size = new Size(180, 22);
            produtoToolStripMenuItem1.Text = "Produto";
            produtoToolStripMenuItem1.Click += produtoToolStripMenuItem1_Click;
            // 
            // importarXMLToolStripMenuItem1
            // 
            importarXMLToolStripMenuItem1.Enabled = false;
            importarXMLToolStripMenuItem1.Image = Properties.Resources.XML_Transformer_1;
            importarXMLToolStripMenuItem1.Name = "importarXMLToolStripMenuItem1";
            importarXMLToolStripMenuItem1.Size = new Size(180, 22);
            importarXMLToolStripMenuItem1.Text = "Importar XML";
            importarXMLToolStripMenuItem1.Click += importarXMLToolStripMenuItem1_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Enabled = false;
            usuáriosToolStripMenuItem.Image = Properties.Resources.Add_User_Group_Woman_Man;
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(180, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // janelasToolStripMenuItem1
            // 
            janelasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { filtroProdutosToolStripMenuItem });
            janelasToolStripMenuItem1.Name = "janelasToolStripMenuItem1";
            janelasToolStripMenuItem1.Size = new Size(56, 20);
            janelasToolStripMenuItem1.Text = "Janelas";
            // 
            // filtroProdutosToolStripMenuItem
            // 
            filtroProdutosToolStripMenuItem.Enabled = false;
            filtroProdutosToolStripMenuItem.Image = Properties.Resources.Search_Property;
            filtroProdutosToolStripMenuItem.Name = "filtroProdutosToolStripMenuItem";
            filtroProdutosToolStripMenuItem.Size = new Size(180, 22);
            filtroProdutosToolStripMenuItem.Text = "Filtro Produtos";
            filtroProdutosToolStripMenuItem.Click += filtroProdutosToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelMenu });
            statusStrip1.Location = new Point(0, 732);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1123, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelMenu
            // 
            LabelMenu.Name = "LabelMenu";
            LabelMenu.Size = new Size(117, 17);
            LabelMenu.Text = "Usuário Conectado : ";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 754);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle De Validades";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private ToolStripMenuItem importarXMLToolStripMenuItem1;
        private ToolStripMenuItem janelasToolStripMenuItem1;
        private ToolStripMenuItem filtroProdutosToolStripMenuItem;
        private ToolStripMenuItem loginSistemaToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelMenu;
    }
}
