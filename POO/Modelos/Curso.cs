using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Curso
    {


        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Horarios { get; set; }
        public DateTime Fecha { get; set; }
        public int NumHoras { get; set; }
        public int? Participantes { get; set; }
        public Profesor Profesor { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Curso(string nombre, string ubicacion, string horarios, DateTime fecha, int numHoras, int? participanes)
        {
            this.Nombre =nombre;
            this.Ubicacion = ubicacion; 
            this.Horarios = horarios;
            this.Fecha = fecha;
            this.NumHoras = numHoras;   
            this.Participantes = participanes;
        }

        public Curso()
        {
            
        }

        public Curso(string nombre, string ubicacion, string horarios)
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Horarios = horarios;
        }

        public virtual string IniciarCurso(string nombre) {

            return $"Se ha iniciado el nombre del curso {nombre}";
        }


        public string PasarLista()
        {
            return "Se pasó lista a todos";
        }

        public string PasarLista(List<string> nombres) {

            int numPersonas = 0;

            if (nombres.Count >= 0)
            {
                numPersonas = nombres.Count;
            }

            //if (Nombre.Any())
            //{
            //    numPersonas = nombres.Count;
            //}

            return $"Se pasó lista de {numPersonas} personas";
        }
    
    }
}
