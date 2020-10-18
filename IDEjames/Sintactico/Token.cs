using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class Token
    {
        private Simbolo simbolo;

        public readonly char[] Numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public readonly char[] Letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public readonly char[] SignosAgrupacion = { '(', ')', '}', '{' };
        public readonly char[] SignosAritmeticos = { '*', '/', '+', '-' };
        public readonly char[] SignosLogicos = { '|', '&' };
        public readonly char[] SignosAsignacionFinDeSentencia = { '=', ';' };

        //AGREGAR ARREGLOS
        public readonly string[] OperadoresRelacionales = { "<", ">", "=", "!=", "==", "<=", ">=" };
        public readonly string[] OperadoresAritmeticos = { "*", "/", "+", "-", "++", "--" };
        public readonly string[] SignosDeAgrupacion = { "(", ")", "}", "{", "," };
        public readonly string[] OperadoresLogicos = { "||", "&&" };
        public readonly string[] PalabrasReservadas = { "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO", "principal", "leer", "imprimir", "MIENTRAS", "SI", "SINO", "SINO_SI", "HACER", "DESDE", "HASTA", "INCREMENTO", "entero", "cadena" };
        public readonly string[] PalabrasBooleanas = { "verdadero", "falso" };

        public const int palabraReservada = 1;
        public const int booleano = 2;
        public const int identificador = 3;
        public const int cadena = 4;
        public const int numero = 5;
        public const int espacio = 6;
        public const int saltoDeLinea = 7;
        public const int error = 8;
        public const int comentario = 9;
        public const int signoIgual = 10;
        public const int signoPuntoYComa = 11;
        public const int operadorAritmetico = 12;
        public const int operadorRelacional = 13;
        public const int signoAgrupacion = 14;
        public const int operadorLogico = 15;
        public const int signoComa = 16;


        private string Palabra;
        private int Tipo;
        private Brush Color;


        public Token()
        {
            simbolo = new Simbolo();
        }

        public Token(string Palabra, int Tipo, Brush Color)
        {
            simbolo = new Simbolo();
            this.Palabra = Palabra;
            this.Tipo = Tipo;
            this.Color = Color;
        }


        public Token TipoDeToken(int estado, String cadena)
        {
            if (estado == Estado.estadoB1)
            {
                return new Token(cadena, Simbolo.letra, Brushes.Brown);
            }
            else if (estado == Estado.estadoC1)
            {
                if (simbolo.EsPalabraReservada(cadena))
                {
                    return new Token(cadena, Token.palabraReservada, Brushes.Green);
                }
                else if (simbolo.EsPalabraBooleana(cadena))
                {
                    return new Token(cadena, Token.booleano, Brushes.Orange);
                }
                else
                {
                    return new Token(cadena, Token.identificador, Brushes.DarkGoldenrod);
                }
            }
            else if (estado == Estado.estadoC2)
            {
                return new Token(cadena, Token.cadena, Brushes.DarkGoldenrod);
            }
            else if (estado == Estado.estadoB3 || estado == Estado.estadoC4 || estado == Estado.estadoSA || estado == Estado.estadoSA4 || estado == Estado.estadoSA1 || estado == Estado.estadoSA2 || estado == Estado.estadoSA3 || estado == Estado.estadoSR1 || estado == Estado.estadoSR2 || estado == Estado.estadoSL3 || estado == Estado.estadoSL4)
            {
                if (cadena.Equals(";"))
                {
                    return new Token(cadena, Token.signoPuntoYComa, Brushes.Pink);
                }
                else if (cadena.Equals(","))
                {
                    return new Token(cadena, Token.signoComa, Brushes.OrangeRed);
                }
                else if (cadena.Equals("="))
                {
                    return new Token(cadena, Token.signoIgual, Brushes.Pink);
                }
                else if (OperadoresRelacionales.Contains(cadena))
                {
                    return new Token(cadena, Token.operadorRelacional, Brushes.Blue);
                }
                else if (OperadoresAritmeticos.Contains(cadena))
                {
                    return new Token(cadena, Token.operadorAritmetico, Brushes.Blue);
                }
                else if (SignosDeAgrupacion.Contains(cadena))
                {
                    Console.WriteLine("CADENA:" + cadena);
                    return new Token(cadena, Token.signoAgrupacion, Brushes.Blue);
                }
                else if (OperadoresLogicos.Contains(cadena))
                {
                    return new Token(cadena, Token.operadorLogico, Brushes.Blue);
                }
                else
                {
                    return new Token(cadena, Token.error, Brushes.Black);
                }

            }
            else if (estado == Estado.estadoC3 || estado == Estado.estadoE3 || estado == Estado.estadoF3 || estado == Estado.estadoI3)
            {
                return new Token(cadena, Token.comentario, Brushes.Red);
            }
            else if (estado == Estado.estadoB4)
            {
                return new Token(cadena, Token.numero, Brushes.Purple);
            }
            else if (estado == Estado.estadoE4)
            {
                return new Token(cadena, Token.numero, Brushes.SkyBlue);
            }
            else if (estado == Estado.estadoE)
            {
                return new Token(cadena, Token.espacio, Brushes.Transparent);
            }
            else if (estado == Estado.estadoJ)
            {
                return new Token(cadena, Token.saltoDeLinea, Brushes.Transparent);
            }
            else if (estado == Estado.estadoError)
            {
                return new Token(cadena, Token.error, Brushes.Black);
            }
            else
            {
                return new Token(cadena, Token.error, Brushes.Black);
            }
        }


        public void setPalabra(String palabra)
        {
            this.Palabra = palabra;
        }

        public void setTipo(int tipo)
        {
            this.Tipo = tipo;
        }

        public void setColor(Brush color)
        {
            this.Color = color;
        }


        public string getPalabra()
        {
            return Palabra;
        }

        public int getTipo()
        {
            return Tipo;
        }

        public Brush getColor()
        {
            return Color;
        }
    }
}
