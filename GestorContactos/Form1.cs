using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorContactos
{
    public partial class Form1 : Form
    {
        private readonly List<Contacto> contactos = new List<Contacto>();
        private int siguienteId = 1;

        public Form1()
        {
            InitializeComponent();

            dgvContactos.AutoGenerateColumns = true;
            dgvContactos.ReadOnly = true;
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.MultiSelect = false;
            dgvContactos.SelectionChanged += dgvContactos_SelectionChanged;

            MostrarContactos(contactos);
            LimpiarDetalles();
        }

        // Enlaza una lista (completa o filtrada) a la tabla
        private void MostrarContactos(List<Contacto> lista)
        {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = lista;
            dgvContactos.ClearSelection();
            LimpiarDetalles();
        }

        private void LimpiarDetalles()
        {
            lblNombre.Text = "";
            lblCorreo.Text = "";
            lblTelefono.Text = "";
        }

        // A. Registrar contacto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string telefono = txtTelefono.Text.Trim();

                if (nombre == "" || correo == "" || telefono == "")
                {
                    MessageBox.Show("Nombre, correo y teléfono son obligatorios.",
                        "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblEstado.Text = "No se registró el contacto";
                    return;
                }

                Contacto nuevo = new Contacto();
                nuevo.Id = siguienteId;
                nuevo.Nombre = nombre;
                nuevo.Correo = correo;
                nuevo.Telefono = telefono;
                siguienteId++;

                contactos.Add(nuevo);
                MostrarContactos(contactos);

                // G. Limpiar campos de entrada (la lista se conserva)
                txtNombre.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtNombre.Focus();

                lblEstado.Text = "Contacto agregado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // D. Buscar por nombre o correo (sin distinguir mayúsculas)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            if (texto == "")
            {
                MostrarContactos(contactos);
                lblEstado.Text = "Escribe un texto para buscar";
                return;
            }

            List<Contacto> resultados = new List<Contacto>();
            foreach (Contacto c in contactos)
            {
                if (c.Nombre.ToLower().Contains(texto) ||
                    c.Correo.ToLower().Contains(texto))
                {
                    resultados.Add(c);
                }
            }

            MostrarContactos(resultados);

            if (resultados.Count == 0)
                lblEstado.Text = "No se encontraron resultados";
            else
                lblEstado.Text = resultados.Count + " resultado(s) encontrado(s)";
        }

        // E. Mostrar todos
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarContactos(contactos);
            lblEstado.Text = "Mostrando todos los contactos";
        }

        // F. Detalles de la fila seleccionada
        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null || !dgvContactos.CurrentRow.Selected)
            {
                LimpiarDetalles();
                return;
            }

            Contacto c = dgvContactos.CurrentRow.DataBoundItem as Contacto;
            if (c != null)
            {
                lblNombre.Text = c.Nombre;
                lblCorreo.Text = c.Correo;
                lblTelefono.Text = c.Telefono;
            }
        }
    }
}