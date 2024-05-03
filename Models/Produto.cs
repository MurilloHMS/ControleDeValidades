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
        public string PROCCODINT {  get; set; } // Codigo interno
        //
        [Required(ErrorMessage = "É necessario preencher a descrição do produto")]
        public string PROCDESCR { get; set; } //Descrição do produto
        //
        [Required(ErrorMessage = "É necessario preencher a referência do produto")]
        public string PROCREF { get; set; } //Referencia Fornecedor
        //
        [Required(ErrorMessage = "É necessario preencher o fornecedor do produto")]
        public string PROCFOR { get; set; } //Fornecedor 
        //
        [Required(ErrorMessage = "É necessario preencher a quantidade do produto")]
        public int PRONQUANT { get; set; } //Quantidade
        //
        public DateTime PRODDATVAL { get; set; }//Data Validade
        //
        public string? PROCSTAT { get; set; } // Status
        //
        public string PROCNNUMNF { get; set; } //Número NFe

        public DateTime? PRODDATALT { get; set; }

        public string? PROCUSRCAD { get; set; }

        public string? PROCUSRALT { get; set; }

        public void Incluir()
        {
            DAL<Produto> dAL = new DAL<Produto>();
            dAL.AdicionarRegistro(this);
        }
    }
}
