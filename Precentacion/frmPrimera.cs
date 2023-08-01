using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Precentacion
{
    public partial class frmPrimera : Form
    {
        public frmPrimera()
        {
            InitializeComponent();
        }

        private void btnComienzoAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.ShowDialog();
            
        }

        private void btnComienzoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
