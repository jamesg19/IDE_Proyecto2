
using IDEjames.Arbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IDEjames.Sintactico


{
    class Pila
    {
        private List<int> pila;
        private List<string> pila2;
        private List<string> codigos;

        ValorProduccionLexema valorProduccionLexema;


        public Pila(ValorProduccionLexema valorProduccionLexema)
        {
            pila = new List<int>();
            pila2 = new List<string>();
            codigos = new List<string>();
            this.valorProduccionLexema = valorProduccionLexema;
        }

        public void AgregarElemento(int elemento)
        {
            pila.Add(elemento);
            string valor = valorProduccionLexema.RecuperarValorProduccionLexema(elemento);
            pila2.Add(valor);
            codigos.Add(valor);

        }

        public void LimpiarCodigos()
        {

            codigos.Clear();
        }

        public void AgregarCodigos(arboll arbol, string valorNodoPadre)
        {

            for (int i = codigos.Count(); i > 0; i--)
            {
                arbol.agregarCodigo(valorNodoPadre + " -> " + codigos.ElementAt(i - 1) + " ; ");
            }

        }

        public void AgregarElemento(int elemento, arboll arbol, string valorNodoPadre)
        {
            pila.Add(elemento);
            string valor = valorProduccionLexema.RecuperarValorProduccionLexema(elemento);
            pila2.Add(valor);
            arbol.agregarCodigo(valorNodoPadre + " -> " + valor + " ; ");
            //pinche arbol no funciona :(
        }

        public int RecuperarUltimoElemento()
        {
            return pila.Last();
        }

        public int RecuperarSize()
        {
            return pila.Count;
        }

        public void EliminarUltimoElemento()
        {
            pila.RemoveAt(pila.Count - 1);
            pila2.RemoveAt(pila2.Count - 1);
        }

        public int RecuperarElemento(int indice)
        {
            return pila.ElementAt(indice - 1);
        }

        public string RecuperarValorProduccionLexemaUltimoElemento()
        {
            return pila2.ElementAt(pila2.Count - 1);
        }

        public void Reiniciar(arboll arbol)
        {
            this.AgregarElemento(Lexema.ACEPTACION);
            this.AgregarElemento(Produccion.INICIAL);
            this.AgregarCodigos(arbol, "INICIO");

        }



    }
}
