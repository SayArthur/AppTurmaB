using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTurmaB.Models
{
    public class Funcionario
    {
        [Range(1, 200, ErrorMessage = "Limite entre 1 e 200")]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int FuncID { get; set; }

        [StringLength(80, MinimumLength = 2, ErrorMessage = "Deve ter entre 2 e 80 caracteres")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
        
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Formato de email inválido")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Formato de data inválido")]
        public DateTime DataNasc { get; set; }

        [StringLength(1)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sexo { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Remote("ValidaLogin", "Funcionario", ErrorMessage = "Login já existe.")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"[a-zA-Z]{5,10}", ErrorMessage = "Só letras")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [System.ComponentModel.DataAnnotations.Compare("Senha")]
        [Display(Name = "Confirmar senha")]
        public string ConfirmarSenha { get; set; }
    }
}