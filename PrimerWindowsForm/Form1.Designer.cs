namespace PrimerWindowsForm
{
    partial class Form1
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarNombreAp = new System.Windows.Forms.RichTextBox();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(329, 255);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(277, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hola papa, esto es WindowsForms";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(253, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarNuevoToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // cargarNuevoToolStripMenuItem
            // 
            this.cargarNuevoToolStripMenuItem.Name = "cargarNuevoToolStripMenuItem";
            this.cargarNuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarNuevoToolStripMenuItem.Text = "Cargar nuevo";
            this.cargarNuevoToolStripMenuItem.Click += new System.EventHandler(this.cargarNuevoToolStripMenuItem_Click);
            // 
            // mostrarNombreAp
            // 
            this.mostrarNombreAp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mostrarNombreAp.Location = new System.Drawing.Point(543, 184);
            this.mostrarNombreAp.Name = "mostrarNombreAp";
            this.mostrarNombreAp.Size = new System.Drawing.Size(195, 184);
            this.mostrarNombreAp.TabIndex = 4;
            this.mostrarNombreAp.Text = "";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrarNombreAp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Aceptar;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem cargarNuevoToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private RichTextBox mostrarNombreAp;
    }
}