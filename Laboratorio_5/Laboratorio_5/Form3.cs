using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5
{
    /// <summary>
    /// Clase que muestra los mejores cinco puntajes que se han obtenido en el juego.
    /// </summary>
    public partial class mejoresPunt : Form
    {
        /// <summary>
        /// Metodo que se ejecuta al iniciar el formulario.
        /// </summary>
        public mejoresPunt()
        {
            InitializeComponent();

            //Se guarda la instancia
            Jugadores jugadores = Jugadores.obtenerInstancia();

            //Se muestran los mejores jugadores
            if (jugadores.vectorJugadores[0] != null)
            {
                labelNombre1.Text = jugadores.vectorJugadores[0].nombreJugador;
                labelFecha1.Text = jugadores.vectorJugadores[0].fecha.ToString();
                labelPuntaje1.Text = jugadores.vectorJugadores[0].puntaje.ToString();
            }
            if (jugadores.vectorJugadores[1] != null)
            {
                labelNombre2.Text = jugadores.vectorJugadores[1].nombreJugador;
                labelFecha2.Text = jugadores.vectorJugadores[1].fecha.ToString();
                labelPuntaje2.Text = jugadores.vectorJugadores[1].puntaje.ToString();
            }
            if (jugadores.vectorJugadores[2] != null)
            {
                labelNombre3.Text = jugadores.vectorJugadores[2].nombreJugador;
                labelFecha3.Text = jugadores.vectorJugadores[2].fecha.ToString();
                labelPuntaje3.Text = jugadores.vectorJugadores[2].puntaje.ToString();
            }
            if (jugadores.vectorJugadores[3] != null)
            {
                labelNombre4.Text = jugadores.vectorJugadores[3].nombreJugador;
                labelFecha4.Text = jugadores.vectorJugadores[3].fecha.ToString();
                labelPuntaje4.Text = jugadores.vectorJugadores[3].puntaje.ToString();
            }
            if (jugadores.vectorJugadores[4] != null)
            {
                labelNombre5.Text = jugadores.vectorJugadores[4].nombreJugador;
                labelFecha5.Text = jugadores.vectorJugadores[4].fecha.ToString();
                labelPuntaje5.Text = jugadores.vectorJugadores[4].puntaje.ToString();
            }
        }

        /// <summary>
        /// Botón para cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
