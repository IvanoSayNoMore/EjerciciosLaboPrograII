namespace ContadorPalabras
{
    partial class ContadorDePalabras
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
            this.rchTextIn = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTextIn
            // 
            this.rchTextIn.Location = new System.Drawing.Point(130, 50);
            this.rchTextIn.Name = "rchTextIn";
            this.rchTextIn.Size = new System.Drawing.Size(353, 72);
            this.rchTextIn.TabIndex = 0;
            this.rchTextIn.Text = "";
        
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(267, 164);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ContadorDePalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 312);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.rchTextIn);
            this.Name = "ContadorDePalabras";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTextIn;
        private System.Windows.Forms.Button btnCargar;
    }
}

