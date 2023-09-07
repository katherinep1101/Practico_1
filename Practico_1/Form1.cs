using Practico_1.Controller;
using Practico_1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using Microsoft.VisualBasic.Logging;
using System.Net.Http.Headers;

namespace Practico_1
{

    public partial class Form1 : Form
    {
        private DataTable tabla;
        ClienteController ClienteController = new ClienteController(); //se instancia objeto para llamar a acciones crud del controller
        int filaSeleccionada;
        //para validar numero de factura
        private List<int> numerosFactura = new List<int>();
        string accion = "guardar"; //la opción por defecto al pulsar el botón guardar, si se está editando, debe cambiar a editar

        public Form1()
        {
            InitializeComponent();
            try
            {
                MostrarListaCliente();
                //uf y dolar
                string valoruf = RequestIndicadores.ObtenerUf();
                string valorDolar = RequestIndicadores.ObtenerDolar();

                //V alores en los Label 
                luf.Text = valoruf;
                ldr.Text = valorDolar;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Asignar nombres a las Columnas del DataGrid
        private void InicializarTablaClientes()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Rut");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("EsEmpresa");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("FechaRegistro");
            tabla.Columns.Add("CantidadFacturas");
            tabla.Columns.Add("NumeroUltimaFactura");
            tabla.Columns.Add("MontoUltimaFactura");

            dataGCliente.DataSource = tabla; //Nombnre del DataGrid
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //pobla el datagrid con los datos de la lista de usuarios
        private void MostrarListaCliente()
        {
            InicializarTablaClientes();

            List<Cliente> clientes = ClienteController.ObtenerListaClientes();

            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    //si usuarios no es nulo, se le asigna a cada fila el valor de la propiedad que le corresponde.
                    //el nombre del row debe coincidir con el de inicializarTablaUsuarios()
                    DataRow row = tabla.NewRow();
                    row["Rut"] = cliente.Rut;
                    row["Nombre"] = cliente.Nombre;
                    row["EsEmpresa"] = cliente.EsEmpresa ? "Sí" : "No";
                    row["Telefono"] = cliente.Telefono;
                    row["Direccion"] = cliente.Direccion;
                    row["FechaRegistro"] = cliente.FechaRegistro;
                    row["CantidadFacturas"] = cliente.CantidadFacturas;
                    row["NumeroUltimaFactura"] = cliente.NumeroUltimaFactura;
                    row["MontoUltimaFactura"] = cliente.MontoUltimaFactura;

                    tabla.Rows.Add(row);

                }
            }
        }
        //Guardar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textRut.Text) ||
                    string.IsNullOrWhiteSpace(textNombre.Text) ||
                    string.IsNullOrWhiteSpace(textTlf.Text) ||
                    string.IsNullOrWhiteSpace(textDir.Text) ||
                    string.IsNullOrWhiteSpace(textFecha.Text) ||
                    string.IsNullOrWhiteSpace(textCantF.Text) ||
                    string.IsNullOrWhiteSpace(textNumeroUF.Text) ||
                    string.IsNullOrWhiteSpace(textMontoUF.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos. Por favor, complete los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si algún campo está vacío
                }

                if (cmbEmpresa.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una opción en el campo 'Es Empresa'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si no se ha seleccionado una opción
                }

                Cliente cliente = new Cliente()
                {
                    Rut = textRut.Text,
                    Nombre = textNombre.Text,
                    EsEmpresa = cmbEmpresa.SelectedItem.ToString() == "SI",
                    Telefono = textTlf.Text,
                    Direccion = textDir.Text,
                    FechaRegistro = Convert.ToDateTime(textFecha.Text),
                    CantidadFacturas = int.Parse(textCantF.Text),
                    NumeroUltimaFactura = int.Parse(textNumeroUF.Text),
                    MontoUltimaFactura = int.Parse(textMontoUF.Text),
                };

                //la variable accion está por defecto en 'guardar' 
                if (accion == "guardar")
                {
                    ClienteController.AgregarCliente(cliente);
                }
                else if (accion == "editar") //cuando se quiere editar, la acción debería estar en 'editar' ver función btnModificar_Click()
                {
                    ClienteController.ActualizarCliente(filaSeleccionada, cliente);
                    accion = "guardar";
                }

