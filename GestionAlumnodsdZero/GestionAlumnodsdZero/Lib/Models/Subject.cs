using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAlumnodsdZero.Lib.Models
{
    public class asignaturas : Entity
    {
        public string Asignatura { get; set; }
        public string Profesor { get; set; }

        public bool Save()
        {
          
            if (this.Id == Guid.Empty)
            {
                Context.DbContext.addasigna(this);
            }
            else
            {
                Context.DbContext.addasigna(this);
            }
            return true;
        }
    }
}
