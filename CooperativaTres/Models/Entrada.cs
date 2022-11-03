using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Entrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int entradaId { get; set; }
        private Asiento asiento { get; set; }
        private Funcion funcion { get; set; }
    }
}
