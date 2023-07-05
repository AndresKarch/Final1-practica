using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido, ingrese datos para crear su primer programa");
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese fecha inicio");
            DateTime fecha_inicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese categoria");
            string categoria = Console.ReadLine();
            Console.WriteLine("Ingrese dias emision");
            string dias_emision = Console.ReadLine();
            Console.WriteLine("Ingrese hora inicio");
            string hora_inicio = Console.ReadLine();
            Console.WriteLine("Ingrese hora finalizacion");
            string hora_finalizacion = Console.ReadLine();
            Console.WriteLine("Ingrese plataforma");
            string plataforma = Console.ReadLine();
            int codigo = 0;
            switch (plataforma)
            {
                case "internet":
                    string stop = "";
                    Console.WriteLine("Ingrese dias emision");
                    List<string> dias = new List<string>(); 
                    while (stop == "")
                    {
                        dias.Add(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese titulo");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Ingrese nombre del manager");
                    string manager = Console.ReadLine();
                    internet Internet = new internet(codigo, nombre, fecha_inicio, categoria, dias_emision, hora_inicio, hora_finalizacion, plataforma, dias, titulo, manager);
                    Internet.crear(Internet);
                    break;
            }


        }
    }
}
