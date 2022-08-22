using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Threading.Tasks;

namespace nombremicroservicio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjecutivosController : ControllerBase
    {
        private readonly IEjecutivos _ejecutivosService;

        public EjecutivosController(IEjecutivos ejecutivosService)
        {
            _ejecutivosService = ejecutivosService;
        }

        public async Task<IActionResult> GetAll()
        {
            return null;
        }

        public async Task<IActionResult> Get(int id)
        {
            return null;
        }
        public Task<IActionResult> Post(EjecutivoModel ejecutivo)
        {
            return null;
        }

        public async Task<IActionResult> Delete(int id)
        {
            return null;
        }

        public async Task<IActionResult> Put(int id, EjecutivoModel ejecutivo)
        {
            return null;
        }


    }
}
