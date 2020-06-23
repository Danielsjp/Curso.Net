using System;
using System.Collections.Generic;
using System.Text;

namespace Rockets.Models
{
    public class Propulsor : xRockets
    {
        public string Rocket { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int actualPot { get; set; }
        public int maxPot { get; set; }
    }
}
