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


        public bool ComprobarSintaxis(string texto)
        {
            Console.WriteLine(patrones[0]);
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
            DefinirDeclaraciones();
        }

        private string [] DefinirLineas()
        {
            List<string> lineas = new List<string>();
            string variable = @"\s*[a-zA-Z]+\s*";

            foreach (string tipo in Simbolos.tipos)
            {
                lineas.Add(tipo +"?" + variable + @"\=\s*" + variable + @"\;");
            }
           

            return lineas.ToArray();
        }

        private string[] DefinirParametros()
        {
            List<string> lineas = new List<string>();
            string variable = @"\s*[a-zA-Z]+\s*";

            foreach (string tipo in Simbolos.tipos)
            {
                lineas.Add(@"\s*\(\s*(\s*"+ tipo +variable + @"(\,"+ variable+")*" + @"\s*)*\)\s*");
            }


            return lineas.ToArray();
        }

        private void DefinirDeclaraciones()
        {
            string [] lineas = DefinirLineas();
            string [] parametros = DefinirParametros();
            string [] llaves = { @"(\{\})"};
            string variable = @"[a-zA-Z]";
            string [] espacios = { @"\s*", @"\s+"};
            foreach (string tipo in Simbolos.tipos)
            {
                foreach(string modificador in Simbolos.modificadores) 
                {
                    foreach(string parametro in parametros)
                    {
                        foreach (string llave in llaves) 
                        {
                           patrones.Add(new Regex(modificador + espacios[1] + tipo + espacios[1] + variable + espacios[0] + parametro + llave));
                        }
                    }  
                }
            }
        }
    }
}
