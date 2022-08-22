using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Infrastructure.Services
{
    public class VehiculosService : IVehiculosService
    {
        public readonly IVehiculos objRepository;
        public VehiculosService(IVehiculos obj)
        {
            this.objRepository = obj;
        }
        public bool Delete(int id)
        {
            try
            {
                if (objRepository.Get(id).Id != 0)
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

        public VehiculoModel Get(int id)
        {
            try
            {
                return objRepository.Get(id);
            }
            catch
            {
                return new VehiculoModel();
            }
        }

        public IEnumerable<VehiculoModel> GetAll()
        {
            try
            {
                return objRepository.GetAll();
            }
            catch
            {
                return new List<VehiculoModel>();
            }
        }

        public VehiculoModel Post(VehiculoModel data)
        {
            try
            {
                return objRepository.Post(data);
            }
            catch
            {
                return new VehiculoModel();
            }

        }

        public bool Put(int id, VehiculoModel data)
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
