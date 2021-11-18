using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Juego j;
        private void Form1_Load(object sender, EventArgs e)
        {
            j = new Juego();
            j.JuegoIniciado += J_JuegoIniciado;
            j.JuegoTerminado += J_JuegoTerminado;
        }

        private void J_JuegoTerminado()
        {
            btnIniciar.Enabled = true;
            nmrNumero.Enabled = false;
            btnAdivinar.Enabled = false;
            btnFinalizar.Enabled = false;
        }

        private void J_JuegoIniciado()
        {
            btnIniciar.Enabled = false;
            nmrNumero.Enabled = true;
            btnAdivinar.Enabled = true;
            btnFinalizar.Enabled = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            j.IniciarJuego();
        }
    }
}
