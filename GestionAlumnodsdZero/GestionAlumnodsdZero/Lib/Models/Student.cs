using GestionAlumnodsdZero.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GestionAlumnodsdZero.Context;
using GestionAlumnodsdZero.Infraestructura;
namespace GestionAlumnodsdZero
{
    public class Student : Entity
    {

        public string Dni { get; set; }
        public string Name { get; set; }
        public List<exam> Marks { get; set; }
        public Student()
        {
            Marks = new List<exam>();
        }

        public bool AddExam(exam exam)
        {
            exam.Student = this;
            Marks.Add(exam);
            return true;
        }

        public static bool ValidateDni(string dni)
        {
            return !string.IsNullOrEmpty(dni);
        }
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        public SaveResult<Student> Save()
        {
            var saveResult = base.Save<Student>();
            return saveResult;
        }

        //public bool Save()
        //{
        //    var validation = ValidateDni(this.Dni);
        //    if (!validation)
        //        return false;
        //    validation = ValidateName(this.Name);
        //    if (!validation)
        //        return false;
        //    if (this.Id == Guid.Empty)
        //    {
        //        Context.DbContext.AddStudent(this);
        //    }
        //    else
        //    {
        //        Context.DbContext.AddStudent(this);
        //    }
        //    return true;
        //}

        public bool Delete()
        {
            Context.DbContext.AlumoDel(this);

            return true;
        }
    }
}
