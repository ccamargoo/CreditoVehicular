using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblClientes")]
    public class ClienteModel : PersonaModel
    {
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string EstadoCivil { get; set; }
        public string IdentificacionConyuge { get; set; }
        public string NombreConyuge { get; set; }
        public string SujetoCredito { get; set; }
    }
}
