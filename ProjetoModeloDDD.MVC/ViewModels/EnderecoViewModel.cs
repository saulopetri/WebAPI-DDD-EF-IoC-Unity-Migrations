using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string CardholderName { get; set; }

        [Required(ErrorMessage = "Preencha o campo número do cartão")]
        [MaxLength(19, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(14, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Número do Cartão")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Expiração")]
        [DisplayName("Data de Expiração")]
        public DateTime ExpirationDate { get; set; }

        public string Password { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999")]
        [Required(ErrorMessage = "Preencha o campo Limite de crédito")]
        [DisplayName("Limite de crédito")]
        public decimal CreditLimit { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

        public int TipoEnderecoId { get; set; }
        //public virtual TipoEndereco TipoEndereco { get; set; }

        public int BandeiraEnderecoId { get; set; }
        //public virtual BandeiraEndereco BandeiraEndereco { get; set; }
    }
}