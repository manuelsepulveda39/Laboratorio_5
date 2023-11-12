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
    public partial class Snake : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int tamanoPiezaPrincipal = 25;
        int tiempo;
        PictureBox comida = new PictureBox();
        String direccion;

        public Snake()
        {
            InitializeComponent();
        }

        public void iniciarJuego()
        {
            botonEmpezar.Enabled = false;
            mejoresPuntajes.Enabled = false;
            timer1.Enabled = true;
            tiempo = 10;
            direccion = "R";
            timer1.Interval = 200;
            lista = new List<PictureBox>();
            for(int k = 2; 0 <= k; k--)
            {
                crearSnake(lista, panel, (k * tamanoPiezaPrincipal) + 75, 75, k, 2);
            }
        }

        public void crearSnake(List<PictureBox> listaPelota, Panel panel, int posicionx, int posiciony, int k, int max)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionx, posiciony);
            pb.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake body");
            if (k == max)
            {
                pb.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("snake head" + direccion);

            }
            pb.BackColor = Color.Transparent;
            pb.Size = new Size(25, 25);
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            listaPelota.Add(pb);
            panel.Controls.Add(pb);
        }

        private void botonEmpezar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

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
                }
                else
                {
                    lista[i].Location = new Point(lista[i - 1].Location.X, lista[i].Location.Y);
                    lista[i].Location = new Point(lista[i].Location.X, lista[i - 1].Location.Y);
                }
            }
            /*
            for (int contarPiezas = 1; contarPiezas < lista.Count; contarPiezas++)
            {
                if (lista[contarPiezas].Bounds.IntersectsWith(Comida.Bounds))
                {
                    this.Control.Remove(Comida);
                    tiempo = Convert.ToInt32(timer1.Interval);

                    if (tiempo > 10)
                    {
                        timer1.Interval = tiempo - 10;
                    }
                    puntos.Text = (Convert.ToInt32(puntos.Text) + 1).ToString();
                    crearComida();
                    crearSnake(lista, this, lista[lista.Count - 1].Location.X * tamanoPiezaPrincipal);
                }
            }*/
            if ((lista[0].Location.X >= panel.Width - 15) || (lista[0].Location.Y >= panel.Height - 50) ||
                    (lista[0].Location.Y < -10) || (lista[0].Location.X < -30))
            {
                //reiniciarJuego();
            }
        }

        private void moverPieza(object sender, KeyEventArgs e)
        {
            if(direccion != "B")
            {
                direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "" : direccion;
            }
            if(direccion != "")
            {
                direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "B" : direccion;
            }
            if(direccion != "R")
            {
                direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "L" : direccion;
            }
            if(direccion != "L" && (direccion == "B" || direccion == ""))
            {
                direccion = ((e.KeyCode & Keys.Right) == Keys.Right) ? "R" : direccion;
            }
        }
    }
}
