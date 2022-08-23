using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
    }
}
