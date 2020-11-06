using IDEjames.Sintactico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Arbol
{
    class FiltroProduccionLexema
    {
        public static string AgregarNodos(int[] produccionesLexemas, string nodoPadre, ValorProduccionLexema valorProduccionLexema)
        {
            string codigo = "";
            for (int i = 0; i < produccionesLexemas.Length; i++)
            {
                codigo += nodoPadre + " -> " + valorProduccionLexema.RecuperarValorProduccionLexema(produccionesLexemas[i]) + " ; ";
            }
            return codigo;
        }

        public static string FiltrarProduccionLexema(int produccionLexema)
        {
            //VERIFICANDO SI SON LEXEMANAS
            if (produccionLexema == Lexema.ACEPTACION)
            {
                return "$";
            }
            else if (produccionLexema == Lexema.CAD)
            {
                return "CADENA";
            }
            else if (produccionLexema == Lexema.NUM)
            {
                return "NUMERO";
            }
            else if (produccionLexema == Lexema.IDENT)
            {
                return "IDENTIFICADOR";
            }
            else if (produccionLexema == Lexema.INC)
            {
                return "INCREMENTO";
            }
            else if (produccionLexema == Lexema.SINO)
            {
                return "SINO";
            }
            else if (produccionLexema == Lexema.SINO_SI)
            {
                return "SINO_SI";
            }
            else if (produccionLexema == Lexema.IDENT)
            {
                return "IDENTIFICADOR";
            }
            else if (produccionLexema == Lexema.OPRE)
            {
                return "OPERADOR RELACIONAL";
            }
            else if (produccionLexema == Lexema.PRI)
            {
                return "IMPRIMIR";
            }
            else if (produccionLexema == Lexema.PARENTESIS_ABRE)
            {
                return "(";
            }
            else if (produccionLexema == Lexema.PARENTESIS_CIERRA)
            {
                return ")";
            }
            else if (produccionLexema == Lexema.IGUAL)
            {
                return "=";
            }
            else if (produccionLexema == Lexema.SIGNO_SUMA)
            {
                return "+";
            }
            else if (produccionLexema == Lexema.LLAVE_ABRE)
            {
                return "{";
            }
            else if (produccionLexema == Lexema.LLAVE_CIERRA)
            {
                return "}";
            }
            else if (produccionLexema == Lexema.COMA)
            {
                return ",";
            }
            else if (produccionLexema == Lexema.PUNTO_COMA)
            {
                return ";";
            }
            else if (produccionLexema == Lexema.PR)
            {
                return "PALABRA RESERVADA";
            }
            else if (produccionLexema == Lexema.IMP)
            {
                return "IMPRIMIR";
            }
            else if (produccionLexema == Lexema.LE)
            {
                return "LEER";
            }
            else if (produccionLexema == Lexema.SI)
            {
                return "SI";
            }
            else if (produccionLexema == Lexema.MI)
            {
                return "MIENTRAS";
            }
            else if (produccionLexema == Lexema.HAS)
            {
                return "HASTA";
            }
            else if (produccionLexema == Lexema.HA)
            {
                return "HACER";
            }
            else if (produccionLexema == Lexema.DES)
            {
                return "DESDE";
            }
            else if (produccionLexema == Lexema.VACIO)
            {
                return "ε";
            }
            else if (produccionLexema == Lexema.SIGNO_RESTA)
            {
                return "-";
            }
            else if (produccionLexema == Lexema.SIGNO_MULTIPLICACION)
            {
                return "*";
            }
            else if (produccionLexema == Lexema.SIGNO_DIVISION)
            {
                return "/";
            }
            else if (produccionLexema == Lexema.SIGNO_INCREMENTO)
            {
                return "++";
            }
            else if (produccionLexema == Lexema.SIGNO_DISMINUCION)
            {
                return "--";
            }
            else
            {
                return "NO IDENTIFICADO";
            }
        }



    }
}
