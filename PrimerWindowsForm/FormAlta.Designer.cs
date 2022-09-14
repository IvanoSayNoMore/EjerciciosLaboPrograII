namespace PrimerWindowsForm
{
    partial class FormAlta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.cargar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Alta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(217, 142);
            this.textNombre.Name = "textNombre";
            this.textNombre.PlaceholderText = "Ingrese nombre";
            this.textNombre.Size = new System.Drawing.Size(339, 23);
            this.textNombre.TabIndex = 1;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(217, 193);
            this.textApellido.Name = "textApellido";
            this.textApellido.PlaceholderText = "Ingrese Apellido";
            this.textApellido.Size = new System.Drawing.Size(339, 23);
            this.textApellido.TabIndex = 2;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(217, 260);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 3;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(481, 260);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private Button cargar;
        private Button cancelar;
    }
}