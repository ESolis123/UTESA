using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Form1 : Form
    {
        AnalizadorSintactico lexico = new AnalizadorSintactico();
        public Form1()
        {
            InitializeComponent();
            lexico.AgregarPatrones();
        }

        private void btnTabladeSimbolos_Click(object sender, EventArgs e)
        {
            txtTabladeSimbolos.Text = "";
            txtTabladeSimbolos.Text = new TabladeSimbolos().AnalizarTabladeSimbolos(txtTexto.Text);
        }

        private void btnAnalizadorSintactico_Click(object sender, EventArgs e)
        {
            txtAnalizadorSintactico.Text = "";

            if (lexico.ComprobarSintaxis(txtTexto.Text))
                txtAnalizadorSintactico.Text = "Correcto";
            else
                txtAnalizadorSintactico.Text = "Hubo un error";
        }
    }
     
}
