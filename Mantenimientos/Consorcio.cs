using SLoteriaLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Loteria.Mantenimientos
{
    public partial class Consorcio : MantenimientoBase
    {
        public Consorcio()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
            bool output = true;
            if (!ValidarCampos.NotEmpty(ConsorcioTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(ConsorcioTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.NotEmpty(IDEmpleadoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(IDEmpleadoTextBox, "Este campo no puede estar vacio");
            }

            if (!ValidarCampos.OnlyNumber(IDEmpleadoTextBox.Text))
            {
                output = false;
                errorProvider1.SetError(IDEmpleadoTextBox, "Este campo puede tener solamente letras");
            }

            return output;
        }
    }
}
