using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deportes.API.Domain
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set;  }

        public Producto Producto { get; set; }
        private Guid IdProducto { get; set; }

        public Cliente Cliente { get; set; }
        private Guid IdCliente { get; set; }   
    }
}
