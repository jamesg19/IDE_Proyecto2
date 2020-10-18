
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

        public Pila()
        {
            pila = new List<int>();
        }

        public void AgregarElemento(int elemento)
        {
            pila.Add(elemento);
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
        }

        public int RecuperarElemento(int indice)
        {
            return pila.ElementAt(indice - 1);
        }

        public void Reiniciar()
        {
            this.pila.Clear();
            this.pila.Add(Lexema.ACEPTACION);
            this.pila.Add(Produccion.INICIAL);
        }



    }
}
