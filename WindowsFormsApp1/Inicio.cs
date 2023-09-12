using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Alumno_Click(object sender, EventArgs e)
        {
            Alumno NuevaVentana = new Alumno();
            NuevaVentana.ShowDialog();
        }

        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            Info NuevaVentana = new Info();
            NuevaVentana.ShowDialog();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
