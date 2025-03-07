using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generación_de_Archivo_Texto_Exámenes
{
    internal class ClaseCabecera
    {
        public string? Universidad { get; set; }
        public string? Carrera { get; set; }
        public string? Asignatura { get; set; }
        public string? Fecha { get; set; }
        public int? Id { get; set; }

        public string GenerarCabecera()
        {
            return $"| Universidad: {Universidad} | Carrera: {Carrera} | Asignatura: {Asignatura} | Fecha: {Fecha} | ID: {Id} |\r\n";
        }
    }
}