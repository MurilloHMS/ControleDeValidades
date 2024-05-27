using ControleDeValidades.Databases;
using System.Windows.Forms;

namespace ControleDeValidades.Models
{
    public class Opcoes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte Nivel { get; set; }

        public Opcoes(string nome,string descricao, byte nivel)
        {
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }
        public Opcoes() { }

        public void Incluir()
        {
            DAL<Opcoes> dal = new DAL<Opcoes>();
            dal.AdicionarRegistro(this);
        }

        public static HashSet<Opcoes> Criar(MenuStrip menu)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            // Nivel 1
            foreach (ToolStripMenuItem item in menu.Items)
            {
                var descricao1 = item.Text;

                if (item.HasDropDownItems)
                {
                    // Nivel 2
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " +  opcao.Text;
                        if (opcao.HasDropDownItems)
                        {
                            // Nivel 3
                            foreach(ToolStripMenuItem subOpcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subOpcao.Text;
                                hashSetOpcoes.Add(new Opcoes(subOpcao.Name, descricao3, 3));
                            }
                        }
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                        
                    }
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
               
            }
            return hashSetOpcoes;
        }

    }
}
