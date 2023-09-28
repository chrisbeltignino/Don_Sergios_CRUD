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
    public partial class FrmMostrarCliente : Form
    {
        private readonly IClienteService clienteService;
        private readonly IAutoService autoService;
        private readonly IServicioService servicioService;
        private readonly IModeloService modeloService;

        private DBDON_SERGIOSEntities db;
        private int clienteId; // Agrega un campo para almacenar el ID del cliente

        // En FrmMostrarCliente
        public event EventHandler FormClosedEvent;

        private void FrmMostrarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }


        public FrmMostrarCliente(int clienteId, IClienteService clienteService, IAutoService autoService, IServicioService servicioService, IModeloService modeloService, DBDON_SERGIOSEntities db)
        {
            InitializeComponent();

            this.clienteService = clienteService;
            this.autoService = autoService;
            this.servicioService = servicioService;
            this.modeloService = modeloService;
            this.db = db;
            this.clienteId = clienteId; // Almacena el ID del cliente

            LlenarComboBoxModelos();

            // Carga los datos del cliente desde la base de datos utilizando el ID
            CargarDatosCliente(clienteId);
        }

        private void CargarDatosCliente(int clienteId)
        {
            try
            {
                // Obtiene el cliente desde la base de datos utilizando el servicio
                CLIENTES cliente = clienteService.GetClienteByID(clienteId);

                // Verifica si se encontró el cliente
                if (cliente != null)
                {
                    // Llena los campos del formulario con los datos del cliente
                    txt_ID.Text = cliente.ID.ToString();
                    txt_Nombre.Text = cliente.NOMBRES;
                    txt_Apellido.Text = cliente.APELLIDOS;
                    txt_Direccion.Text = cliente.DIRECCION;
                    txt_Facebook.Text = cliente.FACEBOOK;
                    txt_Telefono.Text = cliente.TELEFONO;
                    txt_IDAuto.Text = cliente.ID_AUTO.ToString();
                    txt_Patente.Text = cliente.AUTOS?.PATENTE;
                    txt_Motor.Text = cliente.AUTOS?.MOTOR;
                    txt_Año.Text = cliente.AUTOS?.AÑO.ToString();
                    cmb_Modelo.SelectedValue = cliente.AUTOS?.ID_MODELO;
                    txt_IDServicio.Text = cliente.ID_SERVICIO.ToString();
                    txt_Problemas.Text = cliente.SERVICIOS?.PROBLEMAS;
                    txt_Pruebas.Text = cliente.SERVICIOS?.PRUEBAS;
                    txt_Repuestos.Text = cliente.SERVICIOS?.REPUESTOS;
                    txt_PrecioTotal.Text = cliente.SERVICIOS?.PRECIO.ToString();
                    txt_Observaciones.Text = cliente.SERVICIOS?.OBSERVACIONES;
                    dtp_Llegada.Value = cliente.SERVICIOS?.FECHA_LLEGADA ?? DateTime.Now;
                    dtp_Salida.Value = cliente.SERVICIOS?.FECHA_SALIDA ?? DateTime.Now;
                }
                else
                {
                    MessageBox.Show("El cliente no se encontró en la base de datos.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FrmMostrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            txt_ID.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Direccion.Enabled = true;
            txt_Facebook.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Patente.Enabled = true;
            txt_Motor.Enabled = true;
            txt_Año.Enabled = true;
            cmb_Modelo.Enabled = true;
            txt_Problemas.Enabled = true;
            txt_Pruebas.Enabled = true;
            txt_Repuestos.Enabled = true;
            txt_PrecioTotal.Enabled = true;
            txt_Observaciones.Enabled = true;
            dtp_Llegada.Enabled = true;
            dtp_Salida.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Guardar.Enabled = true;
            //LlenarComboBoxModelos();
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

        private bool ValidarTxt()
        {
            return txt_Nombre.Text != string.Empty || txt_Apellido.Text != string.Empty || txt_Telefono.Text != string.Empty || txt_Patente.Text != string.Empty || cmb_Modelo.SelectedIndex != -1 || txt_Año.Text != string.Empty;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTxt() == true)
                {
                    if (MessageBox.Show("Desea guardar los cambios?", "Guardado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Obtén el ID del cliente desde el formulario o cualquier otra fuente necesaria
                        //int clienteId = Convert.ToInt32(txt_ID.Text);

                        // Recupera el cliente de la base de datos para asegurarte de que estás trabajando con los datos más recientes
                        CLIENTES cliente = clienteService.GetClienteByID(this.clienteId);

                        // Actualiza los campos del cliente con los nuevos valores ingresados en el formulario
                        cliente.ID = this.clienteId;
                        cliente.NOMBRES = txt_Nombre.Text;
                        cliente.APELLIDOS = txt_Apellido.Text;
                        cliente.DIRECCION = txt_Direccion.Text;
                        cliente.TELEFONO = txt_Telefono.Text;
                        cliente.FACEBOOK = txt_Facebook.Text;
                        cliente.ID_AUTO = Convert.ToInt32(txt_IDAuto.Text);
                        cliente.ID_SERVICIO = Convert.ToInt32(txt_IDServicio.Text);

                        // Actualiza los campos del auto con los nuevos valores ingresados en el formulario
                        cliente.AUTOS.ID_AUTO = Convert.ToInt32(txt_IDAuto.Text);
                        cliente.AUTOS.PATENTE = txt_Patente.Text;
                        cliente.AUTOS.MOTOR = txt_Motor.Text;
                        cliente.AUTOS.AÑO = Convert.ToInt32(txt_Año.Text);
                        cliente.AUTOS.ID_MODELO = Convert.ToInt32(cmb_Modelo.SelectedValue);

                        // Actualiza los campos del servicio con los nuevos valores ingresados en el formulario
                        cliente.SERVICIOS.ID_SERVICIO = Convert.ToInt32(txt_IDServicio.Text);
                        cliente.SERVICIOS.PROBLEMAS = txt_Problemas.Text;
                        cliente.SERVICIOS.PRUEBAS = txt_Pruebas.Text;
                        cliente.SERVICIOS.REPUESTOS = txt_Repuestos.Text;
                        cliente.SERVICIOS.PRECIO = Convert.ToDouble(txt_PrecioTotal.Text);
                        cliente.SERVICIOS.OBSERVACIONES = txt_Observaciones.Text;
                        cliente.SERVICIOS.FECHA_LLEGADA = dtp_Llegada.Value;
                        cliente.SERVICIOS.FECHA_SALIDA = dtp_Salida.Value;

                        // Llama al servicio para actualizar el cliente en la base de datos
                        clienteService.Update(cliente);
                        autoService.Update(cliente.AUTOS);
                        servicioService.Update(cliente.SERVICIOS);

                        // Limpia los campos después de guardar los datos
                        LimpiarCampos();

                        

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos: DATOS INCOMPLETOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el proceso de guardado
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Modelo_MouseClick(object sender, MouseEventArgs e)
        {
            //LlenarComboBoxModelos();
        }
    }
}
