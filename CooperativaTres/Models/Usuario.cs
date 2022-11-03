using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaTres.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private String Apellido { get; set; }
        private String Nombre { get; set; }
        private String Email { get; set; }
        private String Password { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        private DateTime FechaDeNacimiento { get; set; }
        private List<Entrada> Entradas { get; set; }
    }
}
