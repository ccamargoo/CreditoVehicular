using nombremicroservicio.Domain.Interfaces;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Infrastructure.Services
{
    public class ClientesService : IClientes
    {
        public readonly IClientes objRepository;
        public ClientesService(IClientes obj)
        {
            this.objRepository = obj;
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
