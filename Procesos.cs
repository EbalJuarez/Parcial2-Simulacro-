using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Parcial2_Simulacro_
{
    internal class Procesos
    {
        public void GuardarJsonEstudiates(string nombreArchivo, List<Estudiantes> ListaEstudiantes)
        {
            string json = JsonConvert.SerializeObject(ListaEstudiantes);
            System.IO.File.WriteAllText(nombreArchivo, json);
        }

        public List<Estudiantes> LeerJsonEstudiantes(string nombreArchivo)
        {
            List<Estudiantes> estudiantes = new List<Estudiantes>();
            StreamReader jsonStream = File.OpenText(nombreArchivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            estudiantes = JsonConvert.DeserializeObject<List<Estudiantes>>(json);
            return estudiantes;
        }

        public void GuardarJsonTalleres(string nombreArchivo, List<Talleres> ListaEstudiantes)
        {
            string json = JsonConvert.SerializeObject(ListaEstudiantes);
            System.IO.File.WriteAllText(nombreArchivo, json);
        }

        public List<Talleres> LeerJsonTalleres(string nombreArchivo)
        {
            List<Talleres> estudiantes = new List<Talleres>();
            StreamReader jsonStream = File.OpenText(nombreArchivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            estudiantes = JsonConvert.DeserializeObject<List<Talleres>>(json);
            return estudiantes;
        }

        public void GuardarJsonInscripciones(string nombreArchivo, List<InscripcionesClase> ListaEstudiantes)
        {
            string json = JsonConvert.SerializeObject(ListaEstudiantes);
            System.IO.File.WriteAllText(nombreArchivo, json);
        }

        public List<InscripcionesClase> LeerJsonInscripciones(string nombreArchivo)
        {
            List<InscripcionesClase> estudiantes = new List<InscripcionesClase>();
            StreamReader jsonStream = File.OpenText(nombreArchivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            estudiantes = JsonConvert.DeserializeObject<List<InscripcionesClase>>(json);
            return estudiantes;
        }

        public void GuardarJsonReporte(string nombreArchivo, List<Reporte> ListaEstudiantes)
        {
            string json = JsonConvert.SerializeObject(ListaEstudiantes);
            System.IO.File.WriteAllText(nombreArchivo, json);
        }

        public List<Reporte> LeerJsonReporte(string nombreArchivo)
        {
            List<Reporte> estudiantes = new List<Reporte>();
            StreamReader jsonStream = File.OpenText(nombreArchivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            estudiantes = JsonConvert.DeserializeObject<List<Reporte>>(json);
            return estudiantes;
        }
    }
}
