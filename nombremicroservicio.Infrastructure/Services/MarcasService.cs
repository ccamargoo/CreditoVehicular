using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Repository.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TinyCsvParser;

namespace nombremicroservicio.Infrastructure.Services
{
    public class MarcasService : IMarcasService
    {
        public readonly IMarcas objRepository;
        public MarcasService(IMarcas obj)
        {
            this.objRepository = obj;
        }
        public void ChargeCsv(string rutaArchivo)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            CsvMarcasHelper csvMapper = new CsvMarcasHelper();
            CsvParser<MarcaModel> csvParser = new CsvParser<MarcaModel>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(@rutaArchivo, Encoding.ASCII).ToList();
            List<MarcaModel> objList = new List<MarcaModel>();
            foreach (var details in result)
            {
                MarcaModel obj = new MarcaModel();
                obj.id = details.Result.id;
                obj.marca = details.Result.marca;
                if (!objList.Any(x => x.marca.Equals(obj.marca)))
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

        public MarcaModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MarcaModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarcaModel Post(MarcaModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool Put(int id, MarcaModel cliente)
        {
            throw new NotImplementedException();
        }
    }
}
