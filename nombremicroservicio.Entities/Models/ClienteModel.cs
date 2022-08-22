﻿using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    public class ClienteModel : PersonaModel
    {
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string EstadoCivil { get; set; }
        public string IdentificacionConyugue { get; set; }
        public string NombreConyuge { get; set; }
        public string SujetoCredito { get; set; }
    }
}