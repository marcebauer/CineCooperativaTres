using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Asiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int asientoId { get; set; }
        private int fila { get; set; }
        private Boolean estaLibre { get; set; }
        private int numeroDeAsiento { get; set; }
    }
}
