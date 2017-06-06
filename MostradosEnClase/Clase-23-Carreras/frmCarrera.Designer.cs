namespace Carreras
{
    partial class frmCarrera
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.carril1 = new Caballitos.Caballito();
            this.carril2 = new Caballitos.Caballito();
            this.carril3 = new Caballitos.Caballito();
            this.carril4 = new Caballitos.Caballito();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(604, 569);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(150, 71);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // carril1
            // 
            this.carril1.Location = new System.Drawing.Point(2, 12);
            this.carril1.Name = "carril1";
            this.carril1.Size = new System.Drawing.Size(208, 129);
            this.carril1.TabIndex = 8;
            // 
            // carril2
            // 
            this.carril2.Location = new System.Drawing.Point(2, 147);
            this.carril2.Name = "carril2";
            this.carril2.Size = new System.Drawing.Size(208, 129);
            this.carril2.TabIndex = 9;
            // 
            // carril3
            // 
            this.carril3.Location = new System.Drawing.Point(2, 282);
            this.carril3.Name = "carril3";
            this.carril3.Size = new System.Drawing.Size(208, 129);
            this.carril3.TabIndex = 10;
            // 
            // carril4
            // 
            this.carril4.Location = new System.Drawing.Point(2, 429);
            this.carril4.Name = "carril4";
            this.carril4.Size = new System.Drawing.Size(208, 129);
            this.carril4.TabIndex = 11;
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 652);
            this.Controls.Add(this.carril4);
            this.Controls.Add(this.carril3);
            this.Controls.Add(this.carril2);
            this.Controls.Add(this.carril1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "frmCarrera";
            this.Text = "Carrera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private Caballitos.Caballito carril1;
        private Caballitos.Caballito carril2;
        private Caballitos.Caballito carril3;
        private Caballitos.Caballito carril4;
    }
}

