using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace nombremicroservicio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculosService _service;

        public VehiculosController(IVehiculosService Service)
        {
            _service = Service;
        }

        public IActionResult Get(int id)
        {
            VehiculoModel obj = _service.Get(id);
            if (obj.Id != 0)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(obj);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<VehiculoModel> obj = _service.GetAll();
            if (obj.Any())
            {
                return Ok(obj);
            }
            else
            { return NotFound(obj); }
        }

        [HttpPost]
        public IActionResult Post([FromBody] VehiculoModel data)
        {
            VehiculoModel result = _service.Post(data);
            if (result.Id != 0)
            {
                return Ok(result);
            }
            else
            {
                return Conflict(result);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] VehiculoModel data)
        {
            if (_service.Put(id, data))
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _service.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(result);
            }
        }

    }
}
