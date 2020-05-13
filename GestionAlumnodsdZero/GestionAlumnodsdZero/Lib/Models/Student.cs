using GestionAlumnodsdZero.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
