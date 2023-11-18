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
    public partial class Form2 : Form
    {
        public List<Jugadores> jugadores = new List<Jugadores>();
        Jugadores nuevoJugador;
        public int nuevoPuntaje { get; set; }

        /// <summary>
        /// Método generado automaticamente
        /// </summary>
        public Form2()
        {
            InitializeComponent();

            lblPuntajeF.Text = nuevoPuntaje.ToString();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en el botón guardar.
        /// Crea un nuevo objeto jugador, lo agrega a la lista y actualiza el ranking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Jugadores nuevoJugador = new Jugadores();
            nuevoJugador.nombreJugador = txtBoxNombre.Text;
            nuevoJugador.fecha = DateTime.Now;
            nuevoJugador.puntaje = nuevoPuntaje;

            jugadores.Add(nuevoJugador);

            jugadores = jugadores.OrderByDescending(jugadorNuevo => jugadorNuevo.puntaje).ToList();

            List<Jugadores> mejoresPuntajes = jugadores.Take(5).ToList();

            Close();
        }
    }
}
