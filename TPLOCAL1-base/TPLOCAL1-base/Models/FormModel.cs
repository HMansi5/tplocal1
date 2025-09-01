using System.ComponentModel.DataAnnotations;
namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir 5 chiffres.")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        [EmailAddress(ErrorMessage = "Le format de l'adresse email est incorrect.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        [DataType(DataType.Date, ErrorMessage = "La date doit une date") ]
        [Range(typeof(DateTime), "01-01-1900", "31-12-2020", ErrorMessage = "La date doit être antérieure au 01/01/2021.")]

        public DateTime DateDebut { get; set; }


        [Required(ErrorMessage = "Champ obligatoire")]

        public string Formation { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Aviscobol { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Aviscsharp { get; set; }
    }
}
