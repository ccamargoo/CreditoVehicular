using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class MarcasRepository : IMarcas
    {
        private readonly IGenericRepository<MarcaModel> dataAdapter;
        public MarcasRepository(IGenericRepository<MarcaModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public MarcaModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<MarcaModel> GetAll() => dataAdapter.Get().ToList();

        public MarcaModel Post(MarcaModel estado)
        {
            MarcaModel _obj = dataAdapter.Add(estado);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, MarcaModel estado)
        {
            estado.id = id;
            dataAdapter.Update(estado);
            dataAdapter.Save();
            return true;
        }
    }
}
