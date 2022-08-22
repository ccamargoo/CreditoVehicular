using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Test.Data
{
    public class SolicitudCreditoDummyData
    {
        public static SolicitudCreditoModel solicitudCredito = new SolicitudCreditoModel()
        {
            id = 1,
            idCredito = 123456,
            idPatio = 1,
            idEjecutivo = 1,
            idVehiculo = 1,
            estado = 1,
            fechaElaboracion = Convert.ToDateTime("2022-08-05"),
            plazoMeses = 5,
            cuotas = 2,
            entrada = Convert.ToDateTime("2022-08-05"),
            observacion = "",
        };
    }
}
