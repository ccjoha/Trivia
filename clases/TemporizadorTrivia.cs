using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia.clases
{
    public class TemporizadorTrivia
    {
        public int TiempoRestante { get; set; }

        public event Action TiempoFinalizado;

        public Timer timer;

        public TemporizadorTrivia()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        public void Iniciar(int segundos)
        {
            TiempoRestante = segundos;
            timer.Start();
        }

        public void Detener()
        {
            timer.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TiempoRestante--;
            if (TiempoRestante <= 0)
            {
                Detener();
                TiempoFinalizado?.Invoke();
            }
        }
    }
}

