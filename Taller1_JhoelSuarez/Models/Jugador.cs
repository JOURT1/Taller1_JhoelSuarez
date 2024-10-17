using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller1_JhoelSuarez.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        [Range(0,100)]
        public int Edad { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

    }
}
