using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivia.clases;

namespace Trivia
{
    public partial class Form1 : Form
    {
        public List<Pregunta> preguntasSesion;
        public int preguntaActual = 0;
        public int puntaje = 0;
        public TemporizadorTrivia temporizador;
        public Pregunta preguntaEnCurso;
        private int tiempoRestante;
        private Timer timerPregunta = new Timer();
        private int segundosRestantes;

        public Form1()
        {
            InitializeComponent();
            InicializarJuego();
            
        }
        private void InicializarJuego()
        {
            cmbcategoria.Items.AddRange(new string[] { "Ciencia", "Historia", "Cultura General" });
            cmbdificultad.Items.AddRange(new string[] { "Fácil", "Medio", "Difícil" });
            temporizador = new TemporizadorTrivia();
            temporizador.TiempoFinalizado += TiempoAgotado;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgahistorial.Columns.Add("Pregunta", "Pregunta");
            dgahistorial.Columns.Add("Respuesta", "Respuesta");
            dgahistorial.Columns.Add("Resultado", "Resultado");

            timerPregunta.Interval = 1000; // 1 segundo
            temporizador.TiempoFinalizado += TiempoAgotado;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (cmbcategoria.SelectedIndex == -1 || cmbdificultad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría y un nivel de dificultad.");
                return;
            }

            string ruta = @"C:\Users\CARLOS CAICEDO\source\repos\Trivia\bin\Debug\preguntas.csv"; // o el path donde lo guardaste
            var todasLasPreguntas = Gestorpregunta.CargarDesdeCSV(ruta);

            string categoriaSeleccionada = cmbcategoria.SelectedItem.ToString();
            preguntasSesion = todasLasPreguntas
                                .Where(p => p.Categoria.Equals(categoriaSeleccionada, StringComparison.OrdinalIgnoreCase))
                                .OrderBy(x => Guid.NewGuid()) // Opcional, si quieres aleatorias
                                .Take(15)
                                .ToList();

            if (preguntasSesion.Count == 0)
            {
                MessageBox.Show("No hay preguntas disponibles para esta categoría.");
                return;
            }

           
            puntaje = 0;
            preguntaActual = 0;
            dgahistorial.Rows.Clear();
            MostrarSiguientePregunta();
        }

        private void MostrarSiguientePregunta()
        {
            // Verificar si se acabaron las preguntas
            if (preguntaActual >= 15 ||preguntaActual >= preguntasSesion.Count)
            {
                FinalizarJuego();
                return;
            }

            // Obtener la pregunta actual
            preguntaEnCurso = preguntasSesion[preguntaActual];

            // Mostrar el texto de la pregunta
            lblpregunta.Text = preguntaEnCurso.Texto;

            // Cargar opciones en los RadioButtons
            var opciones = preguntaEnCurso.Opciones;
            rbopcion1.Text = opciones[0];
            rbopcion2.Text = opciones[1];
            rbopcion3.Text = opciones[2];
            rbopcion4.Text = opciones[3];

            // Desmarcar todas las opciones
            rbopcion1.Checked = rbopcion2.Checked = rbopcion3.Checked = rbopcion4.Checked = false;

            // Actualizar etiquetas de puntaje y preguntas restantes
            lblpreguntasrestantes.Text = $"Preguntas restantes: {preguntasSesion.Count - preguntaActual}";
            lblpuntaje.Text = $"Puntaje: {puntaje}";

            // Configurar barra de tiempo y temporizador
            tiempoRestante = preguntaEnCurso.TiempoLimite;
            pbTiempo.Maximum = tiempoRestante;
            pbTiempo.Value = tiempoRestante;
            segundosRestantes = preguntaEnCurso.TiempoLimite;
            lbltiemporestante.Text = $"{tiempoRestante} s";

            temporizador.Iniciar(preguntaEnCurso.TiempoLimite);
        }

        
        private void btnresponder_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (rbopcion1.Checked) respuesta = rbopcion1.Text;
            else if (rbopcion2.Checked) respuesta = rbopcion2.Text;
            else if (rbopcion3.Checked) respuesta = rbopcion3.Text;
            else if (rbopcion4.Checked) respuesta = rbopcion4.Text;
            else
            {
                MessageBox.Show("Seleccione una respuesta.");
                return;
            }

            temporizador.Detener();

            int resultado = preguntaEnCurso.EvaluarRespuesta(respuesta);
            bool esCorrecta = resultado > 0;

            if (esCorrecta)
            {
                puntaje += resultado;
                MessageBox.Show("¡Correcto!");
            }
            else
            {
                puntaje = Math.Max(0, puntaje - 2);
                MessageBox.Show($"Incorrecto. La respuesta correcta era: {preguntaEnCurso.RespuestasCorrecta}");
            }

            // Historial
            dgahistorial.Rows.Add(preguntaEnCurso.Texto, respuesta, esCorrecta ? "✔" : "✖");

            preguntaActual++;
            MostrarSiguientePregunta();

        }

        private void TiempoAgotado()
        {
            segundosRestantes--;

            if (segundosRestantes >= 0)
            {
                pbTiempo.Value = segundosRestantes;
            }

            if (segundosRestantes <= 0)
            {
                timerPregunta.Stop();

                MessageBox.Show("¡Tiempo agotado!");
                puntaje = Math.Max(0, puntaje - 2);
                dgahistorial.Rows.Add(preguntaEnCurso.Texto, "Sin respuesta", "✖");
                preguntaActual++;
                MostrarSiguientePregunta(); // <-- Cargar la siguiente
            }
        }

        private void FinalizarJuego()
        {
            temporizador.Detener();
            MessageBox.Show($"¡Trivia finalizada!\nPuntaje total: {puntaje} puntos.");
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            cmbcategoria.SelectedIndex = -1;
            cmbdificultad.SelectedIndex = -1;
            lblpregunta.Text = "";
            rbopcion1.Text = rbopcion2.Text = rbopcion3.Text = rbopcion4.Text = "";
            lblpuntaje.Text = "Puntaje: 0";
            lblpreguntasrestantes.Text = "";
            dgahistorial.Rows.Clear();
        }

        private void pbTiempo_Click(object sender, EventArgs e)
        {
            timerPregunta.Stop(); // Por si quedaba activo
            timerPregunta.Start(); // Comenzar el nuevo tiempo
        }
    }
}
