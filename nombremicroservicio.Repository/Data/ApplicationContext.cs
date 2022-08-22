using Microsoft.EntityFrameworkCore;
using nombremicroservicio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace nombremicroservicio.Repository.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<AsignacionClientesModel> AsignacionClientes { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<EjecutivoModel> Ejecutivos { get; set; }
        public DbSet<EstadoCreditoModel> Estados { get; set; }
        public DbSet<MarcaModel> Marcas { get; set; }
        public DbSet<PatiosAutosModel> PatiosAutos { get; set; }
        public DbSet<SolicitudCreditoModel> SolicitudesCredito { get; set; }
        public DbSet<VehiculoModel> Vehiculos { get; set; }
    }
}
