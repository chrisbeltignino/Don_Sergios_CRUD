using DonSergios.Applications.Interfaces;
using DonSergios.Infraestructure.Persistence;
using DonSergios.Infraestructure.Services;

namespace DonSergios.Presentation.Presentation
{
    public partial class FrmRepuestos : Form
    {
        private readonly IRepuestoService repuestoService;

        private DBDON_SERGIOSEntities db;

        private int IDRepuesto;

        public FrmRepuestos(IRepuestoService repuestoService, DBDON_SERGIOSEntities db)
        {
            InitializeComponent();

            this.db = db;
            this.repuestoService = repuestoService;
        }

        private void CargarDatos()
        {
            var repuestos = repuestoService.Read();

            // Realiza una unión de datos utilizando LINQ, creando objetos DTO
            var query = from r in repuestos
                        select new
                        {
                            ID = r.ID_REPUESTO,
                            Nombre = r.NOMBRE,
                            Marca = r.MARCA,
                            Precio = r.PRECIO,
                            Imagen = r.IMAGEN
                        };

            // Establece la fuente de datos del DataGridView
            dgvListaRepuestos.DataSource = query.ToList();
        }

        private void dgvListaRepuestos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Asegúrate de que estás trabajando con la columna de imágenes
            if (e.ColumnIndex == dgvListaRepuestos.Columns["Imagen"].Index && e.Value != null)
            {
                // Obtén los datos binarios de la celda
                byte[] imageData = (byte[])e.Value;

                // Convierte los datos binarios en una imagen
                if (imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        e.Value = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no hay datos binarios válidos, establece el valor de la celda en nulo
                    e.Value = null;
                }
            }
        }

        private void FrmRepuestos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvListaRepuestos.AutoGenerateColumns = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            OpenFrmAgregarRepuestoDialog();
        }

        private void OpenFrmAgregarRepuestoDialog()
        {
            FrmAgregarRepuesto frmAgregarRepuesto = new FrmAgregarRepuesto(repuestoService);
            frmAgregarRepuesto.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvListaRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el repuesto seleccionado
            var selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                int repuestoId = Convert.ToInt32(dgvListaRepuestos.CurrentRow.Cells["ID"].Value);

                // Crear un formulario para mostrar la información del repuesto
                FrmMostrarRepuesto mostrarRepuestoForm = new FrmMostrarRepuesto(repuestoId, repuestoService);

                // Suscribirte al evento FormClosed de FrmMostrarRepuesto
                mostrarRepuestoForm.FormClosedEvent += FrmMostrarRepuesto_FormClosed;

                // Mostrar el formulario
                mostrarRepuestoForm.Show();
            }
        }

        private void FrmMostrarRepuesto_FormClosed(object sender, EventArgs e)
        {
            // El evento se dispara cuando se cierra FrmMostrarRepuesto
            // Aquí puedes actualizar la tabla llamando a tu método CargarDatos()
            CargarDatos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int ID = GetIDRepuesto();

            if (ID > 0)
            {
                int repuestoId = Convert.ToInt32(dgvListaRepuestos.CurrentRow.Cells["ID"].Value);

                // Crear un formulario para mostrar la información del cliente
                FrmMostrarRepuesto mostrarRepuestoForm = new FrmMostrarRepuesto(repuestoId, repuestoService);

                // Suscribirte al evento FormClosed de FrmMostrarCliente
                mostrarRepuestoForm.FormClosedEvent += FrmMostrarRepuesto_FormClosed;

                // Mostrar el formulario
                mostrarRepuestoForm.Show();
            }
        }

        private int GetIDRepuesto()
        {
            try
            {
                return int.Parse(dgvListaRepuestos.Rows[dgvListaRepuestos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                IDRepuesto = GetIDRepuesto();

                if (IDRepuesto != null)
                {
                    if (MessageBox.Show("Desea eliminar él Repuesto?", "Operacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        repuestoService.Delete(IDRepuesto);
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona el Repuesto que desea ELIMINAR", "Error al ELIMINAR registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
