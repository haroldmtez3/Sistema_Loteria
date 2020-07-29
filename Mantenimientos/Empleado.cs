using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLoteriaLibrary;

namespace Sistema_Loteria.Mantenimientos
{
    public partial class Empleado : MantenimientoBase
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            SexoTextBox.Text = "";
            TelefonoTextBox.Text = "";
        }

        public bool Validate()
        {
            bool output = true;
            if (!ValidarCampos.NotEmpty(NombreTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(NombreTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyLetter(NombreTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(NombreTextBox, "Este campo puede tener solamente letras");
            }

            if (!ValidarCampos.NotEmpty(ApellidoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(ApellidoTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyLetter(ApellidoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(ApellidoTextBox, "Este campo puede tener solamente letras");
            }

            if (!ValidarCampos.NotEmpty(SexoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(SexoTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyLetter(SexoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(SexoTextBox, "Este campo puede tener solamente letras");
            }

            if (!ValidarCampos.NotEmpty(TelefonoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(TelefonoTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyNumber(TelefonoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(TelefonoTextBox, "Este campo puede tener solamente letras");
            }

            if (!ValidarCampos.NotEmpty(TelefonoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(TelefonoTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyNumber(TelefonoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(TelefonoTextBox, "Este campo puede tener solamente letras");
            }

            if (!ValidarCampos.NotEmpty(IdDireccionTextbox.Text))
            {
                output = false;
                errorProvider1.SetError(IdDireccionTextbox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyNumber(IdDireccionTextbox.Text))
            {
                output = false;
                errorProvider1.SetError(IdDireccionTextbox, "Este campo puede tener solamente letras");
            }

            return output;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                //try
                //{

                    int idEmpleado = 0, TipoDeEmpleado = 0, dir = 0;
                    
                    TipoDeEmpleado = Convert.ToInt32(TipodeEmpleadoCombobox.SelectedValue);
                    char sexo = Convert.ToChar(SexoTextBox.Text);
                    dir = Convert.ToInt32(IdDireccionTextbox.Text);
                    GuardarDatos.GuardarEmpleados(
                        idEmpleado,
                        NombreTextBox.Text,
                        ApellidoTextBox.Text,
                        sexo,
                        FechaDeNacimientoDateTimePicker.Value.ToString(),
                        TelefonoTextBox.Text,
                        TipoDeEmpleado,
                        dir,
                        FechaIngresadoDateTimePicker.Value.ToString()
                        );
                    MessageBox.Show("Informacion guardada");

                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show($"An error occured:\n {ex}");
               // }
            }
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultarDatos loadData = new ConsultarDatos();
                TipodeEmpleadoCombobox.DataSource = loadData.LoadTipoDeEmplead().Tables[0];
                TipodeEmpleadoCombobox.ValueMember = "Id_Tipo_Empleado";
                TipodeEmpleadoCombobox.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:\n {ex}");
            }
        }
    }
}
