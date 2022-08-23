using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace nombremicroservicio.Repository.Repository.Helpers
{
    public class CsvClientesHelper : CsvMapping<ClienteModel>
    {
        public CsvClientesHelper()
    :   base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.Identificacion);
            MapProperty(2, x => x.Nombres);
            MapProperty(3, x => x.Apellidos);
            MapProperty(4, x => x.Edad);
            MapProperty(5, x => x.Telefono);
            MapProperty(6, x => x.FechaNacimiento);
            MapProperty(7, x => x.Direccion);
            MapProperty(8, x => x.EstadoCivil);
            MapProperty(9, x => x.IdentificacionConyuge);
            MapProperty(10, x => x.NombreConyuge);
            MapProperty(11, x => x.SujetoCredito);
        }
    }
}
