using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class AnalizaSintactico
    {
        TablaAnalisisSintactico tablaAnalisisSintactico;
        int produccionActual;
        Token lexemaActual;
        Pila pila;
        int vuelta;
        int[] produccion;

        public AnalizaSintactico()
        {
            tablaAnalisisSintactico = new TablaAnalisisSintactico();
            produccionActual = Produccion.INICIAL;
            pila = new Pila();

        }

        public void Analizar(List<Token> tokens)
        {
            //IMPRIMIENDO NUMERO DE TOKENS
            Console.WriteLine("NUMERO DE TOKENS: " + tokens.Count());
            //AGREGANDO ESTADO FINAL EN LOS TOKENS
            tokens.Add(new Token(null, Lexema.ACEPTACION, null));
            //PROBANDO

            pila.Reiniciar();
            produccionActual = Produccion.MP;
            vuelta = 0;
            try
            {
                Console.WriteLine("TAMANO: " + tokens.Count());
                while (vuelta < tokens.Count())
                {
                    Console.WriteLine("VUELTA: " + vuelta);

                }
            }
            catch
            {
                Console.WriteLine("CAYO EN ERROR");
            }



            //MOSTRANDO SI HAY ERRORES SINTACTICOS
            if (pila.RecuperarSize() == 0)
            {
                Console.WriteLine("\n\n\nNO HAY ERRORES SINTACTICOS");
            }
            else
            {
                Console.WriteLine("\n\n\nHAY ERRORES SINTACTICOS");
            }



        }



    }
}
