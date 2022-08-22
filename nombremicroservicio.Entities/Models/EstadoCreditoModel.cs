using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblEstadosCredito")]
    public class EstadoCreditoModel
    {
        public int id { get; set; }
        public string estado { get; set; }
    }
}
