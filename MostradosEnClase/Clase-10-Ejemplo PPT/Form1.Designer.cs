namespace Clase_10_Ejemplo_PPT
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
            this.btnTocame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTocame
            // 
            this.btnTocame.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTocame.Location = new System.Drawing.Point(74, 50);
            this.btnTocame.Name = "btnTocame";
            this.btnTocame.Size = new System.Drawing.Size(302, 158);
            this.btnTocame.TabIndex = 0;
            this.btnTocame.Text = "Tocame!";
            this.btnTocame.UseVisualStyleBackColor = true;
            this.btnTocame.Click += new System.EventHandler(this.btnTocame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(446, 275);
            this.Controls.Add(this.btnTocame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTocame;
    }
}

