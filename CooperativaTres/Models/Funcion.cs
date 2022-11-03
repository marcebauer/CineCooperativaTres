using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Funcion
    {
        private List<Asiento> asientos { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int funcionId { get; set; }
        private Pelicula pelicula { get; set; }
        private DateTime diaHorario { get; set; }
    }
}
