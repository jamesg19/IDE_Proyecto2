using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Arbol
{
    class ControladorConsola
    {

        string strCmdText;


        public void EjecutarComando(String comando)
        {
            string strCmdText;
            strCmdText = "'/C cd " + comando + " && dot -Tjpg prueba1.dot.txt -o a.jpg '";
            Process.Start("CMD.exe", strCmdText); ;

        }


    }
}
