using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Sintactico
{
    class ValorProduccionLexema
    {


        int VINC = 0;
        int VSINO = 0;
        int VSINO_SI = 0;
        int VOPRE = 0;
        int VPRI = 0;
        int VPARENTESIS_ABRE = 0;
        int VPARENTESIS_CIERRA = 0;
        int VIGUAL = 0;
        int VSIGNO_SUMA = 0;
        int VLLAVE_ABRE = 0;
        int VLLAVE_CIERRA = 0;
        int VCOMA = 0;
        int VPUNTO_COMA = 0;
        int VCAD = 0;
        int VNUM = 0;
        int VIDENT = 0;
        int VPR = 0;
        int VIMP = 0;
        int VLE = 0;
        int VSI = 0;
        int VMI = 0;
        int VHA = 0;
        int VDES = 0;
        int VACEPTACION = 0;
        int VVACIO = 0;
        int VSIGNO_RESTA = 0;
        int VSIGNO_MULTIPLICACION = 0;
        int VSIGNO_DIVISION = 0;
        int VSIGNO_INCREMENTO = 0;
        int VSIGNO_DISMINUCION = 0;
        int VHAS = 0;

        //PRODUCCIONES

        int VMP = 0;
        int VMP1 = 0;
        int VI = 0;
        int VI1 = 0;
        int VI2 = 0;
        int V_L = 0;
        int V_L1 = 0;
        int VVL = 0;
        int VVL1 = 0;
        int VVL2 = 0;
        int VVL3 = 0;
        int VS = 0;
        int VS1 = 0;
        int VS2 = 0;
        int VS3 = 0;
        int VS4 = 0;
        int VW = 0;
        int VW1 = 0;
        int VW2 = 0;
        int VD = 0;
        int VD0 = 0;
        int VD1 = 0;
        int VF = 0;
        int VF1 = 0;
        int VF2 = 0;
        int VINICIAL = 0;


        public string RecuperarValorProduccionLexema(int produccionLexema)
        {
            if (produccionLexema == Lexema.INC)
            {
                return "INCREMENTO " + VINC++;
            }
            else if (produccionLexema == Lexema.SINO)
            {
                return "SINO " + VSINO++;
            }
            else if (produccionLexema == Lexema.SINO_SI)
            {
                return "SINO_SI " + VSINO_SI++;
            }
            else if (produccionLexema == Lexema.OPRE)
            {
                return "OPERADOR RELACIONAL " + VOPRE++;
            }
            else if (produccionLexema == Lexema.PRI)
            {
                return "PRINCIPAL " + VPRI++;
            }
            else if (produccionLexema == Lexema.PARENTESIS_ABRE)
            {
                return "( " + VPARENTESIS_ABRE++;
            }
            else if (produccionLexema == Lexema.PARENTESIS_CIERRA)
            {
                return ") " + VPARENTESIS_CIERRA++;
            }
            else if (produccionLexema == Lexema.IGUAL)
            {
                return "= " + VIGUAL++;
            }
            else if (produccionLexema == Lexema.SIGNO_SUMA)
            {
                return "+ " + VSIGNO_SUMA++;
            }
            else if (produccionLexema == Lexema.LLAVE_ABRE)
            {
                return "{ " + VLLAVE_ABRE++;
            }
            else if (produccionLexema == Lexema.LLAVE_CIERRA)
            {
                return "} " + VLLAVE_CIERRA++;
            }
            else if (produccionLexema == Lexema.COMA)
            {
                return ", " + VCOMA++;
            }
            else if (produccionLexema == Lexema.PUNTO_COMA)
            {
                return "; " + VPUNTO_COMA++;
            }
            else if (produccionLexema == Lexema.CAD)
            {
                return "CADENA " + VCAD++;
            }
            else if (produccionLexema == Lexema.NUM)
            {
                return "NUMERO " + VNUM++;
            }
            else if (produccionLexema == Lexema.IDENT)
            {
                return "IDENTIFICADOR " + VIDENT++;
            }
            else if (produccionLexema == Lexema.PR)
            {
                return "PALABRA RESERVADA " + VPR++;
            }
            else if (produccionLexema == Lexema.IMP)
            {
                return "IMPRIMIR " + VIMP++;
            }
            else if (produccionLexema == Lexema.LE)
            {
                return "LEER " + VLE++;
            }
            else if (produccionLexema == Lexema.SI)
            {
                return "SI " + VSI++;
            }
            else if (produccionLexema == Lexema.MI)
            {
                return "MIENTRAS " + VMI++;
            }
            else if (produccionLexema == Lexema.HA)
            {
                return "HACER " + VHA++;
            }
            else if (produccionLexema == Lexema.DES)
            {
                return "DESDE " + VDES++;
            }
            else if (produccionLexema == Lexema.ACEPTACION)
            {
                return "$ " + VACEPTACION++;
            }
            else if (produccionLexema == Lexema.VACIO)
            {
                return "ε " + VVACIO++;
            }
            else if (produccionLexema == Lexema.SIGNO_SUMA)
            {
                return "+ " + VSIGNO_SUMA++;
            }
            else if (produccionLexema == Lexema.SIGNO_RESTA)
            {
                return "- " + VSIGNO_RESTA++;
            }
            else if (produccionLexema == Lexema.SIGNO_MULTIPLICACION)
            {
                return "* " + VSIGNO_MULTIPLICACION++;
            }
            else if (produccionLexema == Lexema.SIGNO_DIVISION)
            {
                return "/ " + VSIGNO_DIVISION++;
            }
            else if (produccionLexema == Lexema.SIGNO_INCREMENTO)
            {
                return "++ " + VSIGNO_INCREMENTO++;
            }
            else if (produccionLexema == Lexema.SIGNO_DISMINUCION)
            {
                return "-- " + VSIGNO_DISMINUCION++;
            }
            else if (produccionLexema == Lexema.HAS)
            {
                return "HASTA " + VHAS++;
            }
            //PRODUCCIONES
            else if (produccionLexema == Produccion.INICIAL)
            {
                return "INICIAL " + VINICIAL++;
            }
            else if (produccionLexema == Produccion.MP)
            {
                return "MP " + VMP++;
            }
            else if (produccionLexema == Produccion.MP1)
            {
                return "MP1 " + VMP1++;
            }
            else if (produccionLexema == Produccion.I)
            {
                return "I " + VI++;
            }
            else if (produccionLexema == Produccion.I1)
            {
                return "I1 " + VI1++;
            }
            else if (produccionLexema == Produccion.I2)
            {
                return "I2 " + VI2++;
            }
            else if (produccionLexema == Produccion.L)
            {
                return "L " + V_L++;
            }
            else if (produccionLexema == Produccion.L1)
            {
                return "L1 " + V_L1++;
            }
            else if (produccionLexema == Produccion.VL)
            {
                return "VL " + VVL++;
            }
            else if (produccionLexema == Produccion.VL1)
            {
                return "VL1 " + VVL1++;
            }
            else if (produccionLexema == Produccion.VL2)
            {
                return "VL2 " + VVL2++;
            }
            else if (produccionLexema == Produccion.VL3)
            {
                return "VL3 " + VVL3++;
            }
            else if (produccionLexema == Produccion.S)
            {
                return "S " + VS++;
            }
            else if (produccionLexema == Produccion.S1)
            {
                return "S1 " + VS1++;
            }
            else if (produccionLexema == Produccion.S2)
            {
                return "S2 " + VS2++;
            }
            else if (produccionLexema == Produccion.S3)
            {
                return "S3 " + VS3++;
            }
            else if (produccionLexema == Produccion.S4)
            {
                return "S4 " + VS4++;
            }
            else if (produccionLexema == Produccion.W)
            {
                return "W " + VW++;
            }
            else if (produccionLexema == Produccion.W1)
            {
                return "W1" + VW1++;
            }
            else if (produccionLexema == Produccion.W2)
            {
                return "W2 " + VW2++;
            }
            else if (produccionLexema == Produccion.D)
            {
                return "D " + VD++;
            }
            else if (produccionLexema == Produccion.D1)
            {
                return "D1 " + VD1++;
            }
            else if (produccionLexema == Produccion.D0)
            {
                return "D0 " + VD0++;
            }
            else if (produccionLexema == Produccion.F)
            {
                return "D1 " + VF++;
            }
            else if (produccionLexema == Produccion.F1)
            {
                return "F1 " + VF1++;
            }
            else if (produccionLexema == Produccion.F2)
            {
                return "F2 " + VF2++;
            }
            else
            {
                return "---";
            }
        }

    }
}
