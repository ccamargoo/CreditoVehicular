using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    public class VehiculoModel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int Modelo { get; set; }
        public string NumeroChasis { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Cilindraje { get; set; }
        public decimal Avaluo { get; set; }

    }
}
