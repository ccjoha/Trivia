using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
    public class PreguntaMedia : Pregunta
    {
        public PreguntaMedia(string texto, List<string> opciones, string respuestaCorrecta, string categoria) : base(texto, opciones, respuestaCorrecta, categoria, "Media") { }

        public override int EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestasCorrecta ? 10 : -2;
        }
        public override int TiempoLimite => 15;
    }
}
