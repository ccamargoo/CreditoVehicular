using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace nombremicroservicio.Repository.Repository.Helpers
{
    public class CsvEjecutivosHelper : CsvMapping<EjecutivoModel>
    {
        public CsvEjecutivosHelper() : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.Identificacion);
            MapProperty(2, x => x.Nombres);
            MapProperty(3, x => x.Apellidos);
            MapProperty(4, x => x.Edad);
            MapProperty(5, x => x.Telefono);
            MapProperty(6, x => x.Celular);
            MapProperty(7, x => x.IdPatio);
        }
    }
}
