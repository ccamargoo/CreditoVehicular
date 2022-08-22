using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Repository.Repository
{
    public class SolicitudesCreditoRepository : ISolicitudesCredito
    {
        private readonly IGenericRepository<SolicitudCreditoModel> dataAdapter;
        public SolicitudesCreditoRepository(IGenericRepository<SolicitudCreditoModel> _data)
        {
            this.dataAdapter = _data;
        }
        public bool Delete(int id)
        {
            dataAdapter.Delete(id);
            dataAdapter.Save();
            return true;
        }

        public SolicitudCreditoModel Get(int id) => dataAdapter.Get(id);

        public IEnumerable<SolicitudCreditoModel> GetAll() => dataAdapter.Get().ToList();

        public SolicitudCreditoModel Post(SolicitudCreditoModel solicitud)
        {
            SolicitudCreditoModel _obj = dataAdapter.Add(solicitud);
            dataAdapter.Save();
            return _obj;
        }

        public bool Put(int id, SolicitudCreditoModel solicitud)
        {
            solicitud.id = id;
            dataAdapter.Update(solicitud);
            dataAdapter.Save();
            return true;
        }
    }
}
