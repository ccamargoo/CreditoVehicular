using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblAsignacionClientes")]
    public class AsignacionClientesModel
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idPatio { get; set; }
        public DateTime? fechaAsignacion { get; set; }
    }
}
