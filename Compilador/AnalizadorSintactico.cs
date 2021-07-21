using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Compilador
{
    public class AnalizadorSintactico
    {
        private List<Regex> patrones = new List<Regex>();
        string[] espacios = { @"\s*", @"\s+" };
        string retornos = @"(\n|\r|\t|\s)*";
        string tipos = "";

        public bool ComprobarSintaxis(string texto)
        {
            foreach(Regex patron in patrones)
            {
                if (patron.IsMatch(texto))
                {
                    return true;
                }
            }

            return false;
        }

        public void AgregarPatrones()
        {
            tipos = DefinirOpciones(Simbolos.tipos);
            DefinirDeclaraciones();
        }

        private string DefinirLineas()
        {
            string variable = @"[a-zA-Z]+";
            string numeroEnteroODecimal = @"\s*[0-9]+" + @"(\.[0-9]+)*" + @"\s*";

            string lineas = ("(" + retornos + tipos +"?"  + variable + espacios[0] + @"((\=" + espacios[0] + "("+ variable +@"|"+numeroEnteroODecimal+")" + @"\;)|\;)"+")*");

            return lineas;
        }

        private string DefinirParametros()
        {
            string variable = @"\s*[a-zA-Z]+\s*";

            string lineas = 
            (
                @"\s*\(\s*" +
                "("+ tipos + variable + 
                @"(\,\s*"+ tipos + variable + ")*" +
                @")*"+
                @"\)"
            );

            return lineas;
        }

        private string DefinirOpciones(List <string> simbolos)
        {
            string opciones = "((";
            for (int c = 0; c < simbolos.Count; c++)
            {
                opciones += simbolos[c];
                if (c < simbolos.Count - 1)
                    opciones += "|";
            }

            opciones += @")\s+)";
            Console.WriteLine("opciones: " + opciones.ToString());
            return opciones;
        }

        private void DefinirDeclaraciones()
        {
            string lineas = DefinirLineas();
            string parametros = DefinirParametros();
            string [] llaves = { @"\{", @"\}" };
            string variable = @"[a-zA-Z]+";
            string modificadores = DefinirOpciones(Simbolos.modificadores);

            patrones.Add(new Regex("(" + modificadores + @"|\s*)" + tipos + variable + espacios[0] + parametros + retornos + llaves[0] + lineas + retornos +llaves[1]));
            Console.WriteLine(patrones[0]);
        }
    }
}
