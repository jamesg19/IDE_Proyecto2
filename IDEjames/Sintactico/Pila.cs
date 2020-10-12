
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
        private Nodo UltimoValorIngresado;
        public Pila()
        {
            UltimoValorIngresado = null;
        }

        //metodo para insertar dentro de una pila
        public void Insertar(char valor)
        {
            Nodo nuevo_nodo = new Nodo();
            nuevo_nodo.informacion = valor;
            if (UltimoValorIngresado == null)
            {
                nuevo_nodo.siguiente = null;
                UltimoValorIngresado = nuevo_nodo;


            }
            else
            {
                nuevo_nodo.siguiente = UltimoValorIngresado;
                UltimoValorIngresado = nuevo_nodo;

            }

        }

        //Metodo para extraer de la pila
        public char Extraer()
        {
            if (UltimoValorIngresado != null)
            {
                char informacion = UltimoValorIngresado.informacion;
                UltimoValorIngresado = UltimoValorIngresado.siguiente;
                return informacion;
            }
            else
            {
                return char.MaxValue;
            }
        }
        //metodo para comprobar si la pila esta vacia
        public Boolean PilaVacia()
        {
            return UltimoValorIngresado == null;
        }


    }
}
