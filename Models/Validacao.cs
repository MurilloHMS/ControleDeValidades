using System.Text.RegularExpressions;

namespace ControleDeValidades.Models
{
    public class Validacao
    {
        public string mensagem;
        public bool ValidaSenhaLogin(string usuario, string senha)
        {
            Usuarios usuarios = new Usuarios();
            Usuarios dados = ValidaUsuario(usuario);

            if (dados != null && dados.Ativo == 'T' && ValidaCredenciais(usuario, senha, dados))
            {
                mensagem = "Login Efetuado com Sucesso!";
                return true;
            }
            else
            {
                mensagem = dados != null && dados.Ativo == 'T' ? "Senha Incorreta!" : "Usuário Inativo";
                return false;
            }


        }

        private Usuarios ValidaUsuario(string usuario)
        {
            Usuarios usuarios = new Usuarios();
            return ValidaEmail(usuario) ? usuarios.BuscaEmail(usuario) : usuarios.BuscaUsuarioPorNome(usuario);
        }

        private bool ValidaCredenciais(string usuario, string senha, Usuarios dados)
        {
            return (senha == dados.Senha) &&  (usuario.ToUpper() ==(ValidaEmail(usuario) ? dados.Email.ToUpper() : dados.Nome.ToUpper()));
        }

        private static bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
