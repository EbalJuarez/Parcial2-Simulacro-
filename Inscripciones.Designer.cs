namespace Parcial2_Simulacro_
{
    partial class Inscripciones
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
            this.comboBoxDPI = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.buttonInscribirse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDPI
            // 
            this.comboBoxDPI.FormattingEnabled = true;
            this.comboBoxDPI.Location = new System.Drawing.Point(257, 67);
            this.comboBoxDPI.Name = "comboBoxDPI";
            this.comboBoxDPI.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDPI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el DPI de estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el codigo del taller:";
            // 
            // comboBoxCodigo
            // 
            this.comboBoxCodigo.FormattingEnabled = true;
            this.comboBoxCodigo.Location = new System.Drawing.Point(238, 129);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCodigo.TabIndex = 4;
            // 
            // buttonInscribirse
            // 
            this.buttonInscribirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscribirse.Location = new System.Drawing.Point(287, 182);
            this.buttonInscribirse.Name = "buttonInscribirse";
            this.buttonInscribirse.Size = new System.Drawing.Size(103, 34);
            this.buttonInscribirse.TabIndex = 6;
            this.buttonInscribirse.Text = "Inscribirse";
            this.buttonInscribirse.UseVisualStyleBackColor = true;
            this.buttonInscribirse.Click += new System.EventHandler(this.buttonInscribirse_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInscribirse);
            this.Controls.Add(this.comboBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDPI);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.Inscripciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.Button buttonInscribirse;
        private System.Windows.Forms.Button button1;
    }
}