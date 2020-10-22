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

        public TablaTransiciones()
        {
            asignarValores();
        }
    }
}
