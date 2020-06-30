using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaFlores.Class;
namespace TiendaFlores.DbContext
{
    public class context
    {
        public static Dictionary<Guid, Floristeria> Tiendas = new Dictionary<Guid, Floristeria>();
    }
}
