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
            this.nudApuesta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTengo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCarril = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudApuesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarril)).BeginInit();
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
            // nudApuesta
            // 
            this.nudApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudApuesta.Location = new System.Drawing.Point(166, 599);
            this.nudApuesta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudApuesta.Name = "nudApuesta";
            this.nudApuesta.Size = new System.Drawing.Size(79, 31);
            this.nudApuesta.TabIndex = 12;
            this.nudApuesta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "¡Su Apuesta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "de";
            // 
            // lblTengo
            // 
            this.lblTengo.AutoSize = true;
            this.lblTengo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTengo.Location = new System.Drawing.Point(289, 601);
            this.lblTengo.Name = "lblTengo";
            this.lblTengo.Size = new System.Drawing.Size(51, 25);
            this.lblTengo.TabIndex = 15;
            this.lblTengo.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "al carril";
            // 
            // nudCarril
            // 
            this.nudCarril.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudCarril.Location = new System.Drawing.Point(436, 599);
            this.nudCarril.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCarril.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCarril.Name = "nudCarril";
            this.nudCarril.Size = new System.Drawing.Size(53, 31);
            this.nudCarril.TabIndex = 17;
            this.nudCarril.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 652);
            this.Controls.Add(this.nudCarril);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTengo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudApuesta);
            this.Controls.Add(this.carril4);
            this.Controls.Add(this.carril3);
            this.Controls.Add(this.carril2);
            this.Controls.Add(this.carril1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "frmCarrera";
            this.Text = "Carrera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudApuesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarril)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private Caballitos.Caballito carril1;
        private Caballitos.Caballito carril2;
        private Caballitos.Caballito carril3;
        private Caballitos.Caballito carril4;
        private System.Windows.Forms.NumericUpDown nudApuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTengo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCarril;
    }
}

