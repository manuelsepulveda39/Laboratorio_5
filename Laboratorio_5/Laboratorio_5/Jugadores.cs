using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5
{
    /// <summary>
    /// Clase para manipular el vector de los mejores jugadores
    /// </summary>
    public class Jugadores
    {
        //Instancia de esta clase y vector de jugadores
        private static Jugadores instancia;
        public Jugador[] vectorJugadores;
        private int cantidadJugadores;

        private Jugadores()
        {
            vectorJugadores = new Jugador[5];
            cantidadJugadores = 0;
        }

        /// <summary>
        /// Este metodo es para poder utilizar siempre la misma instancia y que no se cree nuevamente
        /// cada que se ejecuta el form donde pide el nombre
        /// </summary>
        /// <returns>Instancia de la clase jugadores</returns>
        public static Jugadores obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Jugadores();
            }
            return instancia;
        }


        /// <summary>
        /// Este metodo es para agregar y organizar el vector de jugadores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="puntaje"></param>
        /// <param name="fecha"></param>
        public void agregarJugador(string nombre, int puntaje, DateTime fecha)
        {
            if (cantidadJugadores == 4)
            {
                //Si ya hay inscritos 5 jugadores se eliminara al peor y se agregara el nuevo
                for (int i = 0; i < 5; i++)
                {
                    if (vectorJugadores[i].puntaje < puntaje)
                    {
                        for (int j = 4; j > i; j--)
                        {
                            vectorJugadores[j] = vectorJugadores[j - 1];
                        }

                        vectorJugadores[i] = new Jugador(nombre, fecha, puntaje);
                    }
                }
            }
            else
            {
                //Si no hay inscritos 5 jugadores se agrega el nuevo y se organiza de forma desendente
                vectorJugadores[cantidadJugadores] = new Jugador(nombre, fecha, puntaje);
                int index = cantidadJugadores;
                while (index > 0 && vectorJugadores[index].puntaje > vectorJugadores[index - 1].puntaje)
                {
                    Jugador temp = vectorJugadores[index];
                    vectorJugadores[index] = vectorJugadores[index - 1];
                    vectorJugadores[index - 1] = temp;

                    index--;
                }
                cantidadJugadores++;
            }
        }
    }
}
