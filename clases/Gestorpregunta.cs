using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Trivia.clases
{
    public class Gestorpregunta 
    {

        public static List<Pregunta> CargarDesdeCSV(string rutaArchivo)
        {
            var preguntas = new List<Pregunta>();

            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas.Skip(1)) // Saltar encabezado
            {
                var partes = linea.Split(',');

                if (partes.Length < 8) continue;

                string texto = partes[0];
                List<string> opciones = partes.Skip(1).Take(4).ToList();
                string respuestaCorrecta = partes[5];
                string dificultad = partes[6];
                string categoria = partes[7];

                Pregunta pregunta;

                switch (dificultad.Trim().ToLower())
                {
                    case "facil":
                        pregunta = new PreguntaFacil(texto, opciones, respuestaCorrecta, categoria);
                        break;
                    case "media":
                        pregunta = new PreguntaMedia(texto, opciones, respuestaCorrecta, categoria);
                        break;
                    case "dificil":
                        pregunta = new PreguntaDificil(texto, opciones, respuestaCorrecta, categoria);
                        break;
                    default:
                        continue;
                }

                pregunta.Texto = texto;
                pregunta.Opciones = opciones;
                pregunta.RespuestasCorrecta = respuestaCorrecta;
                pregunta.Categoria = categoria;

                preguntas.Add(pregunta);
            }

            return preguntas;
        }
    }

}
