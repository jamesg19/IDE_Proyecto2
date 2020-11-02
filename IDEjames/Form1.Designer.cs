namespace IDEjames
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoArchivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardarcomoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarErrorAgtEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Posicion = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.Colum = new System.Windows.Forms.Label();
            this.columna = new System.Windows.Forms.Label();
            this.Compilar = new System.Windows.Forms.Button();
            this.rTxtCodigo = new System.Windows.Forms.RichTextBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.rTxtErrores = new System.Windows.Forms.RichTextBox();
            this.Arbol = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem,
            this.SalirMenuItem1,
            this.exportarErrorAgtEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirMenuItem,
            this.NuevoArchivoMenuItem,
            this.GuardarMenuItem,
            this.toolStripSeparator1,
            this.GuardarcomoMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archiveToolStripMenuItem.Text = "Archivo";
            // 
            // AbrirMenuItem
            // 
            this.AbrirMenuItem.Name = "AbrirMenuItem";
            this.AbrirMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AbrirMenuItem.Text = "Abrir";
            this.AbrirMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // NuevoArchivoMenuItem
            // 
            this.NuevoArchivoMenuItem.Name = "NuevoArchivoMenuItem";
            this.NuevoArchivoMenuItem.Size = new System.Drawing.Size(153, 22);
            this.NuevoArchivoMenuItem.Text = "Nuevo Archivo";
            this.NuevoArchivoMenuItem.Click += new System.EventHandler(this.NuevoArchivoToolStripMenuItem_Click);
            // 
            // GuardarMenuItem
            // 
            this.GuardarMenuItem.Name = "GuardarMenuItem";
            this.GuardarMenuItem.Size = new System.Drawing.Size(153, 22);
            this.GuardarMenuItem.Text = "Guardar";
            this.GuardarMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // GuardarcomoMenuItem
            // 
            this.GuardarcomoMenuItem.Name = "GuardarcomoMenuItem";
            this.GuardarcomoMenuItem.Size = new System.Drawing.Size(153, 22);
            this.GuardarcomoMenuItem.Text = "Guardar como";
            this.GuardarcomoMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click_1);
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar archivo";
            this.eliminarArchivoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArchivoToolStripMenuItem_Click);
            // 
            // SalirMenuItem1
            // 
            this.SalirMenuItem1.Name = "SalirMenuItem1";
            this.SalirMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.SalirMenuItem1.Text = "Salir";
            this.SalirMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exportarErrorAgtEToolStripMenuItem
            // 
            this.exportarErrorAgtEToolStripMenuItem.Name = "exportarErrorAgtEToolStripMenuItem";
            this.exportarErrorAgtEToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.exportarErrorAgtEToolStripMenuItem.Text = "Exportar Error a .gtE";
            this.exportarErrorAgtEToolStripMenuItem.Click += new System.EventHandler(this.exportarErrorAgtEToolStripMenuItem_Click);
            // 
            // Posicion
            // 
            this.Posicion.AutoSize = true;
            this.Posicion.Location = new System.Drawing.Point(71, 401);
            this.Posicion.Name = "Posicion";
            this.Posicion.Size = new System.Drawing.Size(32, 13);
            this.Posicion.TabIndex = 4;
            this.Posicion.Text = "FILA:";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(119, 401);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(25, 13);
            this.position.TabIndex = 5;
            this.position.Text = "___";
            // 
            // Colum
            // 
            this.Colum.AutoSize = true;
            this.Colum.Location = new System.Drawing.Point(164, 401);
            this.Colum.Name = "Colum";
            this.Colum.Size = new System.Drawing.Size(51, 13);
            this.Colum.TabIndex = 6;
            this.Colum.Text = "Columna:";
            // 
            // columna
            // 
            this.columna.AutoSize = true;
            this.columna.Location = new System.Drawing.Point(231, 401);
            this.columna.Name = "columna";
            this.columna.Size = new System.Drawing.Size(25, 13);
            this.columna.TabIndex = 7;
            this.columna.Text = "___";
            // 
            // Compilar
            // 
            this.Compilar.BackColor = System.Drawing.Color.YellowGreen;
            this.Compilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compilar.Location = new System.Drawing.Point(435, 390);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(116, 34);
            this.Compilar.TabIndex = 8;
            this.Compilar.Text = "Compilar";
            this.Compilar.UseVisualStyleBackColor = false;
            this.Compilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTxtCodigo
            // 
            this.rTxtCodigo.AcceptsTab = true;
            this.rTxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtCodigo.Location = new System.Drawing.Point(72, 30);
            this.rTxtCodigo.Name = "rTxtCodigo";
            this.rTxtCodigo.Size = new System.Drawing.Size(850, 356);
            this.rTxtCodigo.TabIndex = 9;
            this.rTxtCodigo.Text = "";
            this.rTxtCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.muestraPosicion);
            this.rTxtCodigo.TextChanged += new System.EventHandler(this.rTxtCodigo_TextChanged);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(287, 401);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(22, 13);
            this.lblErrores.TabIndex = 10;
            this.lblErrores.Text = ".....";
            this.lblErrores.Click += new System.EventHandler(this.label1_Click);
            // 
            // rTxtErrores
            // 
            this.rTxtErrores.Location = new System.Drawing.Point(80, 439);
            this.rTxtErrores.Name = "rTxtErrores";
            this.rTxtErrores.Size = new System.Drawing.Size(842, 146);
            this.rTxtErrores.TabIndex = 11;
            this.rTxtErrores.Text = "";
            // 
            // Arbol
            // 
            this.Arbol.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Arbol.BackColor = System.Drawing.Color.YellowGreen;
            this.Arbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arbol.Location = new System.Drawing.Point(577, 390);
            this.Arbol.Name = "Arbol";
            this.Arbol.Size = new System.Drawing.Size(187, 34);
            this.Arbol.TabIndex = 12;
            this.Arbol.Text = "General Imagen Arbol";
            this.Arbol.UseVisualStyleBackColor = false;
            this.Arbol.Click += new System.EventHandler(this.Arbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 609);
            this.Controls.Add(this.Arbol);
            this.Controls.Add(this.rTxtErrores);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.rTxtCodigo);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.columna);
            this.Controls.Add(this.Colum);
            this.Controls.Add(this.position);
            this.Controls.Add(this.Posicion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Compilador de Codigo 2.0 <James></James>";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevoArchivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem1;
        private System.Windows.Forms.Label Posicion;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label Colum;
        private System.Windows.Forms.Label columna;
        private System.Windows.Forms.ToolStripMenuItem GuardarcomoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.Button Compilar;
        private System.Windows.Forms.ToolStripMenuItem exportarErrorAgtEToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rTxtCodigo;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.RichTextBox rTxtErrores;
        private System.Windows.Forms.Button Arbol;
    }
}

