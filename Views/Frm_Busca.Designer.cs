namespace ControleDeValidades.Views
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            groupBox1 = new GroupBox();
            TXT_Filtro = new TextBox();
            LB_Finder = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TXT_Filtro);
            groupBox1.Controls.Add(LB_Finder);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busca";
            // 
            // TXT_Filtro
            // 
            TXT_Filtro.Location = new Point(6, 22);
            TXT_Filtro.Name = "TXT_Filtro";
            TXT_Filtro.Size = new Size(409, 23);
            TXT_Filtro.TabIndex = 0;
            TXT_Filtro.KeyDown += TXT_Filtro_KeyDown;
            // 
            // LB_Finder
            // 
            LB_Finder.FormattingEnabled = true;
            LB_Finder.ItemHeight = 15;
            LB_Finder.Location = new Point(3, 49);
            LB_Finder.Name = "LB_Finder";
            LB_Finder.Size = new Size(415, 439);
            LB_Finder.TabIndex = 1;
            LB_Finder.DoubleClick += LB_Finder_DoubleClick;
            LB_Finder.KeyDown += LB_Finder_KeyDown;
            // 
            // Frm_Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(445, 519);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Consulta";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Finder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private ListBox LB_Finder;
        private TextBox TXT_Filtro;
    }

    #endregion


}