using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Juego : Form
    {
        string palabra;
        char[] letras;
        int fallos = 0, aciertos = 0;
        bool juegoTerminado;
        public int ptos = 0;

        public Juego(string palabra, string categoria)
        {
            InitializeComponent();
            this.palabra = palabra;
            labelCategoria.Text = "Categoria: " + categoria;
            Console.WriteLine(palabra);
        }

        private void ActualizarPalabra()
        {
            labelPalabra.Text = "";
            foreach(char l in letras)
            {
                labelPalabra.Text += l + " ";
            }
        }

        private bool ComprobarVictoria()
        {
            bool victoria = true;
            foreach (char l in letras)
            {
                if(l == '_')
                {
                    victoria = false;
                }
            }

            return victoria;
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            juegoTerminado = false;
            labelPalabra.Text = "";
            letras = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
                letras[i] = '_';
            ActualizarPalabra();
            //labelPalabra.Text += "      " + palabra;
            pictureBox1.Image = imageList1.Images[0];
        }

        private void textBoxRes_Enter(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void textBoxRes_Leave(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Juego_MouseClick(object sender, MouseEventArgs e)
        {
            //Cuando clickas fuera del textbox, se quita el foco de él
            this.ActiveControl = null;
        }

        private void textBoxRes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !juegoTerminado)
            {
                if (comprobarResolver(textBoxRes.Text.ToUpper()))
                {
                    ptos += 10;
                    Resultado rdo = new Resultado("¡¡Has ganado!!", palabra);
                    juegoTerminado = true;
                    labelPtos.Text = "Puntuación: " + ptos;
                    rdo.ShowDialog();
                }
                else
                {
                    ptos -= 5;
                    labelPtos.Text = "Puntuación: " + ptos;
                    fallos++;
                    labelFallos.Text = "Fallos: " + fallos;

                    //Cambia la imagen
                    pictureBox1.Visible = true;
                    pictureBox1.Image = imageList1.Images[fallos];
                }
            }
        }

        private bool comprobarResolver(string palabra)
        {
            return (palabra == this.palabra);
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (!juegoTerminado)
            {
                bool acertado = false;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra.ToCharArray()[i] == e.KeyValue)
                    {
                        ptos += 2;
                        letras[i] = palabra.ToCharArray()[i];
                        acertado = true;
                        ActualizarPalabra();
                    }
                }
                if (!labelUsadas.Text.Contains((char)e.KeyValue))
                {
                    labelUsadas.Text += " " + (char)e.KeyValue;

                    //Si fallas
                    if (!acertado)
                    {
                        fallos++;
                        labelFallos.Text = "Fallos: " + fallos;
                        ptos--;

                        //Cambia la imagen
                        pictureBox1.Visible = true;
                        pictureBox1.Image = imageList1.Images[fallos];
                        
                    }
                    else
                    {
                        aciertos++;
                        labelAciertos.Text = "Aciertos: " + aciertos;
                    }
                }
                labelPtos.Text = "Puntuación: " + ptos;

                //Derrota
                if (fallos >= 7)
                {
                    Resultado rdo = new Resultado("Has perdido :(", palabra);
                    juegoTerminado = true;
                    labelPtos.Text = "Puntuación: " + ptos;
                    rdo.ShowDialog();
                }

                //Victoria
                if (ComprobarVictoria())
                {
                    Resultado rdo = new Resultado("¡¡Has ganado!!", palabra);
                    juegoTerminado = true;
                    labelPtos.Text = "Puntuación: " + ptos;
                    rdo.ShowDialog();
                }
            }
        }
    }
}
