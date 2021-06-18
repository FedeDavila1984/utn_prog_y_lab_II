
namespace HilosEventos
{
    partial class FrmTest
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
            this.rtbArchivo = new System.Windows.Forms.RichTextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbArchivo
            // 
            this.rtbArchivo.Location = new System.Drawing.Point(12, 27);
            this.rtbArchivo.Name = "rtbArchivo";
            this.rtbArchivo.Size = new System.Drawing.Size(776, 344);
            this.rtbArchivo.TabIndex = 0;
            this.rtbArchivo.Text = "";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(643, 377);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(144, 61);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripToolStripMenuItem
            // 
            this.menuStripToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opción1ToolStripMenuItem,
            this.opción2ToolStripMenuItem});
            this.menuStripToolStripMenuItem.Name = "menuStripToolStripMenuItem";
            this.menuStripToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.menuStripToolStripMenuItem.Text = "Menu Strip";
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opción1ToolStripMenuItem.Text = "Opción 1";
            // 
            // opción2ToolStripMenuItem
            // 
            this.opción2ToolStripMenuItem.Name = "opción2ToolStripMenuItem";
            this.opción2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opción2ToolStripMenuItem.Text = "Opción 2";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.rtbArchivo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArchivo;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción2ToolStripMenuItem;
    }
}

