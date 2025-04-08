using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
    public abstract class Pregunta
    {
        public string Texto { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestasCorrecta { get; set; }
        public string Categoria { get; set; }
        public string Nivel { get; set; }

        public Pregunta(string texto, List<string> opciones, string respuestascorrectas, string categoria, string nivel)
        {
            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(nivel))
            {
                throw new ArgumentException("la categoria y el nivel son obligatorios");
            }

            Texto = texto;
            Opciones = opciones;
            RespuestasCorrecta = respuestascorrectas;
            Categoria = categoria;
            Nivel = nivel;
        }

        public abstract int EvaluarRespuesta(string respuestaUsuario);
        public abstract int TiempoLimite{get;}
    }
}
