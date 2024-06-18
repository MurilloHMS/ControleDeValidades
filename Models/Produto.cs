using ControleDeValidades.Databases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ControleDeValidades.Models
{
    public class Produto : Entidades
    {
        [Key]
        public int PRONID_PRO { get; set; } //ID Produto
        //
        [Required(ErrorMessage = "É necessario preencher a data de validade")]
        public DateTime PRODDATCAD { get; set; } //Data Lançamento
        //
        [StringLength(50, ErrorMessage = "O Tamanho máximo do campo de código interno é 50 caracteres")]
        public string? PROCCODINT { get; set; } // Codigo interno
        //
        [Required(ErrorMessage = "É necessario preencher a descrição do produto")]
        [StringLength(1000, ErrorMessage = "O Tamanho máximo do campo descrição é 1000 caracteres")]
        public string PROCDESCR { get; set; } //Descrição do produto
        //
        //[Required(ErrorMessage = "É necessario preencher a referência do produto")]
        [StringLength(100, ErrorMessage = "O Tamanho máximo do campo Referencia é 100 caracteres")]
        public string? PROCREF { get; set; } //Referencia Fornecedor
        //
        [Required(ErrorMessage = "É necessario preencher o fornecedor do produto")]
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Fornecedor é 200 caracteres")]
        public string PROCFOR { get; set; } //Fornecedor 
        //
        [Required(ErrorMessage = "É necessario preencher a quantidade do produto")]
        [RegularExpression("([0-9]+)", ErrorMessage = "A Quantidade deve conter apenas Números")]
        [StringLength(10, ErrorMessage = "O Tamanho máximo do campo quantidade é 10 caracteres")]
        public int PRONQUANT { get; set; } //Quantidade
        //
        public DateTime PRODDATVAL { get; set; }//Data Validade
        //
        
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Status é 200 caracteres")]
        public string? PROCSTAT { get; set; } // Status
        //
        [StringLength(50, ErrorMessage = "O Tamanho máximo do campo número da nota é 50 caracteres")]
        public string? PROCNNUMNF { get; set; } //Número NFe
        public DateTime? PRODDATALT { get; set; }
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Usuário Cadastro é 200 caracteres")]
        public string? PROCUSRCAD { get; set; }
        [StringLength(200, ErrorMessage = "O Tamanho máximo do campo Usuário Alteração é 200 caracteres")]
        public string? PROCUSRALT { get; set; }

        //Validacao
        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> resultados = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, resultados, true);

            if (!isValid)
            {
                StringBuilder sb = new StringBuilder();
                foreach(var resultadoValidacao in resultados)
                {
                    sb.AppendLine(resultadoValidacao.ErrorMessage);
                }
                throw new ValidationException(sb.ToString());
            }
        }

        //Crud
        public void Incluir()
        {
            DAL<Produto> dAL = new DAL<Produto>();
            dAL.AdicionarRegistro(this);
        }
    }
}
