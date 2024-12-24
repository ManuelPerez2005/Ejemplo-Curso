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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Elemento = txtNombre.Text;
            lwElementos.Items.Add(Elemento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                nombre = txtNombre.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate",
                tipo = rbtMuggle.Checked ? "Muggle" : rbtWizard.Checked ? "Wizard" : "Squibs",
                ColorFavorito = cboColorFavorito.SelectedItem.ToString(),
                NumeroFavorito = (int)numNumeroFavorito.Value,
            };
            string mensaje = persona.VerPerfil();
            MessageBox.Show(mensaje);
        }
    }
}
