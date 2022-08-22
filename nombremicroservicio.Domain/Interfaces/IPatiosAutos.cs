using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IPatiosAutos
    {
        PatiosAutosModel Get(int id);
        IEnumerable<PatiosAutosModel> GetAll();
        PatiosAutosModel Post(PatiosAutosModel cliente);
        bool Put(int id, PatiosAutosModel cliente);
        bool Delete(int id);
    }

    public interface IPatiosAutosService : IPatiosAutos { }
}
