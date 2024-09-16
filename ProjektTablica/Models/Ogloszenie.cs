using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjektTablica.Models
{
    public class Ogloszenie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Tytul { get; set; }

        [Display(Name = "Data dodania")]
        [DataType(DataType.DateTime)]
        public DateTime? Data { get; set; }

        [Required]
        [StringLength(300)]
        public string? Tresc { get; set; }
    }
}
