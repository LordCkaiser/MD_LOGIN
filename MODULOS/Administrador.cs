using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD_LOGIN.MODULOS
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
        }

        public Administrador(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
