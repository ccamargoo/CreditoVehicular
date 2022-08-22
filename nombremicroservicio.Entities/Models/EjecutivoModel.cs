using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblEjecutivos")]
    public class EjecutivoModel : PersonaModel
    {
        public string Celular { get; set; }
        public int IdPatio { get; set; }

    }
}
