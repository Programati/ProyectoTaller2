using FontAwesome.Sharp;
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
using System.Windows.Media;

namespace ProyectoTaller2
{
    public partial class formLogin : Form
    {
        //Declaramos un campo de tipo Formulario para almacenar el formulario Hijo Activo
        private Form currentChildForm;

        
        public formLogin()
        {
            
            this.InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            //Si el formulario actual es diferente a nulo[Esta abierto]
            if (currentChildForm != null)
            {
                //Lo cerramos
                childForm.Close();
                //Para luego abrir otro que hemos seleccionado
            }
            currentChildForm = childForm;              
            //Lo mostramos
            childForm.Show();
        } 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (radioButton1.Checked)
            {
                this.Close();
               FormMainMenu menu = new FormMainMenu();
                menu.Show();
               // this.Close();

        

            }
            else if (radioButton2.Checked)
            {
                this.Close();
                    
            }
            else if (radioButton3.Checked)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

        }


    }
}
