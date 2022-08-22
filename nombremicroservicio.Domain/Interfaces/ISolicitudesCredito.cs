using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombremicroservicio.Domain.Interfaces
{
    public interface ISolicitudesCredito
    {
        SolicitudCreditoModel Get(int id);
        IEnumerable<SolicitudCreditoModel> GetAll();
        SolicitudCreditoModel Post(SolicitudCreditoModel cliente);
        bool Put(int id, SolicitudCreditoModel cliente);
        bool Delete(int id);
    }

    public interface ISolicitudesCreditoService : ISolicitudesCredito { }
}
