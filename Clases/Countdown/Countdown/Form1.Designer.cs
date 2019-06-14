namespace Countdown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblParcialCountProg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalCountProg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinalCountLab = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblParcialCountLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblParcialCountProg
            // 
            this.lblParcialCountProg.AutoSize = true;
            this.lblParcialCountProg.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcialCountProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblParcialCountProg.Location = new System.Drawing.Point(12, 74);
            this.lblParcialCountProg.Name = "lblParcialCountProg";
            this.lblParcialCountProg.Size = new System.Drawing.Size(189, 65);
            this.lblParcialCountProg.TabIndex = 0;
            this.lblParcialCountProg.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "2º Parcial Prog. II";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "FINAL Prog. II";
            // 
            // lblFinalCountProg
            // 
            this.lblFinalCountProg.AutoSize = true;
            this.lblFinalCountProg.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCountProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFinalCountProg.Location = new System.Drawing.Point(12, 292);
            this.lblFinalCountProg.Name = "lblFinalCountProg";
            this.lblFinalCountProg.Size = new System.Drawing.Size(189, 65);
            this.lblFinalCountProg.TabIndex = 2;
            this.lblFinalCountProg.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 65);
            this.label3.TabIndex = 7;
            this.label3.Text = "FINAL Lab. II";
            // 
            // lblFinalCountLab
            // 
            this.lblFinalCountLab.AutoSize = true;
            this.lblFinalCountLab.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCountLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFinalCountLab.Location = new System.Drawing.Point(12, 753);
            this.lblFinalCountLab.Name = "lblFinalCountLab";
            this.lblFinalCountLab.Size = new System.Drawing.Size(189, 65);
            this.lblFinalCountLab.TabIndex = 6;
            this.lblFinalCountLab.Text = "label1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(12, 470);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(507, 65);
            this.label.TabIndex = 5;
            this.label.Text = "2º Parcial Lab. II";
            // 
            // lblParcialCountLab
            // 
            this.lblParcialCountLab.AutoSize = true;
            this.lblParcialCountLab.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcialCountLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblParcialCountLab.Location = new System.Drawing.Point(12, 535);
            this.lblParcialCountLab.Name = "lblParcialCountLab";
            this.lblParcialCountLab.Size = new System.Drawing.Size(189, 65);
            this.lblParcialCountLab.TabIndex = 4;
            this.lblParcialCountLab.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 774);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinalCountLab);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblParcialCountLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinalCountProg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParcialCountProg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblParcialCountProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalCountProg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinalCountLab;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblParcialCountLab;
    }
}

