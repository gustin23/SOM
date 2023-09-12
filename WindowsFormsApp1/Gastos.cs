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
    public partial class formgastos : Form
    {

        List<Clista2> MiLista2 = new List<Clista2>();
        public formgastos()
        {
            InitializeComponent();
            Elimininar2.Enabled = false;
        }

        private void tslRegistrar2_Click(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            if (validarMonto() == false)
            {
                return;
            }

            Clista2 miAlumno = new Clista2();
            miAlumno.producto = Nombre2.Text;
            miAlumno.monto2 = int.Parse(Monto2.Text);
            MiLista2.Add(miAlumno);
            ListaD2.DataSource = null;
            ListaD2.DataSource = MiLista2;
            LimpiarControles();
            Nombre2.Focus();
            Consultar2.Enabled = true;

            double total = 0;
            foreach (DataGridViewRow row in ListaD2.Rows)
            {
                total -= Convert.ToDouble(row.Cells["Monto2"].Value);
                double totalaux = Convert.ToDouble(this.totalEnviado.Text) + total;
                gastoTotal.Text = (totalaux).ToString();
            }
        }

        //Validar el Monto
        private bool validarMonto()
        {
            int monto;
            if (!int.TryParse(Monto2.Text, out monto) || Monto2.Text == "")
            {
                errorProvider1.SetError(Monto2, "Debe ingresar un valor numerico para el Monto");
                Monto2.Clear();
                Monto2.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(Monto2, "");
                return true;
            }
        }

        //Validar el producto
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(Nombre2.Text))
            {
                errorProvider1.SetError(Nombre2, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                errorProvider1.SetError(Nombre2, "");
                return true;
            }
        }

        //Limpiar los controles
        private void LimpiarControles()
        {
            Nombre2.Clear();
            Monto2.Clear();
        }
        //Metodo consulatar alumno o obtener
        private Clista2 GetAlumno(string Nombre)
        {
            return MiLista2.Find(alumno => alumno.producto.Contains(Nombre));
        }

        private void Consultar2_Click_1(object sender, EventArgs e)
        {
            if (validarNombre() == false)
            {
                return;
            }
            Clista2 miAlumno = GetAlumno(Nombre2.Text);
            if (miAlumno == null)
            {
                errorProvider1.SetError(Nombre2, "El alumno no esta registrado en la lista");
                LimpiarControles();
                Nombre2.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(Nombre2, "");
                Nombre2.Text = miAlumno.producto;
                Monto2.Text = miAlumno.monto2.ToString();
                Elimininar2.Enabled = true;
            }
        }
        private void Elimininar2_Click(object sender, EventArgs e)
        {
            if (Nombre2.Text == "")
            {
                errorProvider1.SetError(Nombre2, "Debe consultar el alumno a eliminar");
                LimpiarControles();
                Nombre2.Focus();
                Elimininar2.Enabled = false;
                return;
            }
            else
            {
                errorProvider1.SetError(Nombre2, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar el registro de este alumno", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (Clista2 miAlumno in MiLista2)
                    {
                        if (miAlumno.producto == Nombre2.Text)
                        {
                            MiLista2.Remove(miAlumno);
                            break;
                        }
                    }
                    LimpiarControles();
                    ListaD2.DataSource = null;
                    ListaD2.DataSource = MiLista2;
                }
            }

            double total = 0;
            foreach (DataGridViewRow row in ListaD2.Rows)
            {
                total -= Convert.ToDouble(row.Cells["Monto2"].Value);
                if (total == 0)
                {
                    gastoTotal.Text = totalEnviado.Text;
                }
                else
                {
                    double totalaux = Convert.ToDouble(this.totalEnviado.Text) + total;
                    gastoTotal.Text = (totalaux).ToString();
                }   
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}