using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    //una clase PARTIAL es una clase que se puede "partir" en disintos pedazos de codigo.
    //es decir que puede tener un par de cosas definidas aca y el resto en otro archivo con un nombre de clase IGUAL
    // al ponerle el partial adelante, lo que digo es que es la misma clase solo que dividida.
    // aca es util porque en el Form1.Designer.cs tengo el pedazo de cogido de la clase Form1 que tiene el diseño
    // de los objetos que forman la app.
    // y en este archivo (Form1.cs) voy a poder codear la funcionalidad de dichos objetos. 
    // Todo es parte de la clase Form1, pero dividio queda mas organizado.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string opTernario = opTernarioCheckBox.Checked == true ? "Verdadero" : "Falso" ;
            opTernarioLabel.Text = opTernario;
        }
    }
}
