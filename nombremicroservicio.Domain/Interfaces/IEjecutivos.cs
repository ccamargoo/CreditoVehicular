using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IEjecutivos
    {
        EjecutivoModel Get(int id);
        IEnumerable<EjecutivoModel> GetAll();
        EjecutivoModel Post(EjecutivoModel cliente);
        bool Put(int id, EjecutivoModel cliente);
        bool Delete(int id);
    }

    public interface IEjecutivosService : IEjecutivos {
        void ChargeCsv(string rutaArchivo);
    }
}
