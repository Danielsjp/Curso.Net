using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TiendaFlores.Class
{

    public class Floristeria
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }

        public bool Check1(string r)
        {
            bool flag1 = DbContext.context.tiendas.ContainsValue(r);
            if (!flag1) { return true; }
            else { return false; }
            
        }
    }
}
    