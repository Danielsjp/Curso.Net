using System;
using System.Collections.Generic;
using System.Text;
using GestionAlumnodsdZero.Lib.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;


namespace GestionAlumnodsdZero.Context
{
    public class DbContext
    {

        public static Dictionary<Guid, Student> Students = new Dictionary<Guid, Student>();
        public static Dictionary<string, Student> StudentByDni = new Dictionary<string, Student>();
        public static Dictionary<Guid, asignaturas> Asignaturas = new Dictionary<Guid, asignaturas>();
        public static Dictionary<Guid, exam> Marks = new Dictionary<Guid, exam>();
        public static Dictionary<string, asignaturas> SubjectsByName { get; set; } = new Dictionary<string, asignaturas>();

        public static bool AddStudent(Student student)
        {
            if (student.Id != Guid.Empty)
                return false;

            student.Id = Guid.NewGuid();
            Students.Add(student.Id, student);
            StudentByDni.Add(student.Dni, student);

            return true;
        }

        public static bool AlumoDel(Student student)
        {       
            Students.Remove(student.Id);
            return true;           
        }





    }
}
