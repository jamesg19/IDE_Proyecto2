using IDEjames.Arbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class ErrorSintactico
    {
        private int fila;
        private string tokenQueSeEsperaba;

        public ErrorSintactico(int fila, int lexemaQueSeEsperaba)
        {
            this.fila = fila;
            this.tokenQueSeEsperaba = FiltroProduccionLexema.FiltrarProduccionLexema(lexemaQueSeEsperaba);
        }

        public int GetFila()
        {
            return fila;
        }

        public string GetTokenQueSeEsperaba()
        {
            return tokenQueSeEsperaba;
        }

    }
}
