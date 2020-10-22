using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using IDEjames.Sintactico;
namespace IDEjames.Analizador

{
    class AnalizadorTexto
    {

        private Simbolo simbolo;
        private Token token;
        private TablaTransiciones tablaTransiciones;
        private char[] caracteres;
        List<string> errores;
        List<Token> tokens;

        private int contador;
        private int posicionActual;
        private int estadoAMover;
        private String cadena;
        private int estadoActual;

        public AnalizadorTexto()
        {
            token = new Token();
            errores = new List<String>();
            tokens = new List<Token>();
            simbolo = new Simbolo();
            tablaTransiciones = new TablaTransiciones();
        }

        public List<String> AnalizarCodigo(String texto, RichTextBox richTextBox)
        {
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
            while (contador < vueltas)
            {
                avanzar(richTextBox);
            }
            escupirCadena(richTextBox);
            //AGREGANDO COLOR POR DEFECTO DEL RICHTEXTBOXs
            //richTextBox.SetValue(TextElement.ForegroundProperty, Brushes.Black);
            TextRange rangeOfText = new TextRange(richTextBox.Document.ContentEnd, richTextBox.Document.ContentEnd);
            rangeOfText.Text = "\r";
            rangeOfText.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);

            //CREANDO LISTA CON LOS TOKENS Y SUS TIPOS







        }

        public void escupirCadena(RichTextBox richTextBox)
        {
            TextRange rangeOfText = new TextRange(richTextBox.Document.ContentEnd, richTextBox.Document.ContentEnd);
            rangeOfText.Text = cadena;
            rangeOfText.ApplyPropertyValue(TextElement.ForegroundProperty, token.TipoDeToken(estadoActual, cadena).getColor());
            if (token.TipoDeToken(estadoActual, cadena).getColor() == Brushes.Black && cadena.Equals("") == false)
            {
                //rangeOfText.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                errores.Add(cadena);
            }

            //AGREGANDO TOKEN A LA LISTA 
            //VERIFICANDO EL NO AGREGAR TOKENS INECESARIOS
            Token tokenARevisar = token.TipoDeToken(estadoActual, cadena);
            if (tokenARevisar.getTipo() != Token.espacio && tokenARevisar.getTipo() != Token.saltoDeLinea && tokenARevisar.getTipo() != Token.comentario && tokenARevisar.getTipo() != Token.error && tokenARevisar.getTipo() != null)
            {
                tokens.Add(tokenARevisar);
            }

            cadena = "";
        }

        public void avanzar(RichTextBox richTextBox)
        {
            estadoAMover = tablaTransiciones.GetEstadoDestino(estadoActual, simbolo.TipoDeDato(caracteres[contador]));
            Console.WriteLine("estado actual: " + estadoActual + " caracter: " + simbolo.TipoDeDato(caracteres[contador]));
            Console.WriteLine(estadoAMover);
            if (estadoAMover == 0)
            {
                escupirCadena(richTextBox);
                estadoActual = Estado.estadoA;
                avanzar(richTextBox);
            }
            else
            {
                if (estadoAMover == Estado.estadoError)
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
