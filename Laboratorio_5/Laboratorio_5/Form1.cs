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
    /// Clase que contiene los métodos escenciales del juego.
    /// </summary>
    public partial class Snake : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int tamanoPiezaPrincipal = 25;
        int tiempo;
        PictureBox manzana = new PictureBox();
        String direccion;

        /// <summary>
        /// Método generado automaticamente.
        /// </summary>
        public Snake()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que inicia el juego.
        /// Configura el formulario, inicia la serpiente y agrega la primera manzana.
        /// </summary>
        public void iniciarJuego()
        {
            botonEmpezar.Enabled = false;
            mejoresPuntajes.Enabled = false;
            timer1.Enabled = true;
            tiempo = 10;
            direccion = "R";
            timer1.Interval = 200;
            lista = new List<PictureBox>();

            for (int k = 2; 0 <= k; k--)
            {
                crearSnake(lista, panel, (k * tamanoPiezaPrincipal) + 75, 75);
            }

            crearManzana();
        }

        /// <summary>
        /// Método que crea las partes del cuerpo de la serpiente.
        /// </summary>
        /// <param name="listaSnake">Lista en la que se guardan las partes del cuerpo de la serpiente.</param>
        /// <param name="panel">Panel en el que se está mostrando el juego.</param>
        /// <param name="posicionx">Posición en el eje X donde se creará la nueva parte de la serpiente.</param>
        /// <param name="posiciony">Posición en el eje Y donde se creará la nueva parte de la serpiente.</param>
        public void crearSnake(List<PictureBox> listaSnake, Panel panel, int posicionX, int posicionY)
        {
            PictureBox pb = new PictureBox();

            pb.Location = new Point(posicionX, posicionY);
            pb.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake body");
            pb.BackColor = Color.Transparent;
            pb.Size = new Size(25, 25);
            pb.BackgroundImageLayout = ImageLayout.Stretch;

            listaSnake.Add(pb);
            panel.Controls.Add(pb);
        }

        /// <summary>
        /// Método que crea las manzanas de manera aleatoria dentro del juego.
        /// </summary>
        private void crearManzana()
        {
            Random random = new Random();
            int posX;
            int posY;

            //Ciclo para que las posiciones sean multiplos de 25
            do
            {
                posX = random.Next(1, panel.Width - tamanoPiezaPrincipal);
                posY = random.Next(1, panel.Height - tamanoPiezaPrincipal);

            } while (posX % 25 != 0 || posY % 25 != 0);

            PictureBox manzana = new PictureBox();

            manzana.Location = new Point(posX, posY);
            manzana.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("Apple Tile");
            this.manzana = manzana;
            manzana.BackColor = Color.Transparent;
            manzana.Size = new Size(25, 25);
            manzana.BackgroundImageLayout = ImageLayout.Stretch;

            panel.Controls.Add(manzana);


        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en el botón empezar.
        /// Llama al método iniciarJuego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEmpezar_Click(object sender, EventArgs e)
        {
            puntos.Text = "0";
            iniciarJuego();
        }

        /// <summary>
        /// Método que se ejecuta mientras el timer está habilitado.
        /// Controla el movimiento de la serpiente y sus colisiones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nx = lista[0].Location.X;
            int ny = lista[0].Location.Y;

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (direccion == "R")
                    {
                        nx = nx + tamanoPiezaPrincipal;
                    }
                    else if (direccion == "L")
                    {
                        nx = nx - tamanoPiezaPrincipal;
                    }
                    else if (direccion == "B")
                    {
                        ny = ny - tamanoPiezaPrincipal;
                    }
                    else if (direccion == "")
                    {
                        ny = ny + tamanoPiezaPrincipal;
                    }
                    
                    lista[0].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake head" + direccion);
                    lista[0].Location = new Point(nx, ny);

                    //Para que la direccion del cuepo tambien cambie
                    if (direccion == "R" || direccion == "L")
                    {
                        for (int j = 1; j < lista.Count; j++)
                        {
                            lista[j].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake bodyLR");
                        }
                    }
                    if (direccion == "" || direccion == "B")
                    {
                        for (int j = 1; j < lista.Count; j++)
                        {
                            lista[j].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake bodyB");
                        }
                    }

                }
                else
                {
                    lista[i].Location = new Point(lista[i - 1].Location.X, lista[i].Location.Y);
                    lista[i].Location = new Point(lista[i].Location.X, lista[i - 1].Location.Y);
                }
            }

          

            for (int contarPiezas = 1; contarPiezas < lista.Count; contarPiezas++)
            {
                if (lista[contarPiezas].Bounds.IntersectsWith(manzana.Bounds))
                {
                    panel.Controls.Remove(manzana);
                    tiempo = Convert.ToInt32(timer1.Interval);

                    if (tiempo > 4)
                    {
                        timer1.Interval = tiempo - 4;
                    }

                    puntos.Text = (Convert.ToInt32(puntos.Text) + 1).ToString();

                    crearSnake(lista, panel, lista[lista.Count - 1].Location.X * tamanoPiezaPrincipal,
                        lista[lista.Count - 1].Location.Y * tamanoPiezaPrincipal);

                    crearManzana();
                }
            }


            if ( lista[0].Location.X == panel.Width || lista[0].Location.Y == panel.Height ||
                    lista[0].Location.Y < -10 || lista[0].Location.X < -20)
            {
                finJuego();
            }
            else
            {

                for (int cuerpo = 1; cuerpo < lista.Count; cuerpo++)
                {
                    if (lista[0].Location.X == lista[cuerpo].Location.X && lista[0].Location.Y == lista[cuerpo].Location.Y)
                    {
                        finJuego();
                        break;
                    }
                }

            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el jugador pierde.
        /// </summary>
        private void finJuego()
        {
            timer1.Enabled = false;
            lista.Clear();
            panel.Controls.Clear();
            int puntaje = int.Parse(puntos.Text);
            GuardarJuego form2 = new GuardarJuego(puntaje);
            form2.ShowDialog();

            botonEmpezar.Enabled = true;
            mejoresPuntajes.Enabled = true;
        }

        /// <summary>
        /// Método que cambia la dirección de la serpiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moverPieza(object sender, KeyEventArgs e)
        {
            if (direccion != "R")
            {
                direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "L" : direccion;
            }
            if (direccion != "B")
            {
                direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "" : direccion;
            }
            if (direccion != "")
            {
                direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "B" : direccion;
            }
            if (direccion != "L")
            {
                direccion = ((e.KeyCode & Keys.Right) == Keys.Right) ? "R" : direccion;
            }
           


        }

        /// <summary>
        /// Boton para abrir formulario de los mejores puntajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mejoresPuntajes_Click(object sender, EventArgs e)
        {
            mejoresPunt mejoresPunt = new mejoresPunt();
            mejoresPunt.Show();
        }
    }
}
