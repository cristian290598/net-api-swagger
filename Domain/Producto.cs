using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deportes.API.Domain
{
    public class Producto
    {
        public Guid id { get; set; }
        public string Nombre { get; set; }

        public int Precio { get; set; }
    }
}
