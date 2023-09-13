using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2
{
    public partial class FormVenta : Form
    {

        private Iform _form;
        public FormVenta(Iform form)
        {
            InitializeComponent();
            _form = form;
        }


        //Ahora cuando querramos instanciar otro formulario, por ejemplo
        //al presionar el boton buscar los ahoramos invocando el metodo
        //_form.openChildForm(new formX), del objeto _form que posee las configuraciones para hacerlo dentro del panel.
    }
}
