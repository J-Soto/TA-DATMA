using InterfazDATMA.CursoWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDATMA.util
{
    public class Psicologo_Curso
    {
        private CursoWS.curso curso;
        private CursoWS.grupo grupo;

        public curso Curso { get => curso; set => curso = value; }
        public grupo Grupo { get => grupo; set => grupo = value; }
    }
}
