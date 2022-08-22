using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    public class PatiosAutosModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int numeroPuntoVenta { get; set; }
    }
}
