using IDEjames.Analizador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms; 


namespace IDEjames
{
    public partial class Form1 : Form
    {
        String[] Array=new String[] { };
        DatosPrimitivo Datocadena;
        OperadorLogic logico;
        OperadorAritmetico operadorAritmetico1;
        Comentario comentario;
        OperadorRelacion opeRelacion;
        Entero enteroo;
        PalabrasReservadas reservadas;
        boolean Booleano;
        string archivo;
        Archivo archivoObjeto = new Archivo("");
        
        public Form1()
        {
            InitializeComponent();
            DatosPrimitivo DatoPrimitivoCadena = new DatosPrimitivo("",rTxtCodigo);
            Comentario Comentario = new Comentario("", rTxtCodigo);
            OperadorLogic operadorLogico = new OperadorLogic("", rTxtCodigo);
            OperadorAritmetico operadorAritmetico=new OperadorAritmetico("", rTxtCodigo);
            PalabrasReservadas reservadas = new PalabrasReservadas("", rTxtCodigo);
            OperadorRelacion opeRelacion = new OperadorRelacion("", rTxtCodigo);
            Entero enteroo = new Entero("", rTxtCodigo);
            boolean Booleano = new boolean("", rTxtCodigo);
            this.Datocadena = DatoPrimitivoCadena;
            this.comentario = Comentario;
            this.logico = operadorLogico;
            this.operadorAritmetico1 = operadorAritmetico;
            this.opeRelacion = opeRelacion;
            this.enteroo = enteroo;
            this.reservadas = reservadas;
            this.Booleano = Booleano;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }


        //boton para abrir un nuevo archivo
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo abrir de la clase archivo 
            archivoObjeto.AbrirArchivo(rTxtCodigo);
        }

        //boton para guardar un archivo
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo guardar de la clase archivo 
            archivoObjeto.GuardaArchivo(rTxtCodigo);
        }
        //metodo para crear nuevo archivo
        private void NuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // llama al metodo Nuevo Archivo de la clase archivo 
            // y crea un nuevo archivo
            archivoObjeto.NuevoArchivo(rTxtCodigo);
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            archivoObjeto.GuardarComo(rTxtCodigo);
        }
        //metodo para eliminar el archivo 
        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoObjeto.elimilarArchivo(rTxtCodigo);
        }

        //Salir
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres Salir \n",
                    "Salir: ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                this.Dispose();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        //metodo para guardar el error en archivo de texto .gtE
        private void exportarErrorAgtEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoObjeto.GuardarError(LogError);

        }


        // metodo para sincronizar el richtextBox con el label de numero de linea
        private void TextBox_VScrollChanged(object sender, EventArgs e)
        {

        }

        //muestra la pocion del cursos en cuarquier momento
        private void muestraPosicion(object sender, MouseEventArgs e)
        {
            // Get the line. 
            int index = rTxtCodigo.SelectionStart;
            int line = rTxtCodigo.GetLineFromCharIndex(index);
            position.Text = (line + 1) + "";
            // Get the column. 
            int firstChar = rTxtCodigo.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            columna.Text = column + "";

        }

        public void Determina_Lexema()
        {

            //guarda la posicion del cursor antes de pintar
            int pos = rTxtCodigo.SelectionStart;
            string[] Reservadas = new string[] { ";", "="};

            try
            {
                //PONE TODO EL TEXTO EN EL COLOR POR DEFECTO(FORECOLOR)

                rTxtCodigo.SelectionStart = 0;
                rTxtCodigo.SelectionLength = rTxtCodigo.TextLength;
                rTxtCodigo.SelectionColor = rTxtCodigo.ForeColor;

                foreach (string CLAVE in Reservadas)
                { //COMPRUEBA CADA UNA DE LAS PALABRAS CLAVE

                    int INDEX = 0; //'INICIA LA BUSQUEDA DE LA CLAVE DESDE LA POSICION 0 DEL TEXTO

                    while (INDEX <= rTxtCodigo.Text.LastIndexOf(CLAVE.ToString())) //'RECORRE TODO EL TEXTO BUSCANDO LA PALABRA CLAVE
                    {


                        rTxtCodigo.Find(CLAVE.ToString(), INDEX, rTxtCodigo.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....
                        rTxtCodigo.SelectionColor = Color.Pink; //'... LE PONE EL COLOR INDICADO
                        INDEX = rTxtCodigo.Text.IndexOf(CLAVE, INDEX) + 1; //'AVANZA A LA SIGUIENTE UBICACION DE LA PALABRA CLAVE

                    }
                }

                //CUANDO HA TERMINADO DE BUSCAR TODAS LAS PALABRAS VUELVE A LA SITUACION NORMAL (AL FINAL DEL TEXTO)
                rTxtCodigo.SelectionStart = rTxtCodigo.TextLength;
                rTxtCodigo.SelectionColor = rTxtCodigo.ForeColor;

                // establece el valor del cursor donde se encontraba antes de pintar la palabra con color
                rTxtCodigo.SelectionStart = pos;
                rTxtCodigo.SelectionLength = 0;

            }
            catch (Exception ex)
            {
            }
            LogError.Text = "";
            try
            {
                //agrega las linea
                for (int i = 0; i < rTxtCodigo.Lines.Length; i++)
                {
                    
                    enteroo.Inicial(rTxtCodigo.Lines[i], rTxtCodigo);
                    Booleano.Inicio(rTxtCodigo.Lines[i], rTxtCodigo);
                    operadorAritmetico1.Inicial(rTxtCodigo.Lines[i], rTxtCodigo);
                    reservadas.Inicio(rTxtCodigo.Lines[i], rTxtCodigo);
                    Datocadena.Inicial(rTxtCodigo.Lines[i], rTxtCodigo);
                    logico.Inicial(rTxtCodigo.Lines[i], rTxtCodigo);
                    opeRelacion.Inicial(rTxtCodigo.Lines[i], rTxtCodigo);
                    comentario.Inicial(rTxtCodigo.Lines[i], rTxtCodigo,LogError,i+1);

                }
            }
            catch
            {

            }

        }



        private void LogError_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Determina_Lexema();
        }
        public void AnalizarCodigo()
        {

            AnalizadorSintaxis analizadorSintaxis = new AnalizadorSintaxis();
            analizadorSintaxis.Analizar(analizadorTexto.getTokens());

        }

    }

}