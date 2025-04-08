using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
    public class PreguntaFacil : Pregunta
    {
        public override int TiempoLimite => 20;
        public PreguntaFacil(string texto, List<string> opciones, string respuestaCorrecta, string categoria) : base(texto, opciones, respuestaCorrecta, categoria, "Fácil") { }

        public override int EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestasCorrecta ? 5 : -2;
        }
       
    }
}

