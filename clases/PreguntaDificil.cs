using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
   public class PreguntaDificil : Pregunta
    {
        public override int TiempoLimite => 10;
        public PreguntaDificil(string texto, List<string> opciones, string respuestaCorrecta, string categoria) : base(texto, opciones, respuestaCorrecta, categoria, "Dificil") { }

        public override int EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestasCorrecta ? 15 : -2;
        }
        
    }
}
