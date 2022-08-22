using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    public class EjecutivoModel : PersonaModel
    {
        public string Celular { get; set; }
        public int IdPatio { get; set; }

    }
}
