using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEjames.Arbol
{
    class EjecutaConsula
    {

        //cambios de formato de jpg a png
        public void EjecutarComando(string codigo, string path, string NombreArchivo)
        {
            TextWriter textWriter = new StreamWriter(path + "\\" + NombreArchivo);
            textWriter.Write(codigo);
            textWriter.Close();

            string strCmdText = "'/C cd " + path + " && dot -Tpng " + NombreArchivo + " -o arbol.png '";
            Process.Start("CMD.exe", strCmdText); ;

        }


    }
}
