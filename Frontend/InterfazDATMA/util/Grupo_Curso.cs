using InterfazDATMA.GrupoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazDATMA.util
{
    public class Grupo_Curso
    {
        private GrupoWS.grupo grupo;
        private BindingList<PsicologoWS.psicologo> psicologos;
        private BindingList<TutorWS.tutor> tutores;

        public GrupoWS.grupo Grupo { get => grupo; set => grupo = value; }
        public BindingList<PsicologoWS.psicologo> Psicologos { get => psicologos; set => psicologos = value; }
        public BindingList<TutorWS.tutor> Tutores { get => tutores; set => tutores = value; }
    }
}
