using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                    return;
            }
            Form1 VentanaPerfil = new Form1();
            VentanaPerfil.MdiParent = this;
            VentanaPerfil.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 VentanaPerfil = new Form1();
            VentanaPerfil.ShowDialog();
        }
    }
}
