using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio.modelo;
using Laboratorio.Logica;



namespace Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_persona();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Persona obj = new Persona()
            {
               Nombre = textNombre.Text, 
               Apellidos = textApellidos.Text, 
               CorreoElec = textCorreoElec.Text,
               Personalnumber = textpersonalnumberr.Text
            };

            bool respuesta =  usuarioLogica.Instancia2.guardar(obj);  

            if (respuesta )
            {
                Limpiar();
                mostrar_persona();
            }
        }

        public void mostrar_persona()
        {
            dgvpersonas.DataSource = null;
            dgvpersonas.DataSource = usuarioLogica.Instancia2.listar();


        }

        public void Limpiar()
        {

            textidusario.Text = "";
            textNombre.Text = "";
            textApellidos.Text = "";
            textCorreoElec.Text = "";
            textpersonalnumberr.Text = "";
            textNombre.Focus(); 
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Persona obj = new Persona()
            {
                Usuario_Id = int.Parse(textidusario.Text),
                Nombre = textNombre.Text,
                Apellidos = textApellidos.Text,
                CorreoElec = textCorreoElec.Text,
                Personalnumber = textpersonalnumberr.Text
            };

            bool respuesta = usuarioLogica.Instancia2.Editar(obj);

            if (respuesta)
            {
                Limpiar();
                mostrar_persona();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona obj = new Persona()
            {
                Usuario_Id = int.Parse(textidusario.Text),
               
            };

            bool respuesta = usuarioLogica.Instancia2.Eliminar(obj);

            if (respuesta)
            {
                Limpiar();
                mostrar_persona();
            }
        }
    }
}
