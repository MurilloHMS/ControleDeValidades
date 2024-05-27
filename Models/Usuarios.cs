using ControleDeValidades.Databases;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ControleDeValidades.Models
{
    public class Usuarios : Entidades
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="O Nome é Obrigatório")]
        public string Nome { get; set; }        
        public string? Email { get; set; }
        [Required(ErrorMessage = "A Senha é Obrigatória")]
        public string Senha { get; set; }
        public char Ativo { get; set; }

        
        public void Incluir()
        {
            DAL<Usuarios> dAL = new DAL<Usuarios>();
            dAL.AdicionarRegistro(this);
        }

        public Usuarios BuscaUsuario(string nome)
        {
            DAL<Usuarios> dAL = new DAL<Usuarios>();
            return dAL.ObterRegistroPor(usuario => usuario.Nome.ToUpper().Equals(nome.ToUpper()));
                        
        }

        public Usuarios BuscaEmail(string email)
        {
            DAL<Usuarios> dAL = new DAL<Usuarios>();
            return dAL.ObterRegistroPor(usuario => usuario.Email.ToUpper().Equals(email.ToUpper()));

        }

        public IEnumerable<Usuarios> RetornaUsuarios()
        {
            var dal = new DAL<Usuarios>();
            return dal.ObterRegistros();
        }
    }
}
