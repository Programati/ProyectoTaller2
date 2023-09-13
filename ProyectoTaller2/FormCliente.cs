using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoTaller2
{
    public partial class FormCliente : Form
    {
        //defino el _form que va a guardar el form recibido como parametro
        //para poder utilizar la interfaz
        private Iform _form;

        public FormCliente(Iform form)
        {
            InitializeComponent();
            _form = form;
        }


        ErrorProvider errorP = new ErrorProvider();

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtDniCliente, "Solo numeros");
            else
                errorP.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool valida = Validar.txtVacios(txtDniCliente);
            if (valida)
                errorP.SetError(txtDniCliente, "Debe completar este campo");
            else
                errorP.Clear();
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            
            _form.openChildForm(new FormRegistroCliente());
            
        }
    }
}
