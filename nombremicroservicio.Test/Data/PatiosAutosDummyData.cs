using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Test.Data
{
    public class PatiosAutosDummyData
    {
        public static List<PatiosAutosModel> Patios = new List<PatiosAutosModel>()
            {
                new PatiosAutosModel()
                {
                    id = 1,
                    nombre = "Punto 1",
                    direccion = "kra 10 03 24",
                    telefono = "032569589",
                    numeroPuntoVenta = 1
                },
            new PatiosAutosModel()
                {
                    id = 2,
                    nombre = "Punto 2",
                    direccion = "kra 10 03 25",
                    telefono = "032569001",
                    numeroPuntoVenta = 2
                }
            };

        public static PatiosAutosModel Patio = new PatiosAutosModel()
        {
            id = 1,
            nombre = "Punto 1",
            direccion = "kra 10 03 24",
            telefono = "032569589",
            numeroPuntoVenta = 1
        };
    }
}
