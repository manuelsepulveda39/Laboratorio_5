using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
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
        /// <param name="nombre"></param>
        /// <param name="fecha"></param>
        /// <param name="puntaje"></param>
        public Jugador(String nombre, DateTime fecha, int puntaje)
        {
            this.nombreJugador = nombre;
            this.fecha = fecha;
            this.puntaje = puntaje;
        }
    }
}
