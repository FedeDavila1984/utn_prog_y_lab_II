namespace WindowsFormsApplication1
{
    partial class miFormulario
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.txtTextBox1 = new System.Windows.Forms.TextBox();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.lblTextBox1 = new System.Windows.Forms.Label();
            this.lblTextBox2 = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(138, 132);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(146, 44);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "Botón con MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // txtTextBox1
            // 
            this.txtTextBox1.Location = new System.Drawing.Point(90, 40);
            this.txtTextBox1.Name = "txtTextBox1";
            this.txtTextBox1.Size = new System.Drawing.Size(194, 20);
            this.txtTextBox1.TabIndex = 1;
            this.txtTextBox1.TextChanged += new System.EventHandler(this.txtTextBox1_TextChanged);
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Location = new System.Drawing.Point(12, 16);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(72, 13);
            this.lblComboBox.TabIndex = 2;
            this.lblComboBox.Text = "Mi ComboBox";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-",
            "*",
            "+"});
            this.comboBox1.Location = new System.Drawing.Point(90, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(90, 66);
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.Size = new System.Drawing.Size(194, 20);
            this.txtTextBox2.TabIndex = 4;
            this.txtTextBox2.TextChanged += new System.EventHandler(this.txtTextBox2_TextChanged);
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.AutoSize = true;
            this.lblTextBox1.Location = new System.Drawing.Point(12, 43);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(69, 13);
            this.lblTextBox1.TabIndex = 5;
            this.lblTextBox1.Text = "Mi TextBox 1";
            // 
            // lblTextBox2
            // 
            this.lblTextBox2.AutoSize = true;
            this.lblTextBox2.Location = new System.Drawing.Point(12, 69);
            this.lblTextBox2.Name = "lblTextBox2";
            this.lblTextBox2.Size = new System.Drawing.Size(69, 13);
            this.lblTextBox2.TabIndex = 6;
            this.lblTextBox2.Text = "Mi TextBox 2";
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.Location = new System.Drawing.Point(12, 97);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 13);
            this.lblMensajes.TabIndex = 7;
            // 
            // miFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 188);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.lblTextBox2);
            this.Controls.Add(this.lblTextBox1);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.txtTextBox1);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "miFormulario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.TextBox txtTextBox1;
        private System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTextBox2;
        private System.Windows.Forms.Label lblTextBox1;
        private System.Windows.Forms.Label lblTextBox2;
        private System.Windows.Forms.Label lblMensajes;
    }
}

