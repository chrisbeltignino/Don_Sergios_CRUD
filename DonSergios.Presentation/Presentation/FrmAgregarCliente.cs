using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using DonSergios.Infraestructure.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonSergios.Presentation.Presentation
{
    public partial class FrmAgregarCliente : Form
    {
        private readonly IClienteService clienteService;
        private readonly IAutoService autoService;
        private readonly IServicioService servicioService;
        private readonly IModeloService modeloService;

        private DBDON_SERGIOSEntities db;

        public FrmAgregarCliente(IClienteService clienteService, IAutoService autoService, IServicioService servicioService, IModeloService modeloService, DBDON_SERGIOSEntities db)
        {
            InitializeComponent();

            this.clienteService = clienteService;
            this.autoService = autoService;
            this.servicioService = servicioService;
            this.modeloService = modeloService;
            this.db = db;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recopila los datos de los campos de entrada
                string nombreCliente = txt_Nombre.Text;
                string apellidoCliente = txt_Apellido.Text;
                string direccionCliente = txt_Direccion.Text;
                string telefonoCliente = txt_Telefono.Text;
                string facebookCliente = txt_Facebook.Text;

                string motorAuto = txt_Motor.Text;
                string patenteAuto = txt_Patente.Text;
                int idModelo = Convert.ToInt32(cmb_Modelo.SelectedValue);
                int anoAuto = Convert.ToInt32(txt_Año.Text);

                string problemasServicio = txt_Problemas.Text;
                string pruebasRealizadasServicio = txt_Pruebas.Text;
                string repuestosServicio = txt_Repuestos.Text;
                int precioServicio = Convert.ToInt32(txt_PrecioTotal.Text);
                string observacionesServicio = txt_Observaciones.Text;
                DateTime fechaLlegadaServicio = Convert.ToDateTime(dtp_Llegada.Text);
                DateTime fechaSalidaServicio = Convert.ToDateTime(dtp_Salida.Text);

                // Crea instancias de las entidades CLIENTES, AUTOS y SERVICIOS
                var auto = new AUTOS
                {
                    PATENTE = patenteAuto,
                    ID_MODELO = idModelo,
                    AÑO = anoAuto,
                    MOTOR = motorAuto
                };

                var servicio = new SERVICIOS
                {
                    PROBLEMAS = problemasServicio,
                    PRUEBAS = pruebasRealizadasServicio,
                    REPUESTOS = repuestosServicio,
                    PRECIO = precioServicio,
                    OBSERVACIONES = observacionesServicio,
                    FECHA_LLEGADA = fechaLlegadaServicio,
                    FECHA_SALIDA = fechaSalidaServicio
                };

                var cliente = new CLIENTES
                {
                    NOMBRES = nombreCliente,
                    APELLIDOS = apellidoCliente,
                    DIRECCION = direccionCliente,
                    TELEFONO = telefonoCliente,
                    FACEBOOK = facebookCliente,
                    ID_AUTO = auto.ID_AUTO,
                    ID_SERVICIO = servicio.ID_SERVICIO
                };

                // Llama a los servicios y repositorios para guardar los datos en la base de datos
                cliente.AUTOS = auto;
                autoService.Create(auto);

                cliente.SERVICIOS = servicio;
                servicioService.Create(servicio);


                clienteService.Create(cliente);

                // Limpia los campos después de guardar los datos
                LimpiarCampos();

                this.Close();

            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el proceso de guardado
                MessageBox.Show("Error al guardar los datos: Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboBoxModelos()
        {
            var modelos = modeloService.Read();
            try
            {
                var query = modelos.Select(m => new
                {
                    m.ID_MODELO,
                    m.MODELO
                }).ToList();

                cmb_Modelo.DataSource = query.ToList(); // Asigna los resultados al DataGridView
                cmb_Modelo.DisplayMember = "MODELO";
                cmb_Modelo.ValueMember = "ID_MODELO"; // Usar el ID del modelo como valor seleccionado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            LlenarComboBoxModelos();
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Direccion.Clear();
            txt_Facebook.Clear();
            txt_Telefono.Clear();
            txt_Repuestos.Clear();
            txt_Pruebas.Clear();
            txt_Problemas.Clear();
            txt_PrecioTotal.Clear();
            txt_Patente.Clear();
            txt_Observaciones.Clear();
            txt_Año.Clear();
            dtp_Llegada.Value = DateTime.Now;
            dtp_Salida.Value = DateTime.Now;
            cmb_Modelo.SelectedIndex = -1;
        }

        private void txt_PrecioTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite que el caracter sea ingresado en el TextBox
            }
        }

        private void txt_Patente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                int cursorPosition = txt_Patente.SelectionStart;
                txt_Patente.Text = txt_Patente.Text.Insert(cursorPosition, "-");
                txt_Patente.SelectionStart = cursorPosition + 1;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Patente_TextChanged(object sender, EventArgs e)
        {
            txt_Patente.Text = txt_Patente.Text.ToUpper();
            txt_Patente.SelectionStart = txt_Patente.Text.Length;
        }

        private void txt_Año_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite que el caracter sea ingresado en el TextBox
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite que el caracter sea ingresado en el TextBox
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // No permite que el carácter sea ingresado en el TextBox
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // No permite que el carácter sea ingresado en el TextBox
            }
        }
    }
}
