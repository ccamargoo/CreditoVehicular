using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace nombremicroservicio.Repository.Repository.Helpers
{
    public class CsvMarcasHelper : CsvMapping<MarcaModel>
    {
        public CsvMarcasHelper() : base()
        {
            MapProperty(0, x => x.id);
            MapProperty(1, x => x.marca);
        }
    }
}
