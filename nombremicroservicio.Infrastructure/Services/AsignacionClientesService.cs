using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Infrastructure.Services
{
    public class AsignacionClientesService : IAsignacionClientesService
    {
        public readonly IAsignacionClientes objRepository;
        public AsignacionClientesService(IAsignacionClientes obj)
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

        public AsignacionClientesModel Get(int id)
        {
            try
            {
                return objRepository.Get(id);
            }
            catch
            {
                return new AsignacionClientesModel();
            }
        }

        public IEnumerable<AsignacionClientesModel> GetAll()
        {
            try
            {
                return objRepository.GetAll();
            }
            catch
            {
                return new List<AsignacionClientesModel>();
            }
        }

        public AsignacionClientesModel Post(AsignacionClientesModel data)
        {
            try
            {
                return objRepository.Post(data);
            }
            catch
            {
                return new AsignacionClientesModel();
            }

        }

        public bool Put(int id, AsignacionClientesModel data)
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
