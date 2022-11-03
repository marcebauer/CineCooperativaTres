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
        public int Id { get; set; }
        private String Titulo { get; set; }
        private DateTime FechaDeEstreno { get; set; }
        private int Duracion { get; set; }
        private DateTime FechaDesplazamiento { get; set; }
    }
}
