using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Pelicula
    {
        private int peliculaId { get; set; }
        private String titulo { get; set; }
        private DateTime fechaDeEstreno { get; set; }
        private int duracion { get; set; }
        private DateTime fechaDesplazamiento { get; set; }
    }
}
