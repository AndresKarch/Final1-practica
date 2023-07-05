using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_1
{
    public class internet:Programa
    {
        string plataforma { get; set; }
        List<string> dias { get; set; }
        string titulo { get; set; }
        string nombre_manager { get; set; }

        public internet(int codigo, string nombre, DateTime Fecha_inicio, string Categoria, string Dias_emision, string Hora_incio, string Hora_finalizacion, string Plataforma, List<string> Dias, string Titulo, string Nombre_manager) 
        : base(codigo,nombre,Fecha_inicio,Categoria,Dias_emision, Hora_incio, Hora_finalizacion)
        {
            plataforma = Plataforma;
            dias = Dias;
            titulo = Titulo;
            nombre_manager = Nombre_manager;
        }   
        public override void descripcion(int codigo)
        {
            
        }


    }
}
