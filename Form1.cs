using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Simulacro_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEstudiates_Click(object sender, EventArgs e)
        {
            Reg_Esudiantes reg_Esudiantes = new Reg_Esudiantes();
            this.Hide();
            reg_Esudiantes.Show();
        }

        private void buttonTalle_Click(object sender, EventArgs e)
        {
            Reg_Talleres reg_Talleres = new Reg_Talleres();
            this.Hide();
            reg_Talleres.Show();
        }

        private void buttonInscripciones_Click(object sender, EventArgs e)
        {
            Inscripciones inscripciones = new Inscripciones();
            this.Hide();
            inscripciones.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas reporte = new Consultas();
            this.Hide();
            reporte.Show();
        }
    }


}
