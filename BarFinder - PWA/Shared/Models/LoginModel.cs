using System;
using System.ComponentModel.DataAnnotations;


namespace POIN.Shared.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "L'email doit être valide")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le mot de passe doit contenir entre {2} et {1} caractères.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,30}$" , ErrorMessage = "Le mot de passe doit contenir : au moins une majuscule et une minuscule, un caractère spécial et un chiffre")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}