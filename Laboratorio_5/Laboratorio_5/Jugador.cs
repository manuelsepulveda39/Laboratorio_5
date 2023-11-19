using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    /// <summary>
    /// Clase que administra la información de los jugadores.
    /// </summary>
    public class Jugador
    {
        /// <summary>
        /// Setter y getter del puntaje que obtuvo el jugador.
        /// </summary>
        public int puntaje { get; set; }

        /// <summary>
        /// Setter y getter del nombre del jugador.
        /// </summary>
        public string nombreJugador { get; set; }

        /// <summary>
        /// Setter y getter de la fecha en la que jugó.
        /// </summary>
        public DateTime fecha { get; set; }

        /// <summary>
        /// Metodo para guardar un nuevo jugador
        /// </summary>
        /// <param name="nombre">Nombre del jugador.</param>
        /// <param name="fecha">Fecha en la que jugó.</param>
        /// <param name="puntaje">Puntaje que obtuvo.</param>
        public Jugador(String nombre, DateTime fecha, int puntaje)
        {
            this.nombreJugador = nombre;
            this.fecha = fecha;
            this.puntaje = puntaje;
        }
    }
}
