using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaException.Core;

namespace PracticaException.App
{
    public partial class PracticaException : Form
    {
        public PracticaException()
        {
            InitializeComponent();
        }

        private void ExceptionTest(object sender, EventArgs e)
        {
            var a = new Alumno();
            a.Nombre = tbNombre.Text;

            try
            {
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
