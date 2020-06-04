using System;
using System.Collections.Generic;
using System.Text;
using GestionAlumnodsdZero.Lib.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Security.Cryptography.X509Certificates;

namespace GestionAlumnodsdZero.Context
{
    public class DbContext
    {

        public static Dictionary<Guid, Student> Students = new Dictionary<Guid, Student>();       
        public static Dictionary<Guid, asignaturas> Asignaturas = new Dictionary<Guid, asignaturas>();
        public static Dictionary<Guid, exam> Marks = new Dictionary<Guid, exam>();

        public static Dictionary<string, Student> StudentByDni = new Dictionary<string, Student>();
        public static Dictionary<string, asignaturas> SubjectsByName { get; set; } = new Dictionary<string, asignaturas>();

        public static bool AddStudent(Student student)
        {
            //if (student.Id != Guid.Empty)
            //    return false;

            //student.Id = Guid.NewGuid();
            Students.Add(student.Id, student);
            StudentByDni.Add(student.Dni, student);

            return true;
        }

        public static bool AlumoDel(Student student)
        {       
            Students.Remove(student.Id);
            return true;           
        }


        public static void addasigna(asignaturas listaasignaturas)
        {
        
            
            Asignaturas.Add(listaasignaturas.Id, listaasignaturas);
            
        }
        public static void delasigna(asignaturas listaasignaturas)
        {


            Asignaturas.Remove(listaasignaturas.Id);


        }


        public static void ShowAllStudents()
        {
            Console.WriteLine("dasdas");
            //foreach (var student in Context.DbContext.Students.Values)
            //{
            //    Console.WriteLine($"{student.Dni} /./ {student.Name}");                
            //}            
        }

    }
}
