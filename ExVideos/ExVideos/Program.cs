using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;


namespace ExVideos
{
    class Program
    {

        public static Dictionary<string, User> usuariosvideoclub = new Dictionary<string, User>();
        public static Dictionary<string, Video> videos = new Dictionary<string, Video>();
        public static Dictionary<string, Video> videosusuario = new Dictionary<string, Video>();

        static void Main(string[] args)
        {

            nuevoUsuario();

            static void nuevoUsuario()
            {
                Console.WriteLine("Escriba Nombre Usuario Nuevo");
                var user = Console.ReadLine();
                Console.WriteLine("Escriba Nombre Nuevo");
                var name = Console.ReadLine();
                Console.WriteLine("Escriba Apellido Usuario Nuevo");
                var surname = Console.ReadLine();
                Console.WriteLine("Escriba Password Usuario Nuevo");
                var pass = Console.ReadLine();
                var nuevouser = new User
                {
                    Username = user,
                    Name = name,
                    Surname = surname,
                    xPassword = pass,
                    Regdate = DateTime.Now
                };
                usuariosvideoclub.Add(nuevouser.Username, nuevouser);
                menuprincipal();
            }
            static void verusuarios()
            {
                foreach (var usuarios in usuariosvideoclub.Values)
                {
                    Console.WriteLine(usuarios.Username + "" + usuarios.Surname);
                }
                menuprincipal();
            }
            //static void addvideo()
            //{
            //    Console.WriteLine("Escriba url video");
            //    var url = Console.ReadLine();
            //    Console.WriteLine("Escriba Nombre video");
            //    var title = Console.ReadLine();
            //    Console.WriteLine("Escriba Tags");
            //    var tags = Console.ReadLine();
            //    var nuevovideo = new Video
            //    {
            //        Url = url,
            //        Title = title,
            //        Tags = tags
            //    };

            //    menuprincipal();
            //}
            static void menuprincipal()
            {
                Console.WriteLine("Bienvenido al Video Club");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Para menu usuario escriba usuario");
                Console.WriteLine("Para ver usuarios escriba ver");
                Console.WriteLine("Para ver videos de usuarios escriba videos");
                //Console.WriteLine("Para añadir video escriba usuario");
                var opcion = Console.ReadLine();
                var continua = true;
                while (continua)
                {
                    if (opcion == "usuario")
                    {
                        Console.WriteLine("Escriba Nuevo para Nuevo Usuario o Enter Para Nuevo Video");
                        opcion = Console.ReadLine();
                        if (opcion == "nuevo") nuevoUsuario();
                        else
                        {
                            alquiler();
                        }

                    }
                    if (opcion == "ver")
                    {
                        verusuarios();
                        menuprincipal();
                    }
                    if (opcion == "videos")
                    {
                        vervideos();

                    }
                    //if (opcion == "video")
                    //{
                    //    addvideo();
                    //}
                }

                static void alquiler()
                {

                    Console.WriteLine("Indique Usuario");
                    var usuario = Console.ReadLine();
                    if (usuariosvideoclub.ContainsKey(usuario))
                    {
                        Console.WriteLine("El usuario va a crear un nuevo video");
                        Console.WriteLine("indique nombre video");
                        var title = Console.ReadLine();
                        Console.WriteLine("indique url video");
                        var url = Console.ReadLine();
                        Console.WriteLine("indique tag video");
                        var tags = Console.ReadLine();
                        var nuevovideo = new Video
                        {
                            Url = url,
                            Title = title,
                            Tags = tags
                        };
                        videos.Add(nuevovideo.Title, nuevovideo);

                        videosusuario.Add(usuario, nuevovideo.Title);
                        menuprincipal();

                    }
                    else Console.WriteLine("no existe el usuario");
                }
            }

            static void vervideos()
            {
                //foreach (var usuarios in usuariosvideoclub.Values)
                //{
                //    foreach (var video in videosusuario.Values)
                //    {
                //        if (videosusuario.ContainsKey(usuarios.Name))
                //        {

                //            Console.WriteLine(usuarios.Name + "//" + video.Title);
                //        }
                //    }
                //}

                //    Console.WriteLine("inserte usuario");
                //    var usuario = Console.ReadLine();
                //    foreach (var usuario in videosusuario.Values)
                //    {
                //        Console.WriteLine($"El usuario {usuario} tiene las siguientes peliculas:");
                //        foreach (var datos in videosusuario.Values)
                //        {
                //         //Console.WriteLine(videosusuario.);
                //        }
                //    }
                //}

                //static void addvideo()
                //{
                //    Console.WriteLine("Escriba url video");
                //    var url = Console.ReadLine();
                //    Console.WriteLine("Escriba Nombre video");
                //    var title = Console.ReadLine();
                //    Console.WriteLine("Escriba Tags");
                //    var tags = Console.ReadLine();
                //    var nuevovideo = new Video
                //    {
                //        Url = url,
                //        Title = title,
                //        Tags = tags
                //    };
                //}

            }
        }

        public class Video
        {
            public string Url;  //propiedad de la clase video o campos de clase 
            public string Title;  //propiedad de la clase video o campos de clase 
            public string Tags;  //propiedad de la clase video o campos de clase 
        }
        public class User
        {
            public string Username;  //propiedad de la clase video o campos de clase 
            public string Name;  //propiedad de la clase video o campos de clase 
            public string Surname;  //propiedad de la clase video o campos de clase
            public string xPassword;  //propiedad de la clase video o campos de clase
            public DateTime Regdate;

            //public bool AddVideo(Video )
            //{
            //    exam.Student = this;
            //    Marks.Add(exam);
            //    return true;
            //}
        }
        //public class Alquiler
        //{
        //    public string Username;  //propiedad de la clase video o campos de clase 
        //    public string Video; //propiedad de la clase video o campos de clase 
        //    public DateTime Regdate;

        //    //public bool AddVideo(Video )
        //    //{
        //    //    exam.Student = this;
        //    //    Marks.Add(exam);
        //    //    return true;
        //    //}
        //}

    }
}




