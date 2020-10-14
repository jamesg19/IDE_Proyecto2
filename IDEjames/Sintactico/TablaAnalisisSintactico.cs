using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class AnalisisSistactico

    {
        int numeroFilas = 135;
        int numeroColumnas = 30;
        int[,][] tabla;

        int[] p1 = { Lexema.PRI, Lexema.PARENTESIS_ABRE, Lexema.PARENTESIS_CIERRA, Lexema.LLAVE_ABRE, Produccion.MP1, Lexema.LLAVE_CIERRA };
        int[] p0 = { Produccion.MP };
        int[] vacio = { };
        int[] p2 = { Lexema.SINO, Lexema.LLAVE_ABRE, Produccion.S2, Lexema.LLAVE_CIERRA };
        int[] p3 = { Lexema.SINO_SI, Lexema.PARENTESIS_ABRE, Produccion.S1, Lexema.OPRE, Produccion.S1, Lexema.PARENTESIS_CIERRA, Lexema.LLAVE_ABRE, Produccion.S2, Lexema.LLAVE_CIERRA, Produccion.S3 };
        int[] p4 = { Lexema.IGUAL, Produccion.VL3 };
        int[] p5 = { Lexema.SIGNO_SUMA, Produccion.I1, Produccion.I2 };
        int[] p6 = { Lexema.COMA, Lexema.IDENT, Produccion.VL1 };
        int[] p7 = { Lexema.CAD };
        int[] p8 = { Lexema.NUM };
        int[] p9 = { Lexema.IDENT };
        int[] p10 = { Produccion.VL };
        int[] p11 = { Lexema.PR, Lexema.IDENT, Produccion.VL1, Produccion.VL2, Lexema.PUNTO_COMA };
        int[] p12 = { Produccion.I };
        int[] p13 = { Lexema.IMP, Lexema.PARENTESIS_ABRE, Produccion.I1, Produccion.I2, Lexema.PARENTESIS_CIERRA, Lexema.PUNTO_COMA };
        int[] p14 = { Produccion.L };
        int[] p15 = { Lexema.LE, Lexema.PARENTESIS_ABRE, Produccion.L1, Lexema.PARENTESIS_CIERRA, Lexema.PUNTO_COMA };
        int[] p16 = { Produccion.S };
        int[] p17 = { Lexema.SI, Lexema.PARENTESIS_ABRE, Produccion.S1, Lexema.OPRE, Produccion.S1, Lexema.PARENTESIS_CIERRA, Lexema.LLAVE_ABRE, Produccion.S2, Lexema.LLAVE_CIERRA, Produccion.S3, Produccion.S4 };
        int[] p18 = { Produccion.W };
        int[] p19 = { Lexema.MI, Lexema.PARENTESIS_ABRE, Produccion.W1, Lexema.OPRE, Produccion.W1, Lexema.PARENTESIS_CIERRA, Lexema.LLAVE_ABRE, Produccion.W2, Lexema.LLAVE_CIERRA };
        int[] p20 = { Produccion.D };
        int[] p21 = { Lexema.HA, Lexema.LLAVE_ABRE, Produccion.D0, Lexema.LLAVE_CIERRA, Lexema.MI, Lexema.PARENTESIS_ABRE, Produccion.D1, Lexema.OPRE, Produccion.D1, Lexema.PARENTESIS_CIERRA };
        int[] p22 = { Produccion.F };
        int[] p23 = { Lexema.DES, Lexema.IDENT, Lexema.IGUAL, Produccion.F1, Lexema.HAS, Produccion.F1, Lexema.OPRE, Produccion.F1, Lexema.INC, Lexema.NUM, Lexema.LLAVE_ABRE, Produccion.F2, Lexema.LLAVE_CIERRA };

        int[] pm10 = { Produccion.VL, Produccion.MP1 };
        int[] pm12 = { Produccion.I, Produccion.MP1 };
        int[] pm14 = { Produccion.L, Produccion.MP1 };
        int[] pm16 = { Produccion.S, Produccion.MP1 };
        int[] pm18 = { Produccion.W, Produccion.MP1 };
        int[] pm20 = { Produccion.D, Produccion.MP1 };
        int[] pm22 = { Produccion.F, Produccion.MP1 };

        int[] ps10 = { Produccion.VL, Produccion.S2 };
        int[] ps12 = { Produccion.I, Produccion.S2 };
        int[] ps14 = { Produccion.L, Produccion.S2 };
        int[] ps16 = { Produccion.S, Produccion.S2 };
        int[] ps18 = { Produccion.W, Produccion.S2 };
        int[] ps20 = { Produccion.D, Produccion.S2 };
        int[] ps22 = { Produccion.F, Produccion.S2 };

        int[] pw10 = { Produccion.VL, Produccion.W2 };
        int[] pw12 = { Produccion.I, Produccion.W2 };
        int[] pw14 = { Produccion.L, Produccion.W2 };
        int[] pw16 = { Produccion.S, Produccion.W2 };
        int[] pw18 = { Produccion.W, Produccion.W2 };
        int[] pw20 = { Produccion.D, Produccion.W2 };
        int[] pw22 = { Produccion.F, Produccion.W2 };

        int[] pd10 = { Produccion.VL, Produccion.D0 };
        int[] pd12 = { Produccion.I, Produccion.D0 };
        int[] pd14 = { Produccion.L, Produccion.D0 };
        int[] pd16 = { Produccion.S, Produccion.D0 };
        int[] pd18 = { Produccion.W, Produccion.D0 };
        int[] pd20 = { Produccion.D, Produccion.D0 };
        int[] pd22 = { Produccion.F, Produccion.D0 };

        int[] pf10 = { Produccion.VL, Produccion.F2 };
        int[] pf12 = { Produccion.I, Produccion.F2 };
        int[] pf14 = { Produccion.L, Produccion.F2 };
        int[] pf16 = { Produccion.S, Produccion.F2 };
        int[] pf18 = { Produccion.W, Produccion.F2 };
        int[] pf20 = { Produccion.D, Produccion.F2 };
        int[] pf22 = { Produccion.F, Produccion.F2 };

        public TablaAnalisisSintactico()
        {
            tabla = new int[numeroFilas, numeroColumnas][];
            AsignarValores();
        }


    }
}
