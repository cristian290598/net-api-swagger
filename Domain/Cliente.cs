using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deportes.API.Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}
