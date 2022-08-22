using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class EstadosCreditoRepository : IEstadosCredito
    {
        private readonly IGenericRepository<EstadoCreditoModel> dataAdapter;
        public EstadosCreditoRepository(IGenericRepository<EstadoCreditoModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public EstadoCreditoModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<EstadoCreditoModel> GetAll() => dataAdapter.Get().ToList();

        public EstadoCreditoModel Post(EstadoCreditoModel estado)
        {
            EstadoCreditoModel _obj = dataAdapter.Add(estado);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, EstadoCreditoModel estado)
        {
            estado.id = id;
            dataAdapter.Update(estado);
            dataAdapter.Save();
            return true;
        }
    }
}
