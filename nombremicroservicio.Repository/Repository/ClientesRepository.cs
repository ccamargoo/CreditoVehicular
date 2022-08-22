using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class ClientesRepository : IClientes
    {
        private readonly IGenericRepository<ClienteModel> dataAdapter;
        public ClientesRepository(IGenericRepository<ClienteModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public ClienteModel Get(int id) => dataAdapter.Get(id);
        
        public IEnumerable<ClienteModel> GetAll() => dataAdapter.Get().ToList();
        
        public ClienteModel Post(ClienteModel cliente)
        {
            ClienteModel _obj = dataAdapter.Add(cliente);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, ClienteModel cliente)
        {
            cliente.Id = id;
            dataAdapter.Update(cliente);
            dataAdapter.Save();
            return true;
        }
    }
}
