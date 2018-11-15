namespace Ej._71
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsiAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTestDelegados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDatosAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAlta,
            this.tsiMostrar,
            this.tsiDatosAlumno});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsiAlta
            // 
            this.tsiAlta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiTestDelegados,
            this.tsiAlumno});
            this.tsiAlta.Name = "tsiAlta";
            this.tsiAlta.Size = new System.Drawing.Size(40, 20);
            this.tsiAlta.Text = "&Alta";
            // 
            // tsiTestDelegados
            // 
            this.tsiTestDelegados.Name = "tsiTestDelegados";
            this.tsiTestDelegados.Size = new System.Drawing.Size(180, 22);
            this.tsiTestDelegados.Text = "Test Delegados";
            this.tsiTestDelegados.Click += new System.EventHandler(this.tsiTestDelegados_Click);
            // 
            // tsiAlumno
            // 
            this.tsiAlumno.Name = "tsiAlumno";
            this.tsiAlumno.Size = new System.Drawing.Size(180, 22);
            this.tsiAlumno.Text = "Alumno";
            this.tsiAlumno.Click += new System.EventHandler(this.tsiAlumno_Click);
            // 
            // tsiMostrar
            // 
            this.tsiMostrar.Enabled = false;
            this.tsiMostrar.Name = "tsiMostrar";
            this.tsiMostrar.Size = new System.Drawing.Size(60, 20);
            this.tsiMostrar.Text = "&Mostrar";
            this.tsiMostrar.Click += new System.EventHandler(this.tsiMostrar_Click);
            // 
            // tsiDatosAlumno
            // 
            this.tsiDatosAlumno.Enabled = false;
            this.tsiDatosAlumno.Name = "tsiDatosAlumno";
            this.tsiDatosAlumno.Size = new System.Drawing.Size(95, 20);
            this.tsiDatosAlumno.Text = "Datos Alumno";
            this.tsiDatosAlumno.Click += new System.EventHandler(this.datosAlumnoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiAlta;
        private System.Windows.Forms.ToolStripMenuItem tsiMostrar;
        private System.Windows.Forms.ToolStripMenuItem tsiTestDelegados;
        private System.Windows.Forms.ToolStripMenuItem tsiAlumno;
        private System.Windows.Forms.ToolStripMenuItem tsiDatosAlumno;
    }
}

