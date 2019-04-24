namespace Clase_10_Ejemplo_PPT
{
    partial class FrmTransparente
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
            this.btnTocame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTocame
            // 
            this.btnTocame.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTocame.Location = new System.Drawing.Point(71, 12);
            this.btnTocame.Name = "btnTocame";
            this.btnTocame.Size = new System.Drawing.Size(302, 158);
            this.btnTocame.TabIndex = 0;
            this.btnTocame.Text = "Tocame!";
            this.btnTocame.UseVisualStyleBackColor = true;
            this.btnTocame.Click += new System.EventHandler(this.btnTocame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clase_10_Ejemplo_PPT.Properties.Resources.avengers;
            this.pictureBox1.Location = new System.Drawing.Point(190, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTransparente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(446, 275);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTocame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransparente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Lime;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTocame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

