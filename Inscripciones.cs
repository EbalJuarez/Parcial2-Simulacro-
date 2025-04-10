﻿using System;
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
        List<Reporte> Lista_Reportes = new List<Reporte>();
        Procesos Procesos = new Procesos();
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void buttonInscribirse_Click(object sender, EventArgs e)
        {
            InscripcionesClase inscripciones = new InscripcionesClase();
            Reporte reporte = new Reporte();
            inscripciones.Fecha = DateTime.Now;
            reporte.Taller = comboBoxCodigo.SelectedItem.ToString();
            reporte.Nombre = comboBoxDPI.SelectedItem.ToString();   
            foreach (var taller in Lista_Talleres)
            {
                if (comboBoxCodigo.SelectedItem.ToString() == taller.Taller)
                {
                    inscripciones.Codigo = taller.Codigo;
                }
                foreach (var estudiante in Lista_Estudiantes)
                {
                    if (comboBoxDPI.SelectedItem.ToString() == estudiante.Nombre)
                    {
                        inscripciones.DPI = estudiante.DPI;
                    }
                }
                
            }
            Lista_Reportes.Add(reporte);
            Lista_Inscripciones.Add(inscripciones);
            Procesos.GuardarJsonReporte("../../Registro_Reporte", Lista_Reportes);
            Procesos.GuardarJsonInscripciones("../../Registro_Inscripciones", Lista_Inscripciones);
        }


        private void Inscripciones_Load(object sender, EventArgs e)
        {
            Lista_Estudiantes = Procesos.LeerJsonEstudiantes("../../Registro_Estudiantes");
            Lista_Talleres = Procesos.LeerJsonTalleres("../../Registro_Talleres");

            foreach (var estudiates in Lista_Estudiantes) { 
                comboBoxDPI.Items.Add(estudiates.Nombre);
            }
            foreach (var taller in Lista_Talleres) {
                comboBoxCodigo.Items.Add(taller.Taller);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
