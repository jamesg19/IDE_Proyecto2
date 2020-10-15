
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

        ValorProduccionLexema valorProduccionLexema;


        public Pila(ValorProduccionLexema valorProduccionLexema)
        {
            pila = new List<int>();
            pila2 = new List<string>();
            this.valorProduccionLexema = valorProduccionLexema;
        }

        public void AgregarElemento(int elemento, Arbol arbol, string valorNodoPadre)
        {
            pila.Add(elemento);
            string valor = valorProduccionLexema.RecuperarValorProduccionLexema(elemento);
            pila2.Add(valor);
            arbol.agregarCodigo(valorNodoPadre + " -> " + valor + " ; ");
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

        public void Reiniciar(Arbol arbol)
        {
            this.pila.Clear();
            this.AgregarElemento(Lexema.ACEPTACION, arbol, "INICIO");
            this.AgregarElemento(Produccion.INICIAL, arbol, "INICIO");
        }



    }
}
