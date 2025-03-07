using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrección_de_Exámenes
{
    internal class ClaseCorrecEx
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        // Respuestas del examen
        public List<string>? RespuestasUsuario { get; set; }
        public List<string>? RespuestasCorrectas { get; set; }

        public decimal CantResp {  get; set; }
        public decimal CantRespCorrectas { get; set; }

        public decimal NotaFinal { get; set; }

        // Funcion para contactenar las respuestas del alumno y las correctas
        private string GenerarListaRespuestas()
        {
            string respuestas = "";

            for (int i = 0; i < RespuestasUsuario.Count; i++)
            {
                string respuestaAlumno = RespuestasUsuario[i];
                string respuestaCorrecta = RespuestasCorrectas[i];
                respuestas += $"{respuestaAlumno} - {respuestaCorrecta}\r\n";
            }

            return respuestas;
        }

        // Funcion para genrerar una cabecera con los datos del alumno
        public string GenerarCabeceraSecundaria()
        {
            return $"| Alumno: {Nombre} {Apellido} |\r\n";
        }

        // Funcion para generar el formato listo para txt
        public string GenerarFormatoTxt()
        {
            return $"| Respuestas del alumno | Respuestas correctas |\r\n{GenerarListaRespuestas()}\r\n" +
               $"Respuestas Correctas: {CantRespCorrectas} / {CantResp} \r\n" +
               $"Nota Final: {NotaFinal}" +
               "\r\n\r\n-----------------------------------------------------\r\n";
        }
    }
}
