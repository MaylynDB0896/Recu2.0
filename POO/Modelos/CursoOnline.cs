using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class CursoOnline : Curso
    {
        public string Plataforma { get; set; }
        public string URL { get; set; }

        public override string IniciarCurso(string nombre)
        {
            return $"Esta iniciando el curso {nombre} de manera online";
        }
    }
}
