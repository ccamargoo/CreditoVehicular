using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace nombremicroservicio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IClientesService _clientesService;

        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        public IActionResult Get(int id)
        {
            ClienteModel obj = _clientesService.Get(id);
            if(obj.Id != 0)
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
            IEnumerable<ClienteModel> obj = _clientesService.GetAll();
            if (obj.Any())
            {
                return Ok(obj);
            }
            else
            { return NotFound(obj); }
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteModel data)
        {
            ClienteModel result = _clientesService.Post(data);
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
        public IActionResult Put(int id, [FromBody] ClienteModel data)
        {
            if (_clientesService.Put(id, data))
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
            bool result = _clientesService.Delete(id);
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
