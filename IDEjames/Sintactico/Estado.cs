using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class Estado
    {
        private readonly int[] EstadosDeAceptacion = { estadoB1, estadoC1, estadoC2, estadoB3, estadoC3, estadoE3, estadoF3, estadoI3, estadoB4, estadoC4, estadoE4, estadoE, estadoSA, estadoJ };

        public const int estadoA = 0;
        public const int estadoB1 = 1;
        public const int estadoC1 = 2;
        public const int estadoB2 = 3;
        public const int estadoC2 = 4;
        public const int estadoD2 = 5;
        public const int estadoB3 = 6;
        public const int estadoC3 = 7;
        public const int estadoD3 = 8;
        public const int estadoE3 = 9;
        public const int estadoF3 = 10;
        public const int estadoG3 = 11;
        public const int estadoH3 = 12;
        public const int estadoI3 = 13;
        public const int estadoB4 = 14;
        public const int estadoC4 = 15;
        public const int estadoD4 = 16;
        public const int estadoE4 = 17;
        public const int estadoSA = 18;
        public const int estadoE = 19;
        public const int estadoJ = 20;
        public const int estadoSA1 = 21;
        public const int estadoSA2 = 22;
        public const int estadoSA3 = 23;
        public const int estadoSA4 = 24;
        public const int estadoSR1 = 25;
        public const int estadoSR2 = 26;
        public const int estadoSL1 = 27;
        public const int estadoSL2 = 28;
        public const int estadoSL3 = 29;
        public const int estadoSL4 = 30;
        public const int estadoSF = 31;
        public const int estadoError = 32;

        public Estado()
        {

        }

        public Boolean EsEstadoDeValidacion(int estado)
        {
            if (EstadosDeAceptacion.Contains(estado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
