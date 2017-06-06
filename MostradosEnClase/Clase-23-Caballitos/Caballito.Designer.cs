namespace Caballitos
{
    partial class Caballito
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_char = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_char)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_char
            // 
            this.pb_char.Location = new System.Drawing.Point(0, 0);
            this.pb_char.Name = "pb_char";
            this.pb_char.Size = new System.Drawing.Size(208, 129);
            this.pb_char.TabIndex = 0;
            this.pb_char.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCaballito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_char);
            this.Name = "FrmCaballito";
            this.Size = new System.Drawing.Size(208, 129);
            ((System.ComponentModel.ISupportInitialize)(this.pb_char)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_char;
        private System.Windows.Forms.Timer timer1;
    }
}
