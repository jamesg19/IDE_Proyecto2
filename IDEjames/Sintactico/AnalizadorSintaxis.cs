using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class AnalizadorSintaxis
    {
        TablaAnalisisSintactico tablaAnalisisSintactico;
        int produccionActual;
        Token lexemaActual;
        Pila pila;
        int vuelta;
        int[] produccion;

        public AnalizadorSintaxis()
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

                    SolicitarLexema(vuelta, tokens);

                    VerificarAnulabilidad();
                    SolicitarProduccion();
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

        private void SolicitarProduccion()
        {
            if (lexemaActual != null)
            {
                Console.WriteLine("SOLICITANDO PRODUCCION");

                produccionActual = pila.RecuperarUltimoElemento();
                Console.WriteLine("PRODUCCION ACTUAL: " + produccionActual);
                Console.WriteLine("LEXEMA ACTUAL: " + lexemaActual.getTipo());
                produccion = tablaAnalisisSintactico.recuperarProduccion(produccionActual, lexemaActual);

                //ANTES ELIMINAMOS LA PRODUCCION ANCTUAL PARA REALIZAR EL SHIFT
                pila.EliminarUltimoElemento();

                AgregarProduccionPila(produccion);

                VerificarAnulabilidad();
            }



        }

        private void VerificarAnulabilidad()
        {
            if (lexemaActual != null)
            {
                Console.WriteLine("VERIFICANDO ANULABILIDAD");
                Console.WriteLine("TIPO LEXEMA: " + lexemaActual.getTipo());
                Console.WriteLine("TIPO ELEMENTO PILA: " + pila.RecuperarUltimoElemento());
                if (lexemaActual.getTipo() == pila.RecuperarUltimoElemento())
                {
                    Reduce();
                }
                else
                {
                    Shift();
                }
            }

        }

        private void SolicitarLexema(int posicion, List<Token> tokens)
        {
            Console.WriteLine("SOLICITANDO LEXEMA");
            lexemaActual = Lexema.FiltroLexema(tokens.ElementAt(posicion));
            Console.WriteLine("LEXEMA OBTENIDO: " + lexemaActual.getTipo());
        }

        private void AgregarProduccionPila(int[] produccion)
        {
            Console.WriteLine("AGREGANDO PRODUCCION A LA PILA");
            if (produccion != null)
            {
                if (produccion.Length == 0)
                {
                    pila.AgregarElemento(Lexema.VACIO);
                    ReduceVacio();
                    VerificarAnulabilidad();
                }
                else
                {
                    for (int i = produccion.Length; i > 0; i--)
                    {
                        pila.AgregarElemento(produccion[i - 1]);
                    }
                }
            }


        }

        private void Reduce()
        {
            Console.WriteLine("REDUCE");
            lexemaActual = null;
            pila.EliminarUltimoElemento();
            vuelta++;

        }

        private void ReduceVacio()
        {
            Console.WriteLine("REDUCE VACIO");
            pila.EliminarUltimoElemento();
        }

        private void Shift()
        {
            if (pila.RecuperarUltimoElemento() > 99)
            {
                Console.WriteLine("SHIFT");
                SolicitarProduccion();
                VerificarAnulabilidad();
            }
            else
            {
                Console.WriteLine("NO SE PUEDE REALIZAR EL REDUCE");
                throw new Exception();
            }

        }
    }
}
