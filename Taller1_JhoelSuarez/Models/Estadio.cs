using System.ComponentModel.DataAnnotations;

namespace Taller1_JhoelSuarez.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
    }
}
