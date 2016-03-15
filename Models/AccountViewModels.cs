using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPFinal.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Le {0} est obligatoire.")]
        [RegularExpression(@"^[a-zA-Z]*$",
         ErrorMessage = "Le {0} ne doit contenir que des lettres et aucun espace.")]
        [StringLength(100, ErrorMessage = "Le {0} doit faire {1} caracteres minimum.", MinimumLength = 3)]
        [Display(Name = "Nom de famille")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le {0} est obligatoire.")]
        [RegularExpression(@"^[a-zA-Z]*$",
         ErrorMessage = "Le {0} ne doit contenir que des lettres et aucun espace.")]
        [StringLength(100, ErrorMessage = "Le {0} doit faire {1} caracteres minimum.", MinimumLength = 3)]
        [Display(Name = "Prénom")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Le {0} est obligatoire.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
         ErrorMessage = "Le format de votre adresse e-mail est invalide.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le {0} est obligatoire.")]
        [StringLength(100, ErrorMessage = "Le {0} doit faire {2} caracteres minimum.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Le {0} est obligatoire.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation")]
        [Compare("Password", ErrorMessage = "Les 2 mots de passes ne corresddent pas.")]
        public string ConfirmPassword { get; set; }
    }

   
}
