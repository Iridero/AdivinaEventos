using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaEventos
{
    public class Juego
    {
        public delegate void Notificacion();
        public event Notificacion JuegoIniciado;
        public event Notificacion JugadorGano;
        public event Notificacion JugadorPerdio;
        public event Notificacion OcultoEsMayor;
        public event Notificacion OcultoEsMenor;
        public event Notificacion JuegoTerminado;
        private int oculto;
        public int Oportunidades { get; private set; }
        public void IniciarJuego()
        {
            Random r = new Random();
            oculto = r.Next(5001);
            Oportunidades = 20;
            JuegoIniciado?.Invoke();
        }
        public void Comparar(int n)
        {
            if (n == oculto)
            {
                JugadorGano?.Invoke();
                FinalizarJuego();
            }
            else if (oculto > n)
            {
                OcultoEsMayor?.Invoke();
                Oportunidades--;
            }
            else
            {
                OcultoEsMenor?.Invoke();
                Oportunidades--;
            }
            if (Oportunidades == 0)
            {
                JugadorPerdio?.Invoke();
                FinalizarJuego();
            }
        }
        public void FinalizarJuego()
        {
            JuegoTerminado?.Invoke();
        }
    }
}
