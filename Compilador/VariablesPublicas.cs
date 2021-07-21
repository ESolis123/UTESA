using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    [Flags]
    public enum Tokens
    {
        None = 0,
        Reservadas = 1,
        Signos = 2,
        OperadoresAritmeticos = 4,
        OperadoresBooleanos = 8,
        Tipos = 16,
        Modificadores = 32
    }

    public class Simbolos
    {
        public static List<string> palabrasReservadas = new List<string>()
        {
            "if", "switch", "else", "while", "for", "foreach", "do", "end", "begin", "true", "false"
        };

        public static List<string> tipos = new List<string>()
        {
            "int", "bool", "float", "char", "string", "list", "array", "double", "bit"
        };

        public static List<string> signos = new List<string>()
        {
            "(", ")", ";", "_"
        };

        public static List<string> operadoresAritmeticos = new List<string>()
        {
            "+", "-", "*", "/", "++", "--", "+=", "-=", "*=", "/=", "="
        };

        public static List<string> operadoresBooleanos = new List<string>()
        {
            "&&", "||", "!", "!=", "=="
        };

        public static List<string> modificadores = new List<string>()
        {
            "public", "private", "protected"
        };
    }
    
}
