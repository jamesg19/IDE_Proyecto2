﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace IDEjames.Sintactico
{
    class AnalizadorSintaxis
    {
        TablaAnalisisSintactico tablaAnalisisSintactico;
        int produccionActual;
        Token lexemaActual;
        Pila pila;
        int vuelta;
        int [] produccion;
        List<int> errores;

        public AnalizadorSintaxis()
        {
            tablaAnalisisSintactico = new TablaAnalisisSintactico();
            produccionActual = Produccion.INICIAL;
            pila = new Pila();
            errores = new List<int>();

        }

        public void Analizar(List<Token> tokens)
        {
            //IMPRIMIENDO NUMERO DE TOKENS
            Console.WriteLine("NUMERO DE TOKENS: "+tokens.Count());
            //AGREGANDO ESTADO FINAL EN LOS TOKENS
            tokens.Add(new Token(null, Lexema.ACEPTACION,null));
            //PROBANDO

            pila.Reiniciar();
            errores.Clear();

            produccionActual = Produccion.MP;
            vuelta = 0;
            try
            {
                Console.WriteLine("TAMANO: "+tokens.Count());
                Avanzar(tokens);
            }
            catch
            {
                SegundoAvanzar(tokens); 
            }


            


            //MOSTRANDO SI HAY ERRORES SINTACTICOS
            if (pila.RecuperarSize()==0||errores.Count()==0)
            {
                Console.WriteLine("\n\n\nNO HAY ERRORES SINTACTICOS");
            }
            else
            {
                Console.WriteLine("\n\n\nHAY ERRORES SINTACTICOS");
            }



        }

        private void SegundoAvanzar(List<Token> tokens)
        {
            try
            {
                Console.WriteLine("CAYO EN ERROR");
                errores.Add(lexemaActual.getFila());
                produccionActual = Produccion.INICIAL;
                vuelta++;
                Avanzar(tokens);
            }
            catch
            {
                SegundoAvanzar(tokens);
            }
        }

        private void Avanzar(List<Token> tokens)
        {
            try
            {
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
                throw new Exception();
            }
            
        }

        private void SolicitarProduccion()
        {
            if (lexemaActual!=null)
            {
                Console.WriteLine("SOLICITANDO PRODUCCION");

                produccionActual = pila.RecuperarUltimoElemento();
                Console.WriteLine("PRODUCCION ACTUAL: " + produccionActual);
                Console.WriteLine("LEXEMA ACTUAL: " + lexemaActual.getTipo());
                produccion = tablaAnalisisSintactico.recuperarProduccion(produccionActual, lexemaActual);

                //ANTES ELIMINAMOS LA PRODUCCION ANCTUAL PARA REALIZAR EL SHIFT
                //pila.EliminarUltimoElemento();

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
            Console.WriteLine("LEXEMA OBTENIDO: "+lexemaActual.getTipo());
        }

        private void AgregarProduccionPila(int[] produccion)
        {
            Console.WriteLine("AGREGANDO PRODUCCION A LA PILA");
            if (produccion!=null)
            {
                pila.EliminarUltimoElemento();
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
            else
            {
                //PUEDE GENERAR ERRORES EN ESTE BLOQUE
                Console.WriteLine("NO HAY PRODUCCION DISPONIBLE");
                throw new Exception();
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
            if (pila.RecuperarUltimoElemento()>99)
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




        //ERRORES SINTACTICOS
        public void MostrarErrores(RichTextBox richTextBox, DependencyProperty dependencyProperty ,Object objetoUnderline)
        {
            for (int i=0; i<errores.Count();i++)
            {
                SubrayarError(richTextBox, dependencyProperty, objetoUnderline,errores.ElementAt(i));
            }
        }

        private void SubrayarError(RichTextBox richTextBox, DependencyProperty dependencyProperty, Object objetoUnderline, int fila)
        {
            Console.WriteLine("ESTE ES EL NUMERO DE FILA: "+fila);
            try
            {
                TextPointer inicio = richTextBox.Selection.Start.GetLineStartPosition(fila);
                TextPointer fin = richTextBox.Selection.Start.GetLineStartPosition(fila+1);
                richTextBox.Selection.Select(inicio, fin);
                richTextBox.Selection.ApplyPropertyValue(dependencyProperty, objetoUnderline);
            }
            catch
            {
                try
                {
                    TextPointer inicio = richTextBox.Selection.Start.GetLineStartPosition(fila);
                    TextPointer fin = richTextBox.Selection.Start.GetLineStartPosition(fila);
                    richTextBox.Selection.Select(inicio, fin);
                    richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, objetoUnderline);
                }
                catch
                {

                }
                
            }
        }

    }
}
