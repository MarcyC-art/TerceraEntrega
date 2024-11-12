using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBDDM.models;

namespace ProyectoBDDM.controllers
{
    internal class ControllerStaff
    {
        internal bool Selectuser(string usern, string pass) 
        {
            bool result = false;

            string sql = "select idProfesores, passwordP from profesores;";
            Profesor objs = new Profesor();

            result = objs.SelectUser(sql)

            return result;
        }
    }
}
