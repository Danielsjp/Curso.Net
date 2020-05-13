using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAlumnodsdZero.Lib.Models
{
    public class exam : Entity
    {

        public Student Student { get; set; }
        public asignaturas Subject { get; set; }
        public double Mark { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
