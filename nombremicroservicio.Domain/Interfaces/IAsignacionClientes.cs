using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IAsignacionClientes
    {
        AsignacionClientesModel Get(int id);
        IEnumerable<AsignacionClientesModel> GetAll();
        AsignacionClientesModel Post(AsignacionClientesModel cliente);
        bool Put(int id, AsignacionClientesModel cliente);
        bool Delete(int id);
    }

    public interface IAsignacionClientesService : IAsignacionClientes { }

}
