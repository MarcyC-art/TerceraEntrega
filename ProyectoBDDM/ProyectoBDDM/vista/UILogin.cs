using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDDM.controllers;
using ProyectoBDDM.models;

namespace ProyectoBDDM.vista
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usern=textBox2.Text;
            string pass= textBox1.Text;

            ControllerStaff objCS = new ControllerStaff();
            bool result=objCS.Selectuser(usern, pass);

            if (result)
            {

            }
            else
            {
                MessageBox.Show("Usuario NO encontrado");
            }
        }
    }
}
