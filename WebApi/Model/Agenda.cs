using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Agenda
    {
        [Key]
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mensaje { get; set; }
    }
}
