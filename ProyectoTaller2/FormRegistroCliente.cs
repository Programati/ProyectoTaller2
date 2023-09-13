using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller2
{
    
    public partial class FormRegistroCliente : Form
    {
        DialogResult ask;
        public FormRegistroCliente()
        {
            InitializeComponent();
        }

        ErrorProvider errorP = new ErrorProvider();

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtDni, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtTelefono, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtNombre, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtApellido, "Solo numeros");
            else
                errorP.Clear();
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validaDNI = Validar.txtVacios(txtDni);
            if (validaDNI)
                errorP.SetError(txtDni, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaNombre = Validar.txtVacios(txtNombre);
            if (validaNombre)
                errorP.SetError(txtNombre, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaApellido = Validar.txtVacios(txtApellido);
            if (validaApellido)
                errorP.SetError(txtApellido, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaTelefono = Validar.txtVacios(txtTelefono);
            if (validaTelefono)
                errorP.SetError(txtTelefono, "Debe completar este campo");
            else
                errorP.Clear();

            bool validaDireccion = Validar.txtVacios(txtDireccion);
            if (validaDireccion)
                errorP.SetError(txtDireccion, "Debe completar este campo");
            else
                errorP.Clear();

            

            if (!validaDireccion && !validaApellido && !validaTelefono && !validaDNI && !validaNombre) { 
                 

                 ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El cliente " + txtDni.Text +
                    " se insertó correctamente", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellido.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtNombre.Clear();
                txtDni.Clear();
            }
        }
    }
}
