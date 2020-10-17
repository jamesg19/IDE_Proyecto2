using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class Produccion
    {
        private string valorAsignado;

        public const int MP = 100;
        public const int MP1 = 101;
        public const int I = 102;
        public const int I1 = 103;
        public const int I2 = 104;
        public const int L = 105;
        public const int L1 = 106;

        public const int W = 116;
        public const int W1 = 117;
        public const int W2 = 118;
        public const int D = 119;
        public const int D0 = 120;
        public const int D1 = 121;
        public const int F = 122;
        public const int F1 = 123;
        public const int F2 = 124;

        public const int INICIAL = 125;

        public void setValorAsignado(string valorAsignado)
        {
            this.valorAsignado = valorAsignado;
        }

        public string getValorAsignado()
        {
            return this.valorAsignado;
        }
    }
}
