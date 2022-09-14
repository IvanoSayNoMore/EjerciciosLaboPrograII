namespace Contador_de_Palabras
{
    partial class ContadorPalabras
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
            this.textIn = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(77, 45);
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(384, 96);
            this.textIn.TabIndex = 0;
            this.textIn.Text = "";
         
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(235, 178);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ContadorPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textIn);
            this.Name = "ContadorPalabras";
            this.Text = "Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textIn;
        private System.Windows.Forms.Button btnCargar;
    }
}