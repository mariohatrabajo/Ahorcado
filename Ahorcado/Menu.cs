using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ahorcado
{
    public partial class Menu : Form
    {
        int ptos = 0;
        public Menu()
        {
            InitializeComponent();
            XmlDocument xml = new XmlDocument();
            xml.Load("Palabras.xml");

            foreach(XmlNode n1 in xml.DocumentElement.ChildNodes)
            {
                comboBoxCategorias.Items.Add(n1.Name);
            }
        }

        private void empezarJuego(object sender, EventArgs e)
        {
            List<string> palabras = new List<string>();

            XmlDocument xml = new XmlDocument();
            xml.Load("Palabras.xml");

            foreach(XmlNode n1 in xml.DocumentElement.ChildNodes)
            {
                if(n1.Name == comboBoxCategorias.SelectedItem.ToString())
                {
                    foreach(XmlNode n2 in n1.ChildNodes)
                    {
                        foreach(XmlNode n3 in n2.ChildNodes)
                            palabras.Add(n3.Value);
                    }
                }
            }

            string palabra = palabras[new Random().Next(palabras.Count())];

            Juego juego = new Juego(palabra, comboBoxCategorias.Text);
            this.Hide();
            juego.ShowDialog();

            this.ptos += juego.ptos;
            labelPtos.Text = "Puntuación: " + ptos;

            if(juego.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }else if(juego.DialogResult == DialogResult.OK)
            {
                this.Show();
            }

        }

        private void categoriaSeleccionada(object sender, EventArgs e)//SelectedIndexChanged
        {
            botonJugar.Visible = true;
        }
    }
}
