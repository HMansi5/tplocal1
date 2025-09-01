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
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        [DataType(DataType.Date)]
        public DateTime DateDebut { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Formation { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Aviscobol { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Aviscsharp { get; set; }
    }
}
