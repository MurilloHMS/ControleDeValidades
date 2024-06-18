using ControleDeValidades.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeValidades.Views
{
    public partial class Frm_Busca : Form
    {
        List<ItemBox> _ListaBusca = new List<ItemBox>();
        public int idSelect { get; set; }
        public string NomeSelect { get; set; }
        public string EmailSelect {  get; set; }
        public string SenhaSelect {  get; set; }
        public char AtivoSelect { get; set; }

        Usuarios usuarios = new Usuarios();

        public Frm_Busca()
        {
            InitializeComponent();
            PreencherLista();
            LB_Finder.Sorted = true;
            TXT_Filtro.TextChanged += TXT_Filtro_TextChanged;
        }

        private void PreencherLista()
        {
            LB_Finder.Items.Clear();
            _ListaBusca.Clear();

            var retornoUsuarios = usuarios.RetornaUsuarios();
            foreach( Usuarios usuario in retornoUsuarios)
            {
                ItemBox x = new ItemBox();
                x.Id = usuario.ID;
                x.Nome = usuario.Nome;
                x.Email = usuario.Email;
                x.Senha = usuario.Senha;
                x.Ativo = usuario.Ativo;
                _ListaBusca.Add(x);
                LB_Finder.Items.Add(x);
            }
        }

        private void SelecionarItem()
        {
            try
            {
                ItemBox itemSelecionado = (ItemBox)LB_Finder.Items[LB_Finder.SelectedIndex];
                DialogResult = DialogResult.OK;
                idSelect = itemSelecionado.Id;
                NomeSelect = itemSelecionado.Nome;
                EmailSelect = itemSelecionado.Email;
                SenhaSelect = itemSelecionado.Senha;
                AtivoSelect = itemSelecionado.Ativo;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção selecione um usuário válido!", "Usuário Selecionado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TXT_Filtro_TextChanged(object sender, EventArgs e)
        {
            string filtro = TXT_Filtro.Text.ToLower();
            List<ItemBox> itensFiltrados = _ListaBusca.Where(x => x.Nome.ToLower().Contains(filtro)).ToList();

            LB_Finder.Items.Clear();
            foreach (var item in itensFiltrados)
            {
                LB_Finder.Items.Add(item);
            }
        }
        private class ItemBox
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public string Email { get; set; } 
            public string Senha { get; set; }
            public char Ativo {  get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }

        public void LB_Finder_DoubleClick(object sender, EventArgs e)
        {
            SelecionarItem();
        }

        private void LB_Finder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SelecionarItem();
            }
        }

        private void TXT_Filtro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
