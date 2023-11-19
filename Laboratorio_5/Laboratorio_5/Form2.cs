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
    /// Clase que guarda la información de la partida.
    /// </summary>
    public partial class GuardarJuego : Form
    {
        int puntaje;

        /// <summary>
        /// Método que se ejecuta al iniciar el formulario
        /// </summary>
        public GuardarJuego(int punt)
        {
            InitializeComponent();
            this.puntaje = punt;
            lblPuntajeF.Text = puntaje.ToString();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en el botón guardar.
        /// Crea un nuevo objeto jugador, lo agrega al vector y actualiza el ranking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombreJugador = txtBoxNombre.Text;
            DateTime fecha = DateTime.Now;
            int puntaje = this.puntaje;

            //Se guarda la instancia y se llama el metodo de agregar Jugador
            Jugadores jugadores = Jugadores.obtenerInstancia();
            jugadores.agregarJugador(nombreJugador, puntaje, fecha);

            Close();
        }
    }
}
