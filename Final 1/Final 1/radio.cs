using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_1
{
      public class radio:Programa
    {
        string conductor { get; set; }
        string frecuencia { get; set; }

        public radio(int codigo, string nombre, DateTime Fecha_inicio, string Categoria, string Dias_emision, string Hora_incio, string Hora_finalizacion, string Conductor, string Frecuencia)
        : base(codigo, nombre, Fecha_inicio, Categoria, Dias_emision, Hora_incio, Hora_finalizacion)
        {
            conductor = Conductor;
            frecuencia = Frecuencia;
        }

        public override void descripcion(int codigo)
        {
            
        }
    }
}
