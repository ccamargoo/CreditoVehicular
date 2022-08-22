using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class PatiosAutosRepository : IPatiosAutos
    {
        private readonly IGenericRepository<PatiosAutosModel> dataAdapter;
        public PatiosAutosRepository(IGenericRepository<PatiosAutosModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public PatiosAutosModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<PatiosAutosModel> GetAll() => dataAdapter.Get().ToList();

        public PatiosAutosModel Post(PatiosAutosModel patio)
        {
            PatiosAutosModel _obj = dataAdapter.Add(patio);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, PatiosAutosModel patio)
        {
            patio.id = id;
            dataAdapter.Update(patio);
            dataAdapter.Save();
            return true;
        }
    }
}