                MostrarListaCliente();
                LimpiarFormularioCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Limpiar
        private void LimpiarFormularioCliente()
        {
            textRut.Text = "";
            textNombre.Text = "";
            cmbEmpresa.SelectedIndex = -1;
            textTlf.Text = "";
            textDir.Text = "";
            textFecha.Text = "";
            textCantF.Text = "";
            textNumeroUF.Text = "";
            textMontoUF.Text = "";
        }

        //detecta cuando se le hace click a una celda el datagrid y guarda el indice correspondiente al registro seleccionado
        private void dataGCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            btnEliminar.Enabled = true; // Habilita el botón de eliminación
            btnModificar.Enabled = true; // Habilita el botón de modificación

        }


        //limpia todos los campos y vuelve algunas cosas a su estado inicial
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCliente();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            accion = "guardar";
        }
        //el boton eliminar llama a la funcion eliminar del controlador
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            ClienteController.EliminarCliente(filaSeleccionada);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            MostrarListaCliente();
        }
        //Envía datos de la fila elegida al formulario para su edición
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = dataGCliente.Rows[filaSeleccionada];

                textRut.Text = fila.Cells[0].Value.ToString();
                textNombre.Text = fila.Cells["Nombre"].Value.ToString();
                cmbEmpresa.SelectedItem = fila.Cells["EsEmpresa"].Value.ToString();
                textTlf.Text = fila.Cells[3].Value.ToString();
                textDir.Text = fila.Cells[4].Value.ToString();
                textFecha.Text = fila.Cells["FechaRegistro"].Value.ToString();
                // textFecha.Value = Convert.ToDateTime(fila.Cells[5].Value);
                textCantF.Text = fila.Cells["CantidadFacturas"].Value.ToString();
                textNumeroUF.Text = fila.Cells["NumeroUltimaFactura"].Value.ToString();
                textMontoUF.Text = fila.Cells["MontoUltimaFactura"].Value.ToString();


                accion = "editar";

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false; //corregido

                // Establecer campos como solo lectura
                textRut.ReadOnly = true;
                textCantF.ReadOnly = true;
                textNumeroUF.ReadOnly = true;
                textMontoUF.ReadOnly = true;
            }

            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textCantF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // El cliente ingresó un carácter que no es un número
                MessageBox.Show("Por favor, ingrese solo números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Evita que el carácter no numérico sea ingresado en el TextBox
            }
        }

        private void textNumeroUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // El cliente ingresó un carácter que no es un número
                MessageBox.Show("Por favor, ingrese solo números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Evita que el carácter no numérico sea ingresado en el TextBox
            }
        }

        private void textMontoUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // El cliente ingresó un carácter que no es un número
                MessageBox.Show("Por favor, ingrese solo números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Evita que el carácter no numérico sea ingresado en el TextBox
            }
        }

        private void textTlf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // El cliente ingresó un carácter que no es un número
                MessageBox.Show("Por favor, ingrese solo números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Evita que el carácter no numérico sea ingresado en el TextBox
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // El cliente ingresó un carácter que no es una letra
                MessageBox.Show("Por favor, ingrese solo letras en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Evita que el carácter no válido sea ingresado en el TextBox
            }
        }

        private void dataGCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGCliente.SelectedRows.Count > 0)
            {
                // Habilita el botón "Ingresar Factura" cuando hay una selección
                btnFactura.Enabled = true;
                btnGuardarF.Enabled = true;
            }
            else
            {
                // Deshabilita el botón "Ingresar Factura" cuando no hay selección
                btnFactura.Enabled = false;
                btnGuardarF.Enabled = false;
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                // Habilita la edición de los campos NumeroUltimaFactura y MontoUltimaFactura
                textNumeroUF.ReadOnly = false;
                textMontoUF.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para ingresar la última factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarF_Click(object sender, EventArgs e)
        {

            try
            {
                int numeroFactura = int.Parse(textNumeroUF.Text);

                if (numerosFactura.Contains(numeroFactura))
                {
                    MessageBox.Show("El número de factura ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Agrega el número de factura a la lista de números de factura
                    numerosFactura.Add(numeroFactura);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}
