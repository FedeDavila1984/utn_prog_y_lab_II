
namespace Downloader
{
    partial class FrmTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDescargar1 = new System.Windows.Forms.Button();
            this.btnDescargar2 = new System.Windows.Forms.Button();
            this.btnDescargar3 = new System.Windows.Forms.Button();
            this.rtbResponse1 = new System.Windows.Forms.RichTextBox();
            this.rtbResponse2 = new System.Windows.Forms.RichTextBox();
            this.rtbResponse3 = new System.Windows.Forms.RichTextBox();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.txtUrl3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDescargar1
            // 
            this.btnDescargar1.Location = new System.Drawing.Point(12, 36);
            this.btnDescargar1.Name = "btnDescargar1";
            this.btnDescargar1.Size = new System.Drawing.Size(123, 64);
            this.btnDescargar1.TabIndex = 0;
            this.btnDescargar1.Text = "Descargar 1";
            this.btnDescargar1.UseVisualStyleBackColor = true;
            this.btnDescargar1.Click += new System.EventHandler(this.btnDescargar1_Click);
            // 
            // btnDescargar2
            // 
            this.btnDescargar2.Location = new System.Drawing.Point(12, 153);
            this.btnDescargar2.Name = "btnDescargar2";
            this.btnDescargar2.Size = new System.Drawing.Size(123, 64);
            this.btnDescargar2.TabIndex = 1;
            this.btnDescargar2.Text = "Descargar 2";
            this.btnDescargar2.UseVisualStyleBackColor = true;
            this.btnDescargar2.Click += new System.EventHandler(this.btnDescargar2_Click);
            // 
            // btnDescargar3
            // 
            this.btnDescargar3.Location = new System.Drawing.Point(12, 271);
            this.btnDescargar3.Name = "btnDescargar3";
            this.btnDescargar3.Size = new System.Drawing.Size(123, 64);
            this.btnDescargar3.TabIndex = 2;
            this.btnDescargar3.Text = "Descargar 3";
            this.btnDescargar3.UseVisualStyleBackColor = true;
            this.btnDescargar3.Click += new System.EventHandler(this.btnDescargar3_Click);
            // 
            // rtbResponse1
            // 
            this.rtbResponse1.Location = new System.Drawing.Point(141, 36);
            this.rtbResponse1.Name = "rtbResponse1";
            this.rtbResponse1.Size = new System.Drawing.Size(647, 64);
            this.rtbResponse1.TabIndex = 3;
            this.rtbResponse1.Text = "";
            // 
            // rtbResponse2
            // 
            this.rtbResponse2.Location = new System.Drawing.Point(141, 153);
            this.rtbResponse2.Name = "rtbResponse2";
            this.rtbResponse2.Size = new System.Drawing.Size(647, 64);
            this.rtbResponse2.TabIndex = 4;
            this.rtbResponse2.Text = "";
            // 
            // rtbResponse3
            // 
            this.rtbResponse3.Location = new System.Drawing.Point(141, 271);
            this.rtbResponse3.Name = "rtbResponse3";
            this.rtbResponse3.Size = new System.Drawing.Size(647, 64);
            this.rtbResponse3.TabIndex = 5;
            this.rtbResponse3.Text = "";
            // 
            // txtUrl1
            // 
            this.txtUrl1.Location = new System.Drawing.Point(12, 7);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(776, 23);
            this.txtUrl1.TabIndex = 6;
            this.txtUrl1.Text = "https://www.multiledmkt.com.ar/ws_mocks/test";
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(12, 124);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(776, 23);
            this.txtUrl2.TabIndex = 7;
            this.txtUrl2.Text = "https://www.multiledmkt.com.ar/ws_mocks/editor/projects/1";
            // 
            // txtUrl3
            // 
            this.txtUrl3.Location = new System.Drawing.Point(12, 242);
            this.txtUrl3.Name = "txtUrl3";
            this.txtUrl3.Size = new System.Drawing.Size(776, 23);
            this.txtUrl3.TabIndex = 8;
            this.txtUrl3.Text = "https://www.multiledmkt.com.ar/ws_mocks/editor/projects";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.txtUrl3);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.txtUrl1);
            this.Controls.Add(this.rtbResponse3);
            this.Controls.Add(this.rtbResponse2);
            this.Controls.Add(this.rtbResponse1);
            this.Controls.Add(this.btnDescargar3);
            this.Controls.Add(this.btnDescargar2);
            this.Controls.Add(this.btnDescargar1);
            this.Name = "FrmTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescargar1;
        private System.Windows.Forms.Button btnDescargar2;
        private System.Windows.Forms.Button btnDescargar3;
        private System.Windows.Forms.RichTextBox rtbResponse1;
        private System.Windows.Forms.RichTextBox rtbResponse2;
        private System.Windows.Forms.RichTextBox rtbResponse3;
        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.TextBox txtUrl3;
    }
}

