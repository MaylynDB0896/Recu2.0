using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class CursoPresencial : Curso
    {
        

        public string Aula { get; set; }

        public CursoPresencial()
        {
            
        }
        public CursoPresencial(string aula)
        {
            this.Aula = aula;
        }

        public override string IniciarCurso(string nombre)
        {
            return $"Esta iniciando el curso {nombre} de manera preciencial";
        }
    }
}
