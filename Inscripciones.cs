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
    public partial class Inscripciones : Form
    {
        List<InscripcionesClase> Lista_Inscripciones = new List<InscripcionesClase>();
        List<Estudiantes>Lista_Estudiantes = new List<Estudiantes>();
        List<Talleres> Lista_Talleres = new List<Talleres>();
        Procesos Procesos = new Procesos();
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void buttonInscribirse_Click(object sender, EventArgs e)
        {
            InscripcionesClase inscripciones = new InscripcionesClase();
            inscripciones.Codigo = comboBoxCodigo.SelectedItem.ToString();
            inscripciones.Fecha = DateTime.Now;
            foreach (var estudiante in Lista_Estudiantes)
            {
                if (comboBoxDPI.SelectedItem.ToString() == estudiante.Nombre) { 
                    inscripciones.DPI = estudiante.DPI;
                }
            }
            Lista_Inscripciones.Add(inscripciones);
            Procesos.GuardarJsonInscripciones("../../Registro_Inscripciones",Lista_Inscripciones);
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            Lista_Estudiantes = Procesos.LeerJsonEstudiantes("../../Registro_Estudiantes");
            Lista_Talleres = Procesos.LeerJsonTalleres("../../Registro_Talleres");

            foreach (var estudiates in Lista_Estudiantes) { 
                comboBoxDPI.Items.Add(estudiates.Nombre);
            }
            foreach (var taller in Lista_Talleres) {
                comboBoxCodigo.Items.Add(taller.Codigo);
            }
        }
    }
}
