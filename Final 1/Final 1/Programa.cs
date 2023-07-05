using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Final_1
{
    public abstract class Programa
    {
        int codigo_programa {  get; set; }
        string nombre_programa { get; set; }
        DateTime fecha_inicio { get; set; }
        string categoria { get; set; }
        string dias_emision { get; set; }
        string hora_inicio { get; set; }
        string hora_finalizacion { get; set; }

        

        public abstract void descripcion(int codigo);

        public Programa(int codigo, string nombre, DateTime Fecha_inicio, string Categoria, string Dias_emision, string Hora_incio, string Hora_finalizacion)
        {
            codigo_programa = codigo;
            nombre_programa = nombre;
            fecha_inicio = Fecha_inicio;
            categoria = Categoria;
            dias_emision = Dias_emision;
            hora_inicio = Hora_incio;
            hora_finalizacion = Hora_finalizacion;

        }

        public virtual void crear()
        {
            Console.WriteLine("No se puede crear un programa sin una plataforma especificada");
        }

        public void guardar(Programa programa)
        {
            Console.WriteLine("Desea guardar? Si:Y  No:N");
            string respuesta = Console.ReadLine();
            if (respuesta == "Y")
            {
                string ruta_archivo = "C:/programas.json";
                List<Programa> programas = new List<Programa>();
                string contenido = "";
                using (StreamReader reader = new StreamReader(ruta_archivo)) 
                {
                    contenido = reader.ReadToEnd();
                }
                programas = JsonConvert.DeserializeObject<List<Programa>>(contenido);
                programas.Add(programa);
                string json = JsonConvert.SerializeObject(programas);
                using (StreamWriter streamWriter = new StreamWriter(ruta_archivo))
                {
                    streamWriter.Write(json);
                }
            }
            
            
        }
    }
}
