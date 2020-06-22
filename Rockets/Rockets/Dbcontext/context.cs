using System;
using System.Collections.Generic;
using System.Text;
using Rockets.Models;

namespace Rockets.Dbcontext
{
    public class context
    {
        public static Dictionary<Guid, xRockets> Rocket = new Dictionary<Guid, xRockets>();
        public static Dictionary<Guid, Propulsor> Propul = new Dictionary<Guid, Propulsor>();
    }
}
