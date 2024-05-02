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
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            importarXMLToolStripMenuItem1 = new ToolStripMenuItem();
            janelasToolStripMenuItem1 = new ToolStripMenuItem();
            filtroProdutosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, cadastrosToolStripMenuItem, janelasToolStripMenuItem1, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1123, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem1, importarXMLToolStripMenuItem1 });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            produtoToolStripMenuItem1.Size = new Size(147, 22);
            produtoToolStripMenuItem1.Text = "Produto";
            // 
            // importarXMLToolStripMenuItem1
            // 
            importarXMLToolStripMenuItem1.Name = "importarXMLToolStripMenuItem1";
            importarXMLToolStripMenuItem1.Size = new Size(147, 22);
            importarXMLToolStripMenuItem1.Text = "Importar XML";
            importarXMLToolStripMenuItem1.Click += importarXMLToolStripMenuItem1_Click;
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
            filtroProdutosToolStripMenuItem.Name = "filtroProdutosToolStripMenuItem";
            filtroProdutosToolStripMenuItem.Size = new Size(152, 22);
            filtroProdutosToolStripMenuItem.Text = "Filtro Produtos";
            filtroProdutosToolStripMenuItem.Click += filtroProdutosToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 754);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle De Validades";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private ToolStripMenuItem importarXMLToolStripMenuItem1;
        private ToolStripMenuItem janelasToolStripMenuItem1;
        private ToolStripMenuItem filtroProdutosToolStripMenuItem;
    }
}
