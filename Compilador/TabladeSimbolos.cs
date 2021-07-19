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
            List<string> palabrasReservadas = BuscarTokens(txtTexto.ToLower(), Simbolos.palabrasReservadas);
            List<string> signos = BuscarTokens(txtTexto.ToLower(), Simbolos.signos);
            List<string> operadoresAritmeticos = BuscarTokens(txtTexto.ToLower(), Simbolos.operadoresAritmeticos);
            List<string> operadoresBooleanos = BuscarTokens(txtTexto.ToLower(), Simbolos.operadoresBooleanos);
            List<string> tipos = BuscarTokens(txtTexto.ToLower(), Simbolos.tipos);
            List<string> modificadores = BuscarTokens(txtTexto.ToLower(), Simbolos.modificadores);

            LlenarTabladeSimbolos(modificadores, Tokens.Modificadores);
            LlenarTabladeSimbolos(tipos, Tokens.Tipos);
            LlenarTabladeSimbolos(signos, Tokens.Signos);
            LlenarTabladeSimbolos(palabrasReservadas, Tokens.Reservadas);
            LlenarTabladeSimbolos(operadoresAritmeticos, Tokens.OperadoresAritmeticos);
            LlenarTabladeSimbolos(operadoresBooleanos, Tokens.OperadoresBooleanos);
            
            
            return texto;
        }
        private void LlenarTabladeSimbolos(List<string> lista, Tokens token)
        {
            foreach (string type in lista)
            {
                texto += "\n";
                texto += type + "\t";
                texto += RetornarTipo(token);
                texto += "\r";
            }
        }


        private string RetornarTipo(Tokens token)
        {
            Console.WriteLine(token);
             switch (token)
            {
                case Tokens.Reservadas: return "Palabra Reservada";
                case Tokens.Signos: return "Signos";
                case Tokens.OperadoresAritmeticos: return "Operadores Aritmeticos";
                case Tokens.OperadoresBooleanos: return "Operadores Booleanos";
                case Tokens.Tipos: return "Tipo";
                case Tokens.Modificadores: return "Modificador de acceso";
            }

            return "";
        }

        private List<string> BuscarTokens (string texto, List <string> simbolos)
        {
            List<string> enElCodigo = EncontrarEnElCodigo(texto, simbolos);
            return enElCodigo;
        }


        private List<string> EncontrarEnElCodigo(string texto, List<string> listaTokens)
        {
            List<string> lista = new List<string>();

            foreach (string reservada in listaTokens)
            {
                if (texto.Contains(reservada))
                {
                    lista.Add(reservada);
                }
            }

            return lista;
        }
    }

}

