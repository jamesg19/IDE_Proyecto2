using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Windows.Media;
using IDEjames.Sintactico;

namespace IDEjames.Analizador
{
    class AnalizadorTexto
    {
        private Simbolo simbolo;
        private Token token;
        private Tabla tablaTransiciones;
        private char[] caracteres;
        List<string> errores;
        List<Token> tokens;

        private int contador;
        private int posicionActual;
        private int estadoAMover;
        private String cadena;
        private int estadoActual;

        //variables para los datos respecto a la posicion
        private int columna;
        private int fila;

        public int getColumna()
        {
            return this.columna;
        }

        public int getFila()
        {
            return this.fila;
        }

        public AnalizadorTexto()
        {
            token = new Token();
            errores = new List<String>();
            tokens = new List<Token>();
            simbolo = new Simbolo();
            tablaTransiciones = new Tabla();
        }

        public List<String> AnalizarCodigo(String texto, RichTextBox richTextBox)
        {
            columna = 0;
            fila = 0;

            contador = 0;
            errores.Clear();
            SepararCaracteres(texto);
            Analizar(richTextBox);
            LimpiarDatos();
            return errores;
        }



        public void SepararCaracteres(String texto)
        {
            caracteres = texto.ToCharArray();
            posicionActual = caracteres.Length;
        }

        private void Analizar(RichTextBox richTextBox)
        {
            int vueltas = caracteres.Length - 2;
            estadoActual = Estado.estadoA;
            cadena = "";
            //Console.WriteLine("numero de caracteres " + caracteres.Length);
            while (contador<vueltas)
            {
                //VALIDANDO SI HAY CAMBIO DE LINEA
                //---------------------------------------------
                if (simbolo.TipoDeDato(caracteres[contador]) == Simbolo.saltoDeLinea)
                {
                    //HAY SALDO DE LINEA POR LO TANTO ->
                    Console.WriteLine("HAY SALTO DE LINEA");
                    fila++;
                }
                //---------------------------------------------

                avanzar(richTextBox);
            }
            escupirCadena(richTextBox);

        }

        public void escupirCadena(RichTextBox richTextBox)
        {

            if (token.TipoDeToken(estadoActual, cadena).getColor() == System.Drawing.Brushes.Black && cadena.Equals("") == false)
            {

                errores.Add(cadena);
            }

            Token tokenARevisar = token.TipoDeToken(estadoActual, cadena);
            if (tokenARevisar.getTipo() != Token.espacio && tokenARevisar.getTipo() != Token.saltoDeLinea && tokenARevisar.getTipo() != Token.comentario && tokenARevisar.getTipo() != Token.error && tokenARevisar.getTipo() != null)
            {
                Console.WriteLine("ESTA ES LA FILA A AGREGAR: " + fila);
                tokenARevisar.setFila(fila);
                tokens.Add(tokenARevisar);
            }

            cadena = "";
        }

        public void avanzar(RichTextBox richTextBox)
        {

            estadoAMover = tablaTransiciones.GetEstadoDestino(estadoActual, simbolo.TipoDeDato(caracteres[contador]));
            Console.WriteLine("estado actual: "+estadoActual+" caracter: "+simbolo.TipoDeDato(caracteres[contador]));
            Console.WriteLine(estadoAMover);
            if (estadoAMover == 0)
            {
                escupirCadena(richTextBox);
                estadoActual = Estado.estadoA;
                avanzar(richTextBox);
            }
            else
            {
                if (estadoAMover==Estado.estadoError)
                {
                    escupirCadena(richTextBox);
                    cadena = "";
                    estadoActual = Estado.estadoError;
                    cadena += caracteres[contador];
                    
                    escupirCadena(richTextBox);
                    estadoActual = Estado.estadoA;
                    contador++;
                    cadena = "";
                }
                else
                {
                    estadoActual = estadoAMover;
                    cadena += caracteres[contador];
                    contador++;
                }
                
            }

        }

               

        public void LimpiarDatos()
        {
            cadena = "";
            estadoActual = Estado.estadoA;
            caracteres = null;
        }

        public List<Token> getTokens()
        {
            return this.tokens;
        }
    }
}
