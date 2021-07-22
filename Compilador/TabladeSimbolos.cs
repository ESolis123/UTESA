using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    public class TabladeSimbolos
    {
        private string texto;
        public string AnalizarTabladeSimbolos(string txtTexto)
        {
            BuscarTokens(txtTexto);

            return texto;
        }

        private void LlenarTabladeSimbolos(List <string[,]> tokens)
        {
            int t = 0;
            foreach (string[,] token in tokens)
            {
                texto += "\n";
                texto += tokens[t][0,0] + "\t";
                texto += RetornarTipo(int.Parse(tokens[t][0,1]));
                texto += "\r";
                t++;
            }
        }

        private string RetornarTipo(int type)
        {
            switch (type)
            {
                case 0: return "Modificador de acceso";
                case 1: return "Operadores aritmeticos";
                case 2: return "Palabras reservadas";
                case 3: return "Signos";
                case 4: return "Tipos";
                case 5: return "Operadores Booleanos";
                case 6: return "Variables";
            }

            return "";
        }

        private void BuscarTokens (string texto)
        {
            texto = texto.Replace("(", " ( ");
            texto = texto.Replace("{", " { ");
            string[] separados = texto.Split();
            List <string[,]> tokens = new List<string[,]>();
            List <List<string>> simbolos = new List<List<string>>()
            {
                Simbolos.modificadores,
                Simbolos.operadoresAritmeticos,
                Simbolos.palabrasReservadas,
                Simbolos.signos,
                Simbolos.tipos,
                Simbolos.operadoresBooleanos
            };

            foreach(string token in separados)
            {
                Console.WriteLine(token);
                int s= 0;
                bool found = false;
                foreach(List<string> simbolo in simbolos)
                {
                    if(simbolo.Contains(token))
                    {
                        Console.WriteLine(s);
                        tokens.Add(new string[,]{{$"{token}",$"{s}"}});
                        found=true;
                        break;
                    }
                    s++;
                }

                if (!found)
                    tokens.Add(new string[,] { { $"{token}", $"{simbolos.Count}" } });
            }

            LlenarTabladeSimbolos(tokens);
        }
    }
}

