namespace FormDialogs
{
    partial class frmFormPpal
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
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnFormDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(12, 12);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(260, 20);
            this.txtRespuesta.TabIndex = 0;
            // 
            // btnFormDialog
            // 
            this.btnFormDialog.Location = new System.Drawing.Point(167, 56);
            this.btnFormDialog.Name = "btnFormDialog";
            this.btnFormDialog.Size = new System.Drawing.Size(105, 46);
            this.btnFormDialog.TabIndex = 1;
            this.btnFormDialog.Text = "Form Dialog";
            this.btnFormDialog.UseVisualStyleBackColor = true;
            this.btnFormDialog.Click += new System.EventHandler(this.btnFormDialog_Click);
            // 
            // frmFormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.btnFormDialog);
            this.Controls.Add(this.txtRespuesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnFormDialog;
    }
}

