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
    public partial class Reg_Talleres : Form
    {

        List<Talleres> Lista_Talleres = new List<Talleres>();
        Procesos Procesos = new Procesos();
        public Reg_Talleres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void Reg_Talleres_Load(object sender, EventArgs e)
        {
            Talleres talleres = new Talleres();
            talleres.Taller = textBoxNomTaller.Text;
            talleres.Codigo = textBoxCodigo.Text;
            talleres.Costo = float.Parse(textBoxCostoTaller.Text);
            Lista_Talleres.Add(talleres);
            Procesos.GuardarJsonTalleres("../../Registro_Talleres", Lista_Talleres);
        }
    }
}
