namespace ControleDeValidades.Views
{
    partial class Frm_DefaultWindows
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
            Tb_MainWindow = new TabControl();
            SuspendLayout();
            // 
            // Tb_MainWindow
            // 
            Tb_MainWindow.Dock = DockStyle.Fill;
            Tb_MainWindow.Location = new Point(0, 0);
            Tb_MainWindow.Name = "Tb_MainWindow";
            Tb_MainWindow.SelectedIndex = 0;
            Tb_MainWindow.Size = new Size(1154, 722);
            Tb_MainWindow.TabIndex = 3;
            // 
            // Frm_DefaultWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 722);
            Controls.Add(Tb_MainWindow);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Frm_DefaultWindows";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_FiltroProdutos";
            Load += Frm_FiltroProdutos_Load;
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tb_MainWindow;
    }
}