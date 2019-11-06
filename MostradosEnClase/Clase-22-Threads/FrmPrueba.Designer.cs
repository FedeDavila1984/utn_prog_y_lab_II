namespace Clase_22_Threads
{
    partial class FrmPrueba
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
            this.caballito1 = new Caballitos.Caballito();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.barra1 = new BarraDeProgreso.Barra();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caballito1
            // 
            this.caballito1.Location = new System.Drawing.Point(37, 12);
            this.caballito1.Name = "caballito1";
            this.caballito1.Size = new System.Drawing.Size(208, 129);
            this.caballito1.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(154, 198);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(118, 52);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar &Caballo";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // barra1
            // 
            this.barra1.Location = new System.Drawing.Point(47, 147);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(189, 28);
            this.barra1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar &Barra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.caballito1);
            this.Name = "FrmPrueba";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrueba_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Caballitos.Caballito caballito1;
        private System.Windows.Forms.Button btnIniciar;
        private BarraDeProgreso.Barra barra1;
        private System.Windows.Forms.Button button1;
    }
}

