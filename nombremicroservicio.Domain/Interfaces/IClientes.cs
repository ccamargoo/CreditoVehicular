using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IClientes
    {
        ClienteModel Get(int id);
        IEnumerable<ClienteModel> GetAll();
        ClienteModel Post(ClienteModel cliente);
        bool Put(int id, ClienteModel cliente);
        bool Delete(int id);
        
    }

    public interface IClientesService : IClientes {
        void ChargeCsv(string rutaArchivo);
    }
}
