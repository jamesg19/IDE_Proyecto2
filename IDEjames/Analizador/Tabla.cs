using IDEjames.Sintactico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Analizador
{
    class Tabla
    {
        int numeroFilas = 40;
        int numeroColumnas = 20;
        int[,] tabla;

        public Tabla()
        {
            asignarValores();
        }

        public void asignarValores()
        {
            tabla = new int[numeroFilas, numeroColumnas];

            tabla[0, 0] = Estado.estadoB4;
            tabla[0, 1] = Estado.estadoSA1;
            tabla[0, 3] = Estado.estadoC4;
            tabla[0, 4] = Estado.estadoB2;
            tabla[0, 5] = Estado.estadoB3;
            tabla[0, 6] = Estado.estadoE;
            tabla[0, 7] = Estado.estadoSA;
            tabla[0, 8] = Estado.estadoJ;
            tabla[0, 9] = Estado.estadoB1;
            tabla[0, 11] = Estado.estadoSR1;
            tabla[1, 0] = Estado.estadoC1;
            tabla[1, 9] = Estado.estadoC1;
            tabla[2, 0] = Estado.estadoC1;
            tabla[2, 9] = Estado.estadoC1;
            tabla[3, 4] = Estado.estadoC2;
            tabla[3, 6] = Estado.estadoD2;
            tabla[3, 9] = Estado.estadoD2;
            tabla[5, 4] = Estado.estadoC2;
            tabla[5, 6] = Estado.estadoD2;
            tabla[5, 9] = Estado.estadoD2;
            tabla[6, 1] = Estado.estadoD3;
            tabla[6, 5] = Estado.estadoC3;
            tabla[7, 6] = Estado.estadoE3;
            tabla[7, 8] = Estado.estadoF3;
            tabla[7, 9] = Estado.estadoE3;
            tabla[8, 1] = Estado.estadoG3;
            tabla[8, 6] = Estado.estadoH3;
            tabla[8, 9] = Estado.estadoH3;
            tabla[9, 6] = Estado.estadoE3;
            tabla[9, 8] = Estado.estadoF3;
            tabla[9, 9] = Estado.estadoE3;
            tabla[11, 5] = Estado.estadoI3;
            tabla[12, 1] = Estado.estadoG3;
            tabla[12, 6] = Estado.estadoH3;
            tabla[12, 9] = Estado.estadoH3;
            tabla[14, 0] = Estado.estadoB4;
            tabla[14, 2] = Estado.estadoD4;
            tabla[15, 0] = Estado.estadoB4;
            tabla[16, 0] = Estado.estadoE4;
            tabla[17, 0] = Estado.estadoE4;
            tabla[18, 7] = Estado.estadoSA;
            tabla[1, 10] = Estado.estadoC1;
            tabla[2, 10] = Estado.estadoC1;
            tabla[0, 1] = Estado.estadoSA1;
            tabla[15, 3] = Estado.estadoSA4;
            tabla[0, 12] = Estado.estadoSA2;
            tabla[22, 12] = Estado.estadoSA3;
            tabla[0, 13] = Estado.estadoSR1;
            tabla[25, 11] = Estado.estadoSR2;
            tabla[0, 14] = Estado.estadoSL1;
            tabla[0, 15] = Estado.estadoSL2;
            tabla[27, 14] = Estado.estadoSL3;
            tabla[28, 15] = Estado.estadoSL4;
            tabla[0, 16] = Estado.estadoSL4;
            tabla[8, 0] = Estado.estadoH3;
            tabla[8, 8] = Estado.estadoH3;
            tabla[12, 0] = Estado.estadoH3;
            tabla[12, 8] = Estado.estadoH3;
            tabla[7, 0] = Estado.estadoE3;
            tabla[9, 0] = Estado.estadoE3;
            tabla[0, 2] = Estado.estadoError;
            tabla[3, 0] = Estado.estadoD2;
            tabla[5, 0] = Estado.estadoD2;
            tabla[0, 10] = Estado.estadoK1;
            tabla[33, 9] = Estado.estadoK2;
            tabla[34, 9] = Estado.estadoK2;
            tabla[34, 0] = Estado.estadoK2;



            for (int i = 0; i < numeroFilas; i++)
            {
                tabla[i, 17] = Estado.estadoError;
            }

        }

        public int GetEstadoDestino(int estadoActual, int simbolo)
        {
            return tabla[estadoActual, simbolo];
        }
    }
}
