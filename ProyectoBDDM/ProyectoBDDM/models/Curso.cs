using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDM.models
{
    class Curso
    {
        private int curso_id;
        private string grupo;
        
        

        public Curso()
        {
        }

        public Curso(int curso_id, string grupo)
        {
            this.curso_id = curso_id;
            this.grupo = grupo;
            

        }

        public int Curso_id { get => curso_id; set => curso_id = value; }
        public string DescrpicionC { get => grupo; set => grupo = value; }
   
    }
}
