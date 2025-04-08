using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
    public class PreguntaFactory
    {
        private static List<Pregunta> todasLasPreguntas = new List<Pregunta>
        {
            new PreguntaFacil("¿Cuál es el planeta más cercano al sol?", new List<string>{"Marte", "Venus", "Mercurio"}, "Mercurio", "Ciencia"),
            new PreguntaMedia("¿En qué año comenzó la Segunda Guerra Mundial?", new List<string>{"1935", "1939", "1941"}, "1939", "Historia"),
            new PreguntaDificil("¿Cuál es la capital de Burkina Faso?", new List<string>{"Uagadugú", "Bamako", "Niamey"}, "Uagadugú", "Cultura General"),
            // Agregar más preguntas...
        };

        public static List<Pregunta> ObtenerPreguntas(string categoria, string nivel, int cantidad)
        {
            var preguntasFiltradas = todasLasPreguntas
                .Where(p => p.Categoria == categoria && p.Nivel == nivel)
                .OrderBy(p => Guid.NewGuid())
                .Take(cantidad)
                .ToList();

            return preguntasFiltradas;
        }
    }
}
