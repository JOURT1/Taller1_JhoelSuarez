using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller1_JhoelSuarez.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        [Range(0,100)]
        public int Títulos { get; set; }
        public Boolean AceptaExtranjeros { get; set; }

        public Estadio Estadio { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }

    }
}
