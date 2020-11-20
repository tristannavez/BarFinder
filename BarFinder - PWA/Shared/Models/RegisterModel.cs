using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POIN.Shared.Models
{
    public class RegisterModel
    {
    [Required(ErrorMessage = "Ce champ est obligatoire")]
    [EmailAddress(ErrorMessage = "L'email doit être valide")]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Ce champ est obligatoire")]
    [StringLength(100, ErrorMessage = "Le mot de passe doit contenir entre {2} et {1} caractères.", MinimumLength = 6)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,30}$" , ErrorMessage = "Le mot de passe doit contenir : au moins une majuscule et une minuscule, un caractère spécial et un chiffre")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "Le mots de passe ne correspondent pas.")]
    public string ConfirmPassword { get; set; }
    }
}