using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Infrastructure.Services
{
    public class SolicitudesCreditoService
    {
        public readonly ISolicitudesCredito objRepository;
        public SolicitudesCreditoService(ISolicitudesCredito obj)
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

        public SolicitudCreditoModel Get(int id)
        {
            try
            {
                return objRepository.Get(id);
            }
            catch
            {
                return new SolicitudCreditoModel();
            }
        }

        public IEnumerable<SolicitudCreditoModel> GetAll()
        {
            try
            {
                return objRepository.GetAll();
            }
            catch
            {
                return new List<SolicitudCreditoModel>();
            }
        }

        public SolicitudCreditoModel Post(SolicitudCreditoModel data)
        {
            try
            {
                return objRepository.Post(data);
            }
            catch
            {
                return new SolicitudCreditoModel();
            }

        }

        public bool Put(int id, SolicitudCreditoModel data)
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
