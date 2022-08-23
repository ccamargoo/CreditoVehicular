using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IMarcas
    {
        MarcaModel Get(int id);
        IEnumerable<MarcaModel> GetAll();
        MarcaModel Post(MarcaModel cliente);
        bool Put(int id, MarcaModel cliente);
        bool Delete(int id);
    }
    public interface IMarcasService : IMarcas {
        void ChargeCsv(string rutaArchivo);
    }
}
