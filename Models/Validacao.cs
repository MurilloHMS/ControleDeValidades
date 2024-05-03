using System.Text.RegularExpressions;

namespace ControleDeValidades.Models
{
    internal class Validacao
    {
        public static bool ValidaSenhaLogin(string usuario, string senha)
        {
            Usuarios usuarios = new Usuarios();
            Usuarios dados;
            if (ValidaEmail(usuario))
            {
                dados = usuarios.BuscaEmail(usuario);
                if ((senha == dados.Senha) && (usuario == dados.Email))
                {
                    return true;
                }
            }
            else
            {
                dados = usuarios.BuscaUsuario(usuario);
                if ((senha == dados.Senha) && (usuario == dados.Nome))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
