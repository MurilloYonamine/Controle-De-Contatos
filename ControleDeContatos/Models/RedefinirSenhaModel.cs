﻿using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }
    }
}
