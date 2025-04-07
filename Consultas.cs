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
    public partial class Consultas : Form
    {
        Procesos procesos = new Procesos();
        List<Reporte> Lista_Reportes = new List<Reporte>();
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Lista_Reportes = procesos.LeerJsonReporte("../../Registro_Reporte");
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = Lista_Reportes;
        }
    }
}
