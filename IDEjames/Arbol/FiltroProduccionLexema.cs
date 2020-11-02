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

        //no lo uso por el momento

        public static string FiltrarProduccionLexema(int produccionLexema)
        {
            if (produccionLexema == Produccion.INICIAL)
            {
                return "INICIAL";
            }
            else if (produccionLexema == Produccion.MP)
            {
                return "MP";
            }
            else if (produccionLexema == Produccion.MP1)
            {
                return "MP1";
            }
            else if (produccionLexema == Produccion.I)
            {
                return "I";
            }
            else if (produccionLexema == Produccion.I1)
            {
                return "I1";
            }
            else if (produccionLexema == Produccion.MP1)
            {
                return "MP1";
            }
            else if (produccionLexema == Produccion.I2)
            {
                return "I1";
            }
            else if (produccionLexema == Produccion.L)
            {
                return "L1";
            }
            else if (produccionLexema == Produccion.L1)
            {
                return "L1";
            }
            else if (produccionLexema == Produccion.VL)
            {
                return "VL";
            }
            else if (produccionLexema == Produccion.VL1)
            {
                return "VL1";
            }
            else if (produccionLexema == Produccion.VL2)
            {
                return "VL2";
            }
            else if (produccionLexema == Produccion.VL3)
            {
                return "VL3";
            }
            else if (produccionLexema == Produccion.S)
            {
                return "S";
            }
            else if (produccionLexema == Produccion.S1)
            {
                return "S1";
            }
            else if (produccionLexema == Produccion.S2)
            {
                return "S2";
            }
            else if (produccionLexema == Produccion.S3)
            {
                return "S3";
            }
            else if (produccionLexema == Produccion.S4)
            {
                return "S4";
            }
            else if (produccionLexema == Produccion.W)
            {
                return "W";
            }
            else if (produccionLexema == Produccion.W1)
            {
                return "W1";
            }
            else if (produccionLexema == Produccion.W2)
            {
                return "W2";
            }
            else if (produccionLexema == Produccion.D)
            {
                return "D";
            }
            else if (produccionLexema == Produccion.D0)
            {
                return "D0";
            }
            else if (produccionLexema == Produccion.D1)
            {
                return "D1";
            }
            else if (produccionLexema == Produccion.F)
            {
                return "F";
            }
            else if (produccionLexema == Produccion.F1)
            {
                return "F1";
            }
            else if (produccionLexema == Produccion.F2)
            {
                return "F2";
            }

            //VERIFICANDO SI SON LEXEMANAS
            else if (produccionLexema == Lexema.ACEPTACION)
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
