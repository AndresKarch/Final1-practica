using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_1
{
    public class televisivo:Programa
    {
        List<string> conductores {  get; set; }
        string canal { get; set; }

        public televisivo(int codigo, string nombre, DateTime Fecha_inicio, string Categoria, string Dias_emision, string Hora_incio, string Hora_finalizacion, List<string> Conductores, string Canal)
        : base(codigo, nombre, Fecha_inicio, Categoria, Dias_emision, Hora_incio, Hora_finalizacion)
        {
            conductores = Conductores;
            canal = Canal;
        }

        public override void descripcion(int codigo)
        {
            
        }

    }
}
