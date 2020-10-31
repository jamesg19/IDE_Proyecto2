using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class Lexema
    {
        public const int INC = 0;
        public const int SINO = 1;
        public const int SINO_SI = 2;
        public const int OPRE = 3;
        public const int PRI = 4;
        public const int PARENTESIS_ABRE = 5;
        public const int PARENTESIS_CIERRA = 6;
        public const int IGUAL = 7;
        public const int SIGNO_SUMA = 8;
        public const int LLAVE_ABRE = 9;
        public const int LLAVE_CIERRA = 10;
        public const int COMA = 11;
        public const int PUNTO_COMA = 12;
        public const int CAD = 13;
        public const int NUM = 14;
        public const int IDENT = 15;
        public const int PR = 16;
        public const int IMP = 17;
        public const int LE = 18;
        public const int SI = 19;
        public const int MI = 20;
        public const int HA = 21;
        public const int DES = 22;
        public const int ACEPTACION = 23;
        public const int VACIO = 24;
        public const int SIGNO_RESTA = 25;
        public const int SIGNO_MULTIPLICACION = 26;
        public const int SIGNO_DIVISION = 27;
        public const int SIGNO_INCREMENTO = 28;
        public const int SIGNO_DISMINUCION = 29;
        public const int HAS = 30;

        public static Token FiltroLexema(Token token)
        {
            if (token.getTipo() == Token.palabraReservada)
            {
                return new Token(token.getPalabra(), TipoDePalabraReservada(token.getPalabra()), null, token.getFila());
            }
            else if (token.getTipo() == Token.identificador)
            {
                return new Token(token.getPalabra(), Lexema.IDENT, null, token.getFila());
            }
            else if (token.getTipo() == Token.signoAgrupacion)
            {
                return new Token(token.getPalabra(), TipoDeSignoDeAgrupacion(token.getPalabra()), null, token.getFila());
            }
            else if (token.getTipo() == Lexema.ACEPTACION)
            {
                return new Token(null, Lexema.ACEPTACION, null, token.getFila());
            }
            else if (token.getTipo() == Token.numero)
            {
                return new Token(null, Lexema.NUM, null, token.getFila());
            }
            else if (token.getTipo() == Token.signoPuntoYComa)
            {
                return new Token(null, Lexema.PUNTO_COMA, null, token.getFila());
            }
            else if (token.getTipo() == Token.signoComa)
            {
                return new Token(null, Lexema.COMA, null, token.getFila());
            }
            else if (token.getTipo() == Token.operadorAritmetico)
            {
                return new Token(token.getPalabra(), TipoDeSignoAritmetico(token.getPalabra()), null, token.getFila());
            }
            else if (token.getTipo() == Token.operadorRelacional)
            {
                return new Token(token.getPalabra(), Lexema.OPRE, null, token.getFila());
            }
            else if (token.getTipo() == Token.signoIgual)
            {
                return new Token(token.getPalabra(), Lexema.IGUAL, null, token.getFila());
            }
            else if (token.getTipo() == Token.cadena)
            {
                return new Token(token.getPalabra(), Lexema.CAD, null, token.getFila());
            }
            else
            {
                return null;
            }
        }

        public static int TipoDePalabraReservada(String palabraReservada)
        {
            if (PalabraReservada.PRINCIPAL.Equals(palabraReservada))
            {
                return Lexema.PRI;
            }
            else if (PalabraReservada.LEER.Equals(palabraReservada))
            {
                return Lexema.LE;
            }
            else if (PalabraReservada.IMPRIMIR.Equals(palabraReservada))
            {
                return Lexema.IMP;
            }
            else if (PalabraReservada.HACER.Equals(palabraReservada))
            {
                return Lexema.HA;
            }
            else if (PalabraReservada.MIENTRAS.Equals(palabraReservada))
            {
                return Lexema.MI;
            }
            else if (PalabraReservada.DESDE.Equals(palabraReservada))
            {
                return Lexema.DES;
            }
            else if (PalabraReservada.HASTA.Equals(palabraReservada))
            {
                return Lexema.HAS;
            }
            else if (PalabraReservada.INCREMENTO.Equals(palabraReservada))
            {
                return Lexema.INC;
            }
            else if (PalabraReservada.SI.Equals(palabraReservada))
            {
                return Lexema.SI;
            }
            else if (PalabraReservada.SINO.Equals(palabraReservada))
            {
                return Lexema.SINO;
            }
            else if (PalabraReservada.SINO_SI.Equals(palabraReservada))
            {
                return Lexema.SINO_SI;
            }
            else
            {
                return Lexema.PR;
            }
        }

        public static int TipoDeSignoDeAgrupacion(String signo)
        {
            if (signo.Equals("("))
            {
                return Lexema.PARENTESIS_ABRE;
            }
            else if (signo.Equals(")"))
            {
                return Lexema.PARENTESIS_CIERRA;
            }
            else if (signo.Equals("{"))
            {
                return Lexema.LLAVE_ABRE;
            }
            else if (signo.Equals("}"))
            {
                return Lexema.LLAVE_CIERRA;
            }
            else if (signo.Equals(","))
            {
                return Lexema.COMA;
            }
            else
            {
                return -1;
            }
        }

        public static int TipoDeSignoAritmetico(String signo)
        {
            if (signo.Equals("+"))
            {
                return Lexema.SIGNO_SUMA;
            }
            else if (signo.Equals("-"))
            {
                return Lexema.SIGNO_RESTA;
            }
            else if (signo.Equals("*"))
            {
                return Lexema.SIGNO_MULTIPLICACION;
            }
            else if (signo.Equals("/"))
            {
                return Lexema.SIGNO_DIVISION;
            }
            else if (signo.Equals("++"))
            {
                return Lexema.SIGNO_INCREMENTO;
            }
            else if (signo.Equals("--"))
            {
                return Lexema.SIGNO_DISMINUCION;
            }
            else
            {
                return -1;
            }
        }

    }
}
