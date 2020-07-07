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
        public static Dictionary<Guid, String> tiendas = new Dictionary<Guid, String>();
        public static Dictionary<Guid, Flor> flor = new Dictionary<Guid, Flor>();
        public static Dictionary<Guid, Decorations> decorations = new Dictionary<Guid, Decorations>();
        public static Dictionary<Guid, Arbol> arbol = new Dictionary<Guid, Arbol>();
    }
}
