using ControleDeValidades.Databases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ControleDeValidades.Models
{
    public class Produto
    {
        [Key]
        public int PRONID_PRO { get; set; }
        [Required(ErrorMessage = "É necessario preencher a data de validade")]
        public DateTime PRODDATVAL { get; set; }
        [Required(ErrorMessage = "É necessario preencher a referência do produto")]
        public string PROCREF { get; set; }
        [Required(ErrorMessage = "É necessario preencher a descrição do produto")]
        public string PROCDESCR { get; set; }
        [Required(ErrorMessage = "É necessario preencher a quantidade do produto")]
        public int PRONQUANT { get; set; }
        [Required(ErrorMessage = "É necessario preencher o fornecedor do produto")]
        public string PROCFOR { get; set; }
        public string? PROCSTAT { get; set; } 
        
        public DateTime PRODDATCAD { get; set; }

        public DateTime? PRODDATALT { get; set; }

        public string? PROCUSRCAD { get; set; }

        public string? PROCUSRALT { get; set; }

        public void ValidaClasse()
        {
            ValidationContext contextoValidacao = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> resultadoValidacao = new List<ValidationResult>();
            bool valido = Validator.TryValidateObject(this, contextoValidacao, resultadoValidacao, true);

            if (valido)
            {
                StringBuilder Errors = new StringBuilder();
                foreach(var resultado in resultadoValidacao)
                {
                    Errors.AppendLine(resultado.ErrorMessage);
                }
                throw new ValidationException(Errors.ToString());
            }
        }

        public void Incluir()
        {
            DAL<Produto> dAL = new DAL<Produto>();
            dAL.AdicionarRegistro(this);
        }
    }
}
