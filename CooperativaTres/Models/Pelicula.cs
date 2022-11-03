using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Pelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int peliculaId { get; set; }
        private String titulo { get; set; }
        private DateTime fechaDeEstreno { get; set; }
        private int duracion { get; set; }
        private DateTime fechaDesplazamiento { get; set; }
    }
}
