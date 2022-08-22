using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblSolicitudCredito")]
    public class SolicitudCreditoModel
    {
        public int id { get; set; }
        public int idCredito { get; set; }
        public int idPatio { get; set; }
        public int idEjecutivo { get; set; }
        public int idVehiculo { get; set; }
        public int estado { get; set; }
        public DateTime fechaElaboracion { get; set; }
        public decimal plazoMeses { get; set; }
        public int cuotas { get; set; }
        public DateTime entrada { get; set; }
        public string observacion { get; set; }
    }
}
