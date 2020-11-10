using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Arbol
{
    class arboll
    {

        private string codigo;
        private string codigoMomentaneo;

        public arboll()
        {
            this.codigo = "digraph G { ";
        }

        public void agregarCodigo(string codigo)
        {


            this.codigo += codigo;
        }

        public string getCodigo()
        {
            return this.codigo;
        }

        public void CerrarArbol()
        {

            this.codigo += " } ";
        }

    }
}
