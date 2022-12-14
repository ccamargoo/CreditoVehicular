using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Test.Data
{
    public static class ClientesDummyData
    {

        public static List<ClienteModel> Clientes = new List<ClienteModel>()
            {
                new ClienteModel()
                {
                    Id = 1,
                    Identificacion = "123456",
                    Nombres = "Andres Alberto",
                    Apellidos = "Ejemplo1 Ejemplo2",
                    Edad = 30,
                    Telefono = "+573003174328",
                    FechaNacimiento = "24/08/1991",
                    Direccion = "Direccion de ejemplo",
                    EstadoCivil = "Soltero",
                    IdentificacionConyuge = "00000000000",
                    NombreConyuge = "Ejemplo3"


                },
            new ClienteModel()
                {
                    Id = 2,
                    Identificacion = "123456",
                    Nombres = "Andres Alberto",
                    Apellidos = "Ejemplo1 Ejemplo2",
                    Edad = 45,
                    Telefono = "+573003174328",
                    FechaNacimiento = "24/08/1991",
                    Direccion = "Direccion de ejemplo",
                    EstadoCivil = "Soltero",
                    IdentificacionConyuge = "00000000000",
                    NombreConyuge = "Ejemplo3"


                }
            };

        public static ClienteModel Cliente = new ClienteModel()
        {
            Id = 1,
            Identificacion = "123456",
            Nombres = "Andres Alberto",
            Apellidos = "Ejemplo1 Ejemplo2",
            Edad = 30,
            Telefono = "+573003174328",
            FechaNacimiento = "24/08/1991",
            Direccion = "Direccion de ejemplo",
            EstadoCivil = "Soltero",
            IdentificacionConyuge = "00000000000",
            NombreConyuge = "Ejemplo3"
        };

    }
}
