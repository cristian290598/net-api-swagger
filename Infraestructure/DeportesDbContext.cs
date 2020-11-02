using Deportes.API.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deportes.API.Infraestructure
{
    public class DeportesDbContext: DbContext
    {
        public DeportesDbContext(DbContextOptions<DeportesDbContext>options)
            :base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
