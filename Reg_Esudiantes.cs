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
    public partial class Reg_Esudiantes : Form
    {
        List<Estudiantes> Lista_Estudiante = new List<Estudiantes>();
        Procesos Procesos = new Procesos();
        public Reg_Esudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.DPI = textBoxDPI.Text;
            estudiantes.Nombre = textBoxNombre.Text;
            estudiantes.Direccion = textBoxDireccion.Text;
            Lista_Estudiante.Add(estudiantes);
            Procesos.GuardarJsonEstudiates("../../Registro_Estudiantes", Lista_Estudiante);
        }
    }
}
