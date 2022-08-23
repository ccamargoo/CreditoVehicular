using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using nombremicroservicio.Repository.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TinyCsvParser;

namespace nombremicroservicio.Infrastructure.Services
{
    public class ClientesService : IClientesService
    {
        public readonly IClientes objRepository;
        public ClientesService(IClientes obj)
        {
            this.objRepository = obj;
        }

        public void ChargeCsv(string rutaArchivo)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
            CsvClientesHelper csvMapper = new CsvClientesHelper();
            CsvParser<ClienteModel> csvParser = new CsvParser<ClienteModel>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(rutaArchivo, Encoding.ASCII).ToList();
            List<ClienteModel> objList = new List<ClienteModel>();
            foreach (var details in result)
            {
                ClienteModel obj = new ClienteModel();
                obj.Id = details.Result.Id;
                obj.Identificacion = details.Result.Identificacion;
                obj.Nombres = details.Result.Nombres;
                obj.Apellidos = details.Result.Apellidos;
                obj.Edad = details.Result.Edad;
                obj.Telefono = details.Result.Telefono;
                obj.FechaNacimiento = details.Result.FechaNacimiento;
                obj.Direccion = details.Result.Direccion;
                obj.EstadoCivil = details.Result.EstadoCivil;
                obj.IdentificacionConyuge = details.Result.IdentificacionConyuge;
                obj.NombreConyuge = details.Result.NombreConyuge;
                obj.SujetoCredito = details.Result.SujetoCredito;
                if (!objList.Any(x => x.Identificacion.Equals(obj.Identificacion)))
                {
                    objRepository.Post(obj);
                    objList.Add(obj);
                }

            }
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

        public ClienteModel Get(int id)
        {
            try
            {
                return objRepository.Get(id);
            }
            catch
            {
                return new ClienteModel();
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            try
            {
                return objRepository.GetAll();
            }
            catch
            {
                return new List<ClienteModel>();
            }
        }

        public ClienteModel Post(ClienteModel data)
        {
            try
            {
                return objRepository.Post(data);
            }
            catch
            {
                return new ClienteModel();
            }

        }

        public bool Put(int id, ClienteModel data)
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
