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
using IDEjames.Arbol;


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
        List<ErrorSintactico> errores;
        ValorProduccionLexema valorProduccionLexema;
        arboll arbol;

        public AnalizadorSintaxis()
        {
            arbol = new arboll();
            valorProduccionLexema = new ValorProduccionLexema();
            tablaAnalisisSintactico = new TablaAnalisisSintactico();
            produccionActual = Produccion.INICIAL;
            pila = new Pila(valorProduccionLexema);
            errores = new List<ErrorSintactico>();

        }

        public void Analizar(List<Token> tokens)
        {
            //AGREGANDO ESTADO FINAL EN LOS TOKENS
            tokens.Add(new Token(null, Lexema.ACEPTACION, null));
            //PROBANDO

            pila.Reiniciar(arbol);
            errores.Clear();

            produccionActual = Produccion.MP;
            vuelta = 0;
            try
            {
                Avanzar(tokens);
            }
            catch
            {
                SegundoAvanzar(tokens);
            }



            arbol.CerrarArbol();

        }

        private void SegundoAvanzar(List<Token> tokens)
        {
            try
            {
                errores.Add(new ErrorSintactico(lexemaActual.getFila(), pila.RecuperarUltimoElemento()));
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
            if (lexemaActual != null)
            {

                produccionActual = pila.RecuperarUltimoElemento();

                produccion = tablaAnalisisSintactico.recuperarProduccion(produccionActual, lexemaActual);


                AgregarProduccionPila(produccion);

                VerificarAnulabilidad();
            }



        }

        private void VerificarAnulabilidad()
        {
            if (lexemaActual != null)
            {

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
            lexemaActual = Lexema.FiltroLexema(tokens.ElementAt(posicion));

        }

        private void AgregarProduccionPila(int[] produccion)
        {
            if (produccion != null)
            {
                string valorNodoPadre = pila.RecuperarValorProduccionLexemaUltimoElemento();

                pila.EliminarUltimoElemento();
                if (produccion.Length == 0)
                {
                    pila.AgregarElemento(Lexema.VACIO, arbol, valorNodoPadre);
                    ReduceVacio();
                    VerificarAnulabilidad();
                }
                else
                {
                    pila.LimpiarCodigos();

                    for (int i = produccion.Length; i > 0; i--)
                    {

                        pila.AgregarElemento(produccion[i - 1]);

                    }

                    //AGREGANDO VALORES
                    pila.AgregarCodigos(arbol, valorNodoPadre);
                }
            }
            else
            {

                throw new Exception();
            }


        }

        private void Reduce()
        {
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
                SolicitarProduccion();
                VerificarAnulabilidad();
            }
            else
            {
              throw new Exception();
            }

        }




        //ERRORES SINTACTICOS
        public void MostrarErrores(String richTextBox)
        {
            for (int i = 0; i < errores.Count(); i++)
            {
               
            }
        }



        public arboll GetArbol()
        {
            return arbol;
        }

        public List<ErrorSintactico> GetErrores()
        {
            return errores;
        }

    }
}
