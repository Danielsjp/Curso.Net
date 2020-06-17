using System;
using System.Collections.Generic;
using System.Text;

namespace ExVideos.Clases
{
    public class User : Entity
    {
        public string Username;  //propiedad de la clase video o campos de clase 
        public string Name;  //propiedad de la clase video o campos de clase 
        public string Surname;  //propiedad de la clase video o campos de clase
        public string xPassword;  //propiedad de la clase video o campos de clase
        public DateTime Regdate;
    }

    //public bool Chequeo(String dato)
    //{
    //    if (string.IsNullOrEmpty(dato) == true)
    //    {
    //        // True.
    //        Console.WriteLine("Null or empty");
    //        return true;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Not null and not empty");
    //        return true;
    //    }
        
    //}
}
