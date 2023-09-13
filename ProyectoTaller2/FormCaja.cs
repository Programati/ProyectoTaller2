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
    public partial class FormCaja : Form
    {
        private Iform _form;
        public FormCaja(Iform form)
        {
            InitializeComponent();
            _form = form;
        }
    }
}
