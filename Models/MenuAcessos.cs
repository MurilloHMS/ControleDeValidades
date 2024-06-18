using ControleDeValidades.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeValidades.Models
{
    public class MenuAcessos
    {
        [Key]
        public int ID {  get; set; }
        [Key]
        public int Id_Usuario {  get; set; }
        [Key]
        public int Id_Opcao { get; set; }
        public char Liberado { get; set; } = 'F';

        public void Incluir()
        {
            DAL<MenuAcessos> dAL = new DAL<MenuAcessos>();
            dAL.AdicionarRegistro(this);
        }

        public void Atualizar()
        {
            DAL<MenuAcessos> dal = new DAL<MenuAcessos>();
            dal.AtualizarRegistro(this);
        }

        public IEnumerable<MenuAcessos> RetornaAcessosPorUsuario(int id) 
        {
            DAL<MenuAcessos> dal = new DAL<MenuAcessos>();
            return dal.ObterListaPor(u => u.Id_Usuario.Equals(id)).ToList() ;
        }
    }


}
