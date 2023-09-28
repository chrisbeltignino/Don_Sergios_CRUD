using DonSergios.Applications.Interfaces;
using DonSergios.Infraestructure.Persistence;

namespace DonSergios.Presentation.Presentation
{
    public partial class FrmAutos : Form
    {
        private readonly IClienteService clienteService;
        private readonly IAutoService autoService;
        private readonly IServicioService servicioService;
        private readonly IModeloService modeloService;

        private DBDON_SERGIOSEntities db;

        public FrmAutos(IClienteService clienteService, IAutoService autoService, IServicioService servicioService, IModeloService modeloService, DBDON_SERGIOSEntities db)
        {
            InitializeComponent();

            this.clienteService = clienteService;
            this.autoService = autoService;
            this.servicioService = servicioService;
            this.modeloService = modeloService;
            this.db = db;
        }

        private void FrmAutos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvListaAutos.AutoGenerateColumns = false;
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
                            ID = c.ID_AUTO,
                            Patente = a.PATENTE,
                            Modelo = m.MODELO,
                            Motor = a.MOTOR,
                            Año = a.AÑO,
                            ID_Cliente = c.ID,
                            Nombre = c.NOMBRES,
                            Apellido = c.APELLIDOS,
                            NumeroTelefono = c.TELEFONO,
                            Problemas = s.PROBLEMAS,
                            PruebasRealizadas = s.PRUEBAS,
                            Repuestos = s.REPUESTOS,
                            Observaciones = s.OBSERVACIONES,
                            Precio = s.PRECIO,
                            FechaLlegada = s.FECHA_LLEGADA,
                            FechaSalida = s.FECHA_SALIDA
                        };

            // Establece la fuente de datos del DataGridView
            dgvListaAutos.DataSource = query.ToList();
        }
    }
}
