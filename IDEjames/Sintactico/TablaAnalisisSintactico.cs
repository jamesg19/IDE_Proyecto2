using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class TablaAnalisisSintactico

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

        private void AsignarValores()
        {
            tabla[Produccion.INICIAL, Lexema.PRI] = p0;
            /*
            tabla[Produccion.INICIAL, Lexema.PR] = p10;
            tabla[Produccion.INICIAL, Lexema.IMP] = p12;
            tabla[Produccion.INICIAL, Lexema.LE] = p14;
            tabla[Produccion.INICIAL, Lexema.SI] = p16;
            tabla[Produccion.INICIAL, Lexema.MI] = p18;
            tabla[Produccion.INICIAL, Lexema.HA] = p20;
            tabla[Produccion.INICIAL, Lexema.DES] = p22;*/


            tabla[Produccion.MP, Lexema.PRI] = p1;
            tabla[Produccion.MP1, Lexema.LLAVE_CIERRA] = vacio;
            tabla[Produccion.MP1, Lexema.PR] = pm10;
            tabla[Produccion.MP1, Lexema.IMP] = pm12;
            tabla[Produccion.MP1, Lexema.LE] = pm14;
            tabla[Produccion.MP1, Lexema.SI] = pm16;
            tabla[Produccion.MP1, Lexema.MI] = pm18;
            tabla[Produccion.MP1, Lexema.HA] = pm20;
            tabla[Produccion.MP1, Lexema.DES] = pm22;

            tabla[Produccion.I, Lexema.IMP] = p13;
            tabla[Produccion.I1, Lexema.CAD] = p7;
            tabla[Produccion.I1, Lexema.NUM] = p8;
            tabla[Produccion.I1, Lexema.IDENT] = p9;
            tabla[Produccion.I2, Lexema.PARENTESIS_CIERRA] = vacio;
            tabla[Produccion.I2, Lexema.SIGNO_SUMA] = p5;
            tabla[Produccion.I2, Lexema.PUNTO_COMA] = vacio;

            tabla[Produccion.L, Lexema.LE] = p15;
            tabla[Produccion.L1, Lexema.CAD] = p7;
            tabla[Produccion.L1, Lexema.NUM] = p8;
            tabla[Produccion.L1, Lexema.IDENT] = p9;

            tabla[Produccion.VL, Lexema.PR] = p11;
            tabla[Produccion.VL1, Lexema.IGUAL] = vacio;
            tabla[Produccion.VL1, Lexema.COMA] = p6;
            tabla[Produccion.VL1, Lexema.PUNTO_COMA] = vacio;
            tabla[Produccion.VL1, Lexema.ACEPTACION] = vacio;
            tabla[Produccion.VL2, Lexema.IGUAL] = p4;
            tabla[Produccion.VL2, Lexema.PUNTO_COMA] = vacio;
            tabla[Produccion.VL3, Lexema.CAD] = p7;
            tabla[Produccion.VL3, Lexema.NUM] = p8;
            tabla[Produccion.VL3, Lexema.IDENT] = p9;

            tabla[Produccion.S, Lexema.SI] = p17;
            tabla[Produccion.S1, Lexema.CAD] = p7;
            tabla[Produccion.S1, Lexema.NUM] = p8;
            tabla[Produccion.S1, Lexema.IDENT] = p9;
            tabla[Produccion.S2, Lexema.SINO] = vacio;
            tabla[Produccion.S2, Lexema.SINO_SI] = vacio;
            tabla[Produccion.S2, Lexema.LLAVE_CIERRA] = vacio;
            tabla[Produccion.S2, Lexema.PR] = ps10;
            tabla[Produccion.S2, Lexema.IMP] = ps12;
            tabla[Produccion.S2, Lexema.LE] = ps14;
            tabla[Produccion.S2, Lexema.SI] = ps16;
            tabla[Produccion.S2, Lexema.MI] = ps18;
            tabla[Produccion.S2, Lexema.HA] = ps20;
            tabla[Produccion.S2, Lexema.DES] = ps22;
            tabla[Produccion.S2, Lexema.ACEPTACION] = vacio;
            tabla[Produccion.S3, Lexema.SINO] = vacio;
            tabla[Produccion.S3, Lexema.SINO_SI] = p3;
            tabla[Produccion.S3, Lexema.ACEPTACION] = vacio;
            tabla[Produccion.S4, Lexema.SINO] = p2;
            tabla[Produccion.S4, Lexema.ACEPTACION] = vacio;

            tabla[Produccion.W, Lexema.MI] = p19;
            tabla[Produccion.W1, Lexema.CAD] = p7;
            tabla[Produccion.W1, Lexema.NUM] = p8;
            tabla[Produccion.W1, Lexema.IDENT] = p9;
            tabla[Produccion.W2, Lexema.LLAVE_CIERRA] = vacio;
            tabla[Produccion.W2, Lexema.PR] = pw10;
            tabla[Produccion.W2, Lexema.IMP] = pw12;
            tabla[Produccion.W2, Lexema.LE] = pw14;
            tabla[Produccion.W2, Lexema.SI] = pw16;
            tabla[Produccion.W2, Lexema.MI] = pw18;
            tabla[Produccion.W2, Lexema.HA] = pw20;
            tabla[Produccion.W2, Lexema.DES] = pw22;

            tabla[Produccion.D, Lexema.HA] = p21;
            tabla[Produccion.D0, Lexema.OPRE] = vacio;
            tabla[Produccion.D0, Lexema.PARENTESIS_ABRE] = vacio;
            tabla[Produccion.D0, Lexema.PARENTESIS_CIERRA] = vacio;
            tabla[Produccion.D0, Lexema.LLAVE_CIERRA] = vacio;
            tabla[Produccion.D0, Lexema.CAD] = vacio;
            tabla[Produccion.D0, Lexema.NUM] = vacio;
            tabla[Produccion.D0, Lexema.IDENT] = vacio;
            tabla[Produccion.D0, Lexema.PR] = pd10;
            tabla[Produccion.D0, Lexema.IMP] = pd12;
            tabla[Produccion.D0, Lexema.LE] = pd14;
            tabla[Produccion.D0, Lexema.SI] = pd16;
            tabla[Produccion.D0, Lexema.MI] = pd18;
            tabla[Produccion.D0, Lexema.HA] = pd20;
            tabla[Produccion.D0, Lexema.DES] = pd22;
            tabla[Produccion.D1, Lexema.CAD] = p7;
            tabla[Produccion.D1, Lexema.NUM] = p8;
            tabla[Produccion.D1, Lexema.IDENT] = p9;

            tabla[Produccion.F, Lexema.DES] = p23;
            tabla[Produccion.F1, Lexema.NUM] = p8;
            tabla[Produccion.F1, Lexema.IDENT] = p9;
            tabla[Produccion.F2, Lexema.LLAVE_CIERRA] = vacio;
            tabla[Produccion.F2, Lexema.PR] = pf10;
            tabla[Produccion.F2, Lexema.IMP] = pf12;
            tabla[Produccion.F2, Lexema.LE] = pf14;
            tabla[Produccion.F2, Lexema.SI] = pf16;
            tabla[Produccion.F2, Lexema.MI] = pf18;
            tabla[Produccion.F2, Lexema.HA] = pf20;
            tabla[Produccion.F2, Lexema.DES] = pf22;

        }

        public int[] recuperarProduccion(int produccion, Token token)
        {
            return tabla[produccion, token.getTipo()];
        }


    }
}
