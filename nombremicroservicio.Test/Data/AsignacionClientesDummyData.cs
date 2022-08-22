using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Test.Data
{
    public class AsignacionClientesDummyData
    {
        public static List<AsignacionClientesModel> Asignaciones = new List<AsignacionClientesModel>()
            {
                new AsignacionClientesModel()
                {
                    id = 1,
                    idCliente = 1,
                    idPatio = 1,
                    fechaAsignacion = DateTime.Parse("2022-08-05")
                },
            new AsignacionClientesModel()
                {
                    id = 2,
                    idCliente = 1,
                    idPatio = 1,
                    fechaAsignacion = DateTime.Parse("2022-08-19")
                }
            };

        public static AsignacionClientesModel Asignacion = new AsignacionClientesModel()
        {
            id = 1,
            idCliente = 1,
            idPatio = 1,
            fechaAsignacion = DateTime.Parse("2022-08-19")
        };
    }
}
