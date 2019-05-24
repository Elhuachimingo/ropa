using System.ComponentModel.DataAnnotations;

namespace Ropitahuachi.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public int Edad { get; set; }

        [Required]
        public string NombreTemporal { get; set; }

        [Required]
        public string Foto { get; set; }
    }
}