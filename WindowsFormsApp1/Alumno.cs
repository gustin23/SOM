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
    public partial class Alumno : Form
    {

        List<Clista> MiLista = new List<Clista>();
        public Alumno()
        {
            InitializeComponent();
            Elimininar.Enabled = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            if (validarApellido() == false)
            {
                return;
            }
            if (validarCurso() == false)
            {
                return;
            }
            if (validarTurno() == false)
            {
                return;
            }
            if (validarMonto() == false)
            {
                return;
            }

            Clista miAlumno = new Clista();
            miAlumno.Nombre = Nombre.Text;
            miAlumno.Apellido = Apellido.Text;
            miAlumno.Curso = Curso.Text;
            miAlumno.Turno = Turno.SelectedIndex.ToString();
            miAlumno.Monto = int.Parse(Monto.Text);
            MiLista.Add(miAlumno);
            ListaD.DataSource = null;
            ListaD.DataSource = MiLista;
            LimpiarControles();
            Nombre.Focus();
            Consultar.Enabled = true;

            double total = 0;
            foreach (DataGridViewRow row in ListaD.Rows)
            {
                total += Convert.ToDouble(row.Cells["Monto"].Value);

                txttotal.Text = Convert.ToString(total);
            }
        }
        //Validar el Turno
        private bool validarTurno()
        {
            if (string.IsNullOrEmpty(Turno.Text))
            {
                errorProvider1.SetError(Turno, "Debe seleccionar un turno");
                return false;       
            }
            else
            {
                errorProvider1.SetError(Turno, "");
                return true;
            }
        }

        //Validar el Curso
        private bool validarCurso()
        {
            if (string.IsNullOrEmpty(Curso.Text))
            {
                errorProvider1.SetError(Curso, "Debe ingresar un numero para el curso");
                return false;
            }
            else
            {
                errorProvider1.SetError(Curso, "");
                return true;
            }
        }

        

        //Validar el apellido
        private bool validarApellido()
        {
            if (string.IsNullOrEmpty(Apellido.Text))
            {
                errorProvider1.SetError(Apellido, "Debe ingresar un Apellido");
                return false;
            }
            else
            {
                errorProvider1.SetError(Apellido, "");
                return true;
            }
        }

        //Validar el nombre
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(Nombre.Text))
            {
                errorProvider1.SetError(Nombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(Nombre, "");
                return true;
            }
        }
        //Validar el Monto
        private bool validarMonto()
        {
            int monto;
            if (!int.TryParse(Monto.Text, out monto) || Monto.Text == "")
            {
                errorProvider1.SetError(Monto, "Debe ingresar un valor numerico para el Monto");
                Monto.Clear();
                Monto.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(Monto, "");
                return true;
            }
        }

        //Limpiar los controles
        private void LimpiarControles()
        {
            Nombre.Clear();
            Apellido.Clear();
            Curso.Clear();
            Turno.SelectedIndex = 0;
            Monto.Clear();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            Clista miAlumno = GetAlumno(Nombre.Text);
            if (miAlumno == null)
            {
                errorProvider1.SetError(Nombre, "El alumno no esta registrado en la lista");
                LimpiarControles();
                Nombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(Nombre, "");
                Nombre.Text = miAlumno.Nombre;
                Apellido.Text = miAlumno.Apellido;
                Curso.Text = miAlumno.Curso;
                Monto.Text = miAlumno.Monto.ToString();
                Elimininar.Enabled = true;
            }
        }
        //Metodo consulatar alumno o obtener
        private Clista GetAlumno(string Nombre)
        {
            return MiLista.Find(alumno => alumno.Nombre.Contains(Nombre));
        }
        
        private void Elimininar_Click(object sender, EventArgs e)
        {

            if (Nombre.Text == "")
            {
                errorProvider1.SetError(Nombre, "Debe consultar el alumno a eliminar");
                LimpiarControles();
                Nombre.Focus();
                Elimininar.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.SetError(Nombre, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar el registro de este alumno", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (Clista miAlumno in MiLista)
                    {
                        if (miAlumno.Nombre == Nombre.Text)
                        {
                            MiLista.Remove(miAlumno);
                            break;
                        }
                    }
                    LimpiarControles();
                    ListaD.DataSource = null;
                    ListaD.DataSource = MiLista;
                }
            }

            double total = 0;
            foreach (DataGridViewRow row in ListaD.Rows)
            {
                total += Convert.ToDouble(row.Cells["Monto"].Value);

                txttotal.Text = Convert.ToString(total);
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            formgastos f1 = new formgastos();
            f1.totalEnviado.Text = txttotal.Text;
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


       