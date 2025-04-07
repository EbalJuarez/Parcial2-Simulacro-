namespace Parcial2_Simulacro_
{
    partial class Form1
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
            this.buttonEstudiates = new System.Windows.Forms.Button();
            this.buttonTalle = new System.Windows.Forms.Button();
            this.buttonInscripciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEstudiates
            // 
            this.buttonEstudiates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstudiates.Location = new System.Drawing.Point(147, 83);
            this.buttonEstudiates.Name = "buttonEstudiates";
            this.buttonEstudiates.Size = new System.Drawing.Size(114, 41);
            this.buttonEstudiates.TabIndex = 0;
            this.buttonEstudiates.Text = "Estudiantes";
            this.buttonEstudiates.UseVisualStyleBackColor = true;
            this.buttonEstudiates.Click += new System.EventHandler(this.buttonEstudiates_Click);
            // 
            // buttonTalle
            // 
            this.buttonTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTalle.Location = new System.Drawing.Point(147, 158);
            this.buttonTalle.Name = "buttonTalle";
            this.buttonTalle.Size = new System.Drawing.Size(114, 36);
            this.buttonTalle.TabIndex = 1;
            this.buttonTalle.Text = "Talleres";
            this.buttonTalle.UseVisualStyleBackColor = true;
            this.buttonTalle.Click += new System.EventHandler(this.buttonTalle_Click);
            // 
            // buttonInscripciones
            // 
            this.buttonInscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscripciones.Location = new System.Drawing.Point(147, 229);
            this.buttonInscripciones.Name = "buttonInscripciones";
            this.buttonInscripciones.Size = new System.Drawing.Size(114, 35);
            this.buttonInscripciones.TabIndex = 2;
            this.buttonInscripciones.Text = "Inscripciones";
            this.buttonInscripciones.UseVisualStyleBackColor = true;
            this.buttonInscripciones.Click += new System.EventHandler(this.buttonInscripciones_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInscripciones);
            this.Controls.Add(this.buttonTalle);
            this.Controls.Add(this.buttonEstudiates);
            this.Name = "Form1";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEstudiates;
        private System.Windows.Forms.Button buttonTalle;
        private System.Windows.Forms.Button buttonInscripciones;
        private System.Windows.Forms.Button button1;
    }
}

