using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class Simbolo
    {

        private readonly char[] Numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private readonly char[] Letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private readonly char[] SignosAgrupacion = { '(', ')', '}', '{', ',' };
        private readonly char[] SignosAritmeticos = { '*', '/', '+', '-' };
        private readonly char[] SignosRelacionales = { '<', '>', '=', '!' };
        private readonly char[] SignosLogicos = { '|', '&' };
        private readonly char[] SignosAsignacionFinDeSentencia = { '=', ';' };
        private readonly String[] PalabrasReservadas = { "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO", "principal", "leer", "imprimir", "MIENTRAS", "SI", "SINO", "SINO_SI", "HACER", "DESDE", "HASTA", "INCREMENTO", "entero", "cadena" };
        private readonly String[] PalabrasBooleanas = { "verdadero", "falso" };

        public const int Numero = 0;
        public const int asterisco = 1;
        public const int punto = 2;
        public const int guion = 3;
        public const int commillaDoble = 4;
        public const int diagonal = 5;
        public const int espacio = 6;
        public const int signoAgrupacion = 7;
        public const int saltoDeLinea = 8;
        public const int letra = 9;
        public const int guionBajo = 10;
        public const int igual = 11;
        public const int mas = 12;
        public const int signoRelacional = 13;
        public const int diagonalRecta = 14;
        public const int signoY = 15;
        public const int signoFinalizacion = 16;
        public const int caracterFueraDelLenguaje = 17;
        public const int llaveAbre = 18;
        public const int llaveCierra = 19;
        public const int signoComa = 20;


        public int TipoDeDato(char caracter)
        {
            Console.WriteLine("CARACTER: " + caracter);
            if (Numeros.Contains(caracter))
            {
                return Simbolo.Numero;
            }
            else if (caracter.Equals('='))
            {
                return Simbolo.igual;
            }
            else if (SignosRelacionales.Contains(caracter))
            {
                return Simbolo.signoRelacional;
            }
            else if (caracter.Equals('*'))
            {
                return Simbolo.asterisco;
            }
            else if (caracter.Equals('.'))
            {
                return Simbolo.punto;
            }
            else if (caracter.Equals('-'))
            {
                return Simbolo.guion;
            }
            else if (caracter.Equals('_'))
            {
                return Simbolo.guionBajo;
            }
            else if (caracter.Equals('"'))
            {
                return Simbolo.commillaDoble;
            }
            else if (caracter.Equals('/'))
            {
                return Simbolo.diagonal;
            }
            else if (caracter.Equals('+'))
            {
                return Simbolo.mas;
            }
            else if (caracter.Equals(';'))
            {
                return Simbolo.signoFinalizacion;
            }
            else if (SignosAgrupacion.Contains(caracter))
            {
                return Simbolo.signoAgrupacion;
            }
            else if (caracter.Equals('|'))
            {
                return Simbolo.diagonalRecta;
            }
            else if (caracter.Equals('&'))
            {
                return Simbolo.signoY;
            }
            else if (caracter.Equals(' '))
            {
                return Simbolo.espacio;
            }
            else if (caracter.Equals('\n') || caracter.Equals('\r') || caracter.Equals('\n' + '\r'))
            {
                return Simbolo.saltoDeLinea;
            }
            else if (Letras.Contains(caracter))
            {
                return Simbolo.letra;
            }
            else
            {
                return caracterFueraDelLenguaje;
            }
        }

        public Boolean EsPalabraReservada(String identificador)
        {
            if (PalabrasReservadas.Contains(identificador))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsPalabraBooleana(String identificador)
        {
            if (PalabrasBooleanas.Contains(identificador))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
