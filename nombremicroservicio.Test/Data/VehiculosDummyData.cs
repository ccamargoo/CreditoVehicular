using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Test.Data
{
    public class VehiculosDummyData
    {
        public static List<VehiculoModel> Vehiculos = new List<VehiculoModel>()
            {
                new VehiculoModel()
                {
            Id = 1,
            Placa = "jfr589",
            Modelo = 2022,
            NumeroChasis = "adsf5154asdf",
            Marca = "REANULT",
            Tipo = "HATSHBACK",
            Cilindraje = "1.6",
            Avaluo = 0


                },
            new VehiculoModel()
                {
            Id = 2,
            Placa = "zzz589",
            Modelo = 2012,
            NumeroChasis = "ad54asdf",
            Marca = "REANULT",
            Tipo = "HIBRYD",
            Cilindraje = "NA",
            Avaluo = 0


                }
            };

        public static VehiculoModel Vehiculo = new VehiculoModel()
        {
            Id = 1,
            Placa = "jfr589",
            Modelo = 2022,
            NumeroChasis = "adsf5154asdf",
            Marca = "REANULT",
            Tipo = "HATSHBACK",
            Cilindraje = "1.6",
            Avaluo = 0
        };
    }
}
