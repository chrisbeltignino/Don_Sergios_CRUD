using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using DonSergios.Infraestructure.Services;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data;
using System.Windows.Forms;

namespace DonSergios.Presentation.Presentation
{
    public partial class FrmClientes : Form
    {
        private readonly IClienteService clienteService;
        private readonly IAutoService autoService;
        private readonly IServicioService servicioService;
        private readonly IModeloService modeloService;

        private DBDON_SERGIOSEntities db;
        private int IDCliente;
        private int IDAuto;
        private int IDServicio;

        public FrmClientes(IClienteService clienteService, IAutoService autoService, IServicioService servicioService, IModeloService modeloService, DBDON_SERGIOSEntities db)
        {
            InitializeComponent();

            this.clienteService = clienteService;
            this.autoService = autoService;
            this.servicioService = servicioService;
            this.modeloService = modeloService;
            this.db = db;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LlenarComboBoxModelos();
            dgvListaClientes.AutoGenerateColumns = false;
        }


        private void CargarDatos()
        {
            var clientes = clienteService.Read();
            var autos = autoService.Read();
            var modelos = modeloService.Read();
            var servicios = servicioService.Read();

            // Realiza una unión de datos utilizando LINQ, creando objetos DTO
            var query = from c in clientes
                        join a in autos on c.ID_AUTO equals a.ID_AUTO
                        join m in modelos on a.ID_MODELO equals m.ID_MODELO
                        join s in servicios on c.ID_SERVICIO equals s.ID_SERVICIO
                        select new
                        {
                            ID = c.ID,
                            Nombre = c.NOMBRES,
                            Apellido = c.APELLIDOS,
                            Direccion = c.DIRECCION,
                            NumeroTelefono = c.TELEFONO,
                            Facebook = c.FACEBOOK,
                            ID_Auto = c.ID_AUTO,
                            Patente = a.PATENTE,
                            Modelo = m.MODELO,
                            Motor = a.MOTOR,
                            Año = a.AÑO,
                            ID_Servicio = c.ID_SERVICIO,
                            Problemas = s.PROBLEMAS,
                            PruebasRealizadas = s.PRUEBAS,
                            Repuestos = s.REPUESTOS,
                            Precios = s.PRECIO,
                            Observaciones = s.OBSERVACIONES,
                            FechaLlegada = s.FECHA_LLEGADA,
                            FechaSalida = s.FECHA_SALIDA
                        };

            // Establece la fuente de datos del DataGridView
            dgvListaClientes.DataSource = query.ToList();
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

        private void txt_BuscarNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_BuscarNombre.Text))
                {
                    var Lst = clienteService.BuscarNombre(txt_BuscarNombre.Text);
                    BuscarUNCliente(Lst);
                }
                else
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarUNCliente(List<CLIENTES> cCliente)
        {
            var query = from c in cCliente
                        join a in db.AUTOS on c.ID_AUTO equals a.ID_AUTO
                        join m in db.MODELOS on a.ID_MODELO equals m.ID_MODELO
                        join s in db.SERVICIOS on c.ID_SERVICIO equals s.ID_SERVICIO
                        select new
                        {
                            ID = c.ID,
                            Nombre = c.NOMBRES,
                            Apellido = c.APELLIDOS,
                            Direccion = c.DIRECCION,
                            NumeroTelefono = c.TELEFONO,
                            Facebook = c.FACEBOOK,
                            ID_Auto = c.ID_AUTO,
                            Patente = a.PATENTE,
                            Modelo = m.MODELO,
                            Motor = a.MOTOR,
                            Año = a.AÑO,
                            ID_Servicio = c.ID_SERVICIO,
                            Problemas = s.PROBLEMAS,
                            PruebasRealizadas = s.PRUEBAS,
                            Repuestos = s.REPUESTOS,
                            Precios = s.PRECIO,
                            Observaciones = s.OBSERVACIONES,
                            FechaLlegada = s.FECHA_LLEGADA,
                            FechaSalida = s.FECHA_SALIDA
                        };

            dgvListaClientes.DataSource = query.ToList(); // Asigna los resultados al DataGridView

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_BuscarTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txt_BuscarTelefono.Text != string.Empty)
            {
                var Lst = clienteService.BuscarTelefono(txt_BuscarTelefono.Text);
                BuscarUNCliente(Lst);
            }
            else
            {
                CargarDatos();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            OpenFrmAgregarClienteDialog();
        }

        private void OpenFrmAgregarClienteDialog()
        {
            FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente(clienteService, autoService, servicioService, modeloService, db);
            frmAgregarCliente.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int modeloIndex = cmb_Modelo.SelectedIndex;

            if (modeloIndex >= 1)
            {
                string modeloSeleccionado = cmb_Modelo.Text;
                // Realiza una consulta para obtener los clientes que tienen el modelo seleccionado
                var clientesConModelo = clienteService.GetClientesByModelo(modeloSeleccionado);

                // Actualiza el DataGridView con los resultados de la consulta
                BuscarUNCliente(clientesConModelo);
            }
        }

        private void dgvListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el cliente seleccionado
            var selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                int clienteId = Convert.ToInt32(dgvListaClientes.CurrentRow.Cells["ID"].Value);

                // Crear un formulario para mostrar la información del cliente
                FrmMostrarCliente mostrarClienteForm = new FrmMostrarCliente(clienteId, clienteService, autoService, servicioService, modeloService, db);

                // Suscribirte al evento FormClosed de FrmMostrarCliente
                mostrarClienteForm.FormClosedEvent += FrmMostrarCliente_FormClosed;

                // Mostrar el formulario
                mostrarClienteForm.Show();
            }
        }

        private int GetIDCliente()
        {
            try
            {
                return int.Parse(dgvListaClientes.Rows[dgvListaClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int GetIDServicio()
        {
            try
            {
                return int.Parse(dgvListaClientes.Rows[dgvListaClientes.CurrentRow.Index].Cells[10].Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int GetIDAuto()
        {
            try
            {
                return int.Parse(dgvListaClientes.Rows[dgvListaClientes.CurrentRow.Index].Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int ID = GetIDCliente();

            if (ID > 0)
            {
                int clienteId = Convert.ToInt32(dgvListaClientes.CurrentRow.Cells["ID"].Value);

                // Crear un formulario para mostrar la información del cliente
                FrmMostrarCliente mostrarClienteForm = new FrmMostrarCliente(clienteId, clienteService, autoService, servicioService, modeloService, db);

                // Suscribirte al evento FormClosed de FrmMostrarCliente
                mostrarClienteForm.FormClosedEvent += FrmMostrarCliente_FormClosed;

                // Mostrar el formulario
                mostrarClienteForm.Show();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                IDCliente = GetIDCliente();
                IDServicio = GetIDServicio();
                IDAuto = GetIDAuto();

                if (IDCliente != null)
                {
                    if (MessageBox.Show("Desea eliminar este Cliente?", "Operacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        clienteService.Delete(IDCliente);
                        servicioService.Delete(IDServicio);
                        autoService.Delete(IDAuto);
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona el Cliente que desea ELIMINAR", "Error al ELIMINAR registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FrmMostrarCliente_FormClosed(object sender, EventArgs e)
        {
            // El evento se dispara cuando se cierra FrmMostrarCliente
            // Aquí puedes actualizar la tabla llamando a tu método CargarDatos()
            CargarDatos();
        }
    }
}
