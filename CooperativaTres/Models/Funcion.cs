using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Funcion
    {
        private List<Asiento> asientos { get; set; }
        private int funcionId { get; set; }
        private Pelicula pelicula { get; set; }
        private DateTime diaHorario { get; set; }
    }
}
