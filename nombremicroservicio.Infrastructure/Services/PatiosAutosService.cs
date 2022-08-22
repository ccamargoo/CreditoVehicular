using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Infrastructure.Services
{
    public class PatiosAutosService : IPatiosAutosService
    {
        public readonly IPatiosAutos objRepository;
        public PatiosAutosService(IPatiosAutos obj)
        {
            this.objRepository = obj;
        }
        public bool Delete(int id)
        {
            try
            {
                if (objRepository.Get(id).id != 0)
                {
                    return objRepository.Delete(id);
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public PatiosAutosModel Get(int id)
        {
            try
            {
                return objRepository.Get(id);
            }
            catch
            {
                return new PatiosAutosModel();
            }
        }

        public IEnumerable<PatiosAutosModel> GetAll()
        {
            try
            {
                return objRepository.GetAll();
            }
            catch
            {
                return new List<PatiosAutosModel>();
            }
        }

        public PatiosAutosModel Post(PatiosAutosModel data)
        {
            try
            {
                return objRepository.Post(data);
            }
            catch
            {
                return new PatiosAutosModel();
            }

        }

        public bool Put(int id, PatiosAutosModel data)
        {
            try
            {
                return objRepository.Put(id, data);
            }
            catch
            {
                return false;
            }

        }
    }
}
