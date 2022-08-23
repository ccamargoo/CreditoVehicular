using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Repository.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;

namespace nombremicroservicio.Infrastructure.Services
{
    internal class EjecutivosService : IEjecutivosService
    {
        public readonly IEjecutivos objRepository;
        public EjecutivosService(IEjecutivos obj)
        {
            this.objRepository = obj;
        }
        public void ChargeCsv(string rutaArchivo)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            CsvEjecutivosHelper csvMapper = new CsvEjecutivosHelper();
            CsvParser<EjecutivoModel> csvParser = new CsvParser<EjecutivoModel>(csvParserOptions, (TinyCsvParser.Mapping.ICsvMapping<EjecutivoModel>)csvMapper);
            var result = csvParser
                         .ReadFromFile(@rutaArchivo, Encoding.ASCII).ToList();
            List<EjecutivoModel> objList = new List<EjecutivoModel>();
            foreach (var details in result)
            {
                EjecutivoModel obj = new EjecutivoModel();
                obj.Id = details.Result.Id;
                obj.Identificacion = details.Result.Identificacion;
                obj.Nombres = details.Result.Nombres;
                obj.Apellidos = details.Result.Apellidos;
                obj.Edad = details.Result.Edad;
                obj.Telefono = details.Result.Telefono;
                obj.Celular = details.Result.Celular;
                obj.IdPatio = details.Result.IdPatio;
                if (!objList.Any(x => x.Identificacion.Equals(obj.Identificacion)))
                {
                    objRepository.Post(obj);
                    objList.Add(obj);
                }
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public EjecutivoModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EjecutivoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EjecutivoModel Post(EjecutivoModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool Put(int id, EjecutivoModel cliente)
        {
            throw new NotImplementedException();
        }
    }
}
