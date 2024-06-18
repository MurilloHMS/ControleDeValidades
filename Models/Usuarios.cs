using ControleDeValidades.Databases;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;


namespace ControleDeValidades.Models
{
    public class Usuarios : Entidades
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="O Nome é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Nome é 200 caracteres")]
        public string Nome { get; set; }
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo E-mail é 200 caracteres")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "A Senha é Obrigatória")]
        [StringLength(100, ErrorMessage = "O Tamanho máximo do campo Senha é 100 caracteres")]
        public string Senha { get; set; }
        public char Ativo { get; set; }
        
        
        public void Incluir()
        {
            DAL<Usuarios> dAL = new DAL<Usuarios>();
            dAL.AdicionarRegistro(this);
        }

        public void Atualizar()
        {
            DAL<Usuarios> dal  = new DAL<Usuarios>();
            dal.AtualizarRegistro(this);
        }

        public void Deletar()
        {
            DAL<Usuarios> dal = new DAL<Usuarios>();
            dal.DeletaRegistro(this);
        }

        public Usuarios BuscaUsuarioPorNome(string nome)
        {
            DAL<Usuarios> dAL = new DAL<Usuarios>();
            return dAL.ObterRegistroPor(usuario => usuario.Nome.ToUpper().Equals(nome.ToUpper()));
                        
        }

        public Usuarios BuscaUsuarioPorId(int id)
        {
            DAL<Usuarios> dal = new DAL<Usuarios>();
            return dal.ObterRegistroPor(usuario => usuario.ID.Equals(id));
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
