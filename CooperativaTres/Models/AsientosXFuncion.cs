using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class AsientosXFuncion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FuncionId { get; set; }
        public Funcion Funcion { get; set; }
        public int AsientoId { get; set; }
        public Asiento Asiento { get; set; }
        public Boolean EstaLibre { get; set; }
    }
}
