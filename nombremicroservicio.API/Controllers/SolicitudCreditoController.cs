using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;

namespace nombremicroservicio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudCreditoController : ControllerBase
    {
        private readonly ISolicitudesCreditoService _service;

        public SolicitudCreditoController(ISolicitudesCreditoService Service)
        {
            _service = Service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SolicitudCreditoModel data)
        {
            SolicitudCreditoModel result = _service.Post(data);
            if (result.id != 0)
            {
                return Ok(result);
            }
            else
            {
                return Conflict(result);
            }
        }
    }
}
