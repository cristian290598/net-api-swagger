using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Deportes.API.Domain;
using Deportes.API.Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Deportes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private DeportesDbContext _dbContext;

        public ProductosController(DeportesDbContext dbContext)
        {
            _dbContext = dbContext;   

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {

            return await _dbContext.Productos.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> Create(
            [FromBody] Producto producto)
        {

            _dbContext.Productos.Add(producto);
            await _dbContext.SaveChangesAsync();

            return StatusCode(201, producto);
        }

    }
}
