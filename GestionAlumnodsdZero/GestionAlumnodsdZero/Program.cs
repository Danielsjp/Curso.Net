using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using GestionAlumnodsdZero.Lib.Models;
using GestionAlumnodsdZero.Context;

namespace GestionAlumnodsdZero
{
    class Program
    {
        static void Main(string[] args)
        {


 

            #region menu
            Console.WriteLine(">Bienvenido al gestor de alumnos<");
            Console.WriteLine("Escriba add para añadir alumnos");
            Console.WriteLine("Escriba asigna para añadir asignaturas");
            Console.WriteLine("Escriba nota para añadir notas");
            Console.WriteLine("Escriba show para ver alumnos"); 
            #endregion
            
            var opcion = Console.ReadLine();
            var continua = true;
            while (continua)
            {
                if (opcion == "add")
                {
                    menualumno();
                }
                if (opcion == "show")
                {
                    ShowAllStudents();
                }
                if (opcion == "asigna")
                {
                    addasigna();
                }
                if (opcion == "nota")
                {
                    addnota();
                }

            }
            static void menualumno()
            {
                Console.WriteLine("Introduzca Nombre Alumno");
                var name = Console.ReadLine();
                Console.WriteLine("Introduzca DNI Alumno");
                var dni = Console.ReadLine();
                var student = new Student
                {
                   
                    Dni = dni,
                    Name = name
                };
                student.Save();
                menuprincipal();
            }

            static void addasigna()
            {
                Console.WriteLine("Introduzca Asignatura Alumno");
                var asigna = Console.ReadLine();
                Console.WriteLine("Introduzca Profesor Alumno");
                var profe = Console.ReadLine();
                var listaasignaturas = new asignaturas
                {
                    Id = Guid.NewGuid(),
                    Asignatura = asigna,
                    Profesor = profe
                };
                Context.DbContext.Asignaturas.Add(listaasignaturas.Id, listaasignaturas);
                menuprincipal();
            }
            static void menualumnodel()
            {
                Console.WriteLine("introduce nombre del alumno");
                var alumno = Console.ReadLine();
                foreach (var student in Context.DbContext.Students.Values)
                {
                    if (student.Name == alumno)
                    {
                        Context.DbContext.Students.Remove(student.Id);
                        menuprincipal();
                    }
                    else { Console.WriteLine("NO EXISTE"); menuprincipal(); }
                }
                menuprincipal();
            }
            static void menuprincipal()
            {
                Console.WriteLine("Bienvenido al gestor de alumnos");
                Console.WriteLine("Escriba add para añadir alumnos");
                Console.WriteLine("Escriba show para ver alumnos");
                Console.WriteLine("Escriba del para borrar alumnos");
                Console.WriteLine("Escriba edit para edit alumnos");
                Console.WriteLine("Escriba asigna para añadir asignaturas");
                Console.WriteLine("Escriba nota para añadir notas");
                Console.WriteLine("Escriba shownota");
                Console.WriteLine("Escriba showasigna para ver asignaturas");
                var opcion = Console.ReadLine();
                var continua = true;
                while (continua)
                {
                    if (opcion == "add")
                    {
                        menualumno();
                    }
                    if (opcion == "show")
                    {
                        ShowAllStudents();
                        break;
                    }
                    if (opcion == "edit")
                    {
                        editaralumno();
                        break;
                    }
                    if (opcion == "del")
                    {
                        menualumnodel();
                    }
                    if (opcion == "showasigna")
                    {
                        Showmenuasigna();
                    }
                    if (opcion == "asigna")
                    {
                        addasigna();
                    }
                    if (opcion == "nota")
                    {
                        addnota();
                    }
                    if (opcion == "shownota")
                    {
                        shownota();
                    }
                }
            }
            static void ShowAllStudents()
            {
                foreach (var student in Context.DbContext.Students.Values)
                {
                    Console.WriteLine($"{student.Dni} // {student.Name}");
                }

                menuprincipal();
            }
            static void shownota()
            {
                foreach (var loquesea in Context.DbContext.Marks.Values)
                {
                    Console.WriteLine(loquesea.Mark + " // " + loquesea.Student.Name + " // " + loquesea.Subject.Asignatura);
                }
                menuprincipal();
            }
            static void Showmenuasigna()
            {
                foreach (var asigna in Context.DbContext.Asignaturas.Values)
                {
                    Console.WriteLine($"{asigna.Asignatura} {asigna.Profesor}");
                }
                menuprincipal();
            }
            static void editaralumno()
            {
                Console.WriteLine("introduce nombre del alumno");
                var alumno = Console.ReadLine();
                foreach (var student in Context.DbContext.Students.Values)
                {
                    if (student.Name == alumno)
                    {
                        Console.WriteLine("nuevo nombre");
                        var nuevonombre = Console.ReadLine();
                        student.Name = nuevonombre;
                        menuprincipal();
                    }
                    else { Console.WriteLine("NO EXISTE"); menuprincipal(); }
                }
            }
            static void addnota()
            {
                Console.WriteLine("Enter a student dni or write ESC to exit:");
                var dni = Console.ReadLine();
                Console.WriteLine("Enter the subject or write ESC to exit:");
                var subjName = Console.ReadLine();
                var mark = 5;
                var student = Context.DbContext.Students.Values.FirstOrDefault(x => x.Dni == dni);
                var subject = Context.DbContext.Asignaturas.Values.FirstOrDefault(x => x.Asignatura == subjName);
                var exam = new exam
                {
                    Id = Guid.NewGuid(),
                    Mark = mark,
                    Student = student,
                    Subject = subject,
                    TimeStamp = DateTime.Now
                };

                Context.DbContext.Marks.Add(exam.Id, exam);
                //student.AddExam(Exams[exam.Id]);
               
                    Console.WriteLine("la nota"+mark+"ha sido añadida para el estudiante"+student.Name);
                
            }
        }       
        
    }
}



