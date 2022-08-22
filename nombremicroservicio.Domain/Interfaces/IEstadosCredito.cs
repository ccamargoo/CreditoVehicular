using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface IEstadosCredito
    {
        EstadoCreditoModel Get(int id);
        IEnumerable<EstadoCreditoModel> GetAll();
        EstadoCreditoModel Post(EstadoCreditoModel cliente);
        bool Put(int id, EstadoCreditoModel cliente);
        bool Delete(int id);
    }
}
