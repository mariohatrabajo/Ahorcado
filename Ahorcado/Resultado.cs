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
    public partial class Resultado : Form
    {
        public Resultado(string mensaje, string palabra)
        {
            InitializeComponent();
            labelMsg.Text = mensaje;
            labelRdo.Text = "La palabra era " + palabra + ".";
        }
    }
}
