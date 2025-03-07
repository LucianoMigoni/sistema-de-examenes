using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generación_de_Exámenes
{
    internal class ClaseExamen
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public string? Asignatura { get; set; }
        public List<string>? Preguntas { get; set; }

        // Funcion para generar la lista de preguntas separadas por "-"
        public string GenerarListaPreg()
        {
            return string.Join("-", Preguntas);
        }

        // Funcion para generar el formato para txt
        public string GenerarFormatoTxt()
        {
            if (Preguntas.Count > 1)
                return $"{Id}|{Fecha}|{Asignatura}|[{GenerarListaPreg()}]";
            else
                return $"{Id}|{Fecha}|{Asignatura}|[{Preguntas[0]}]";
        }
        // 1: Id, 2: Fecha, 3: Asignatura, 4: Lista de ID's de preguntas
    }
}
