using ClassClientes;
using FrmClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDonSergios
{
    public partial class FrmListadoClientes : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        //private static int lastClientId = 0;

        public FrmListadoClientes()
        {
            InitializeComponent();
        }
        /*
        public FrmListadoClientes(List<Cliente> cliente) : this()
        {
            this.clientes = cliente;
        }
        */
        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            this.clientes = FrmMenu.listaCliente;

            foreach (Cliente item in this.clientes)
            {
                DataGridClientes(item);
            }
            //MostrarClientes();
        }

        private void DataGridClientes(Cliente clienteAux)
        {
            DataGridViewRow filaUno = new DataGridViewRow();

            filaUno.CreateCells(this.dgvClientes);

            filaUno.Cells[0].Value = clienteAux.ID;
            filaUno.Cells[1].Value = clienteAux.Nombre;
            filaUno.Cells[2].Value = clienteAux.Apellido;
            filaUno.Cells[3].Value = clienteAux.Direccion;
            filaUno.Cells[4].Value = clienteAux.Telefono;
            filaUno.Cells[5].Value = clienteAux.Facebook;
            filaUno.Cells[6].Value = clienteAux.Auto.Patente;
            filaUno.Cells[7].Value = clienteAux.Auto.EnumModelo;
            filaUno.Cells[8].Value = clienteAux.Auto.EnumAño;
            filaUno.Cells[9].Value = clienteAux.Servicio.Problemas;
            filaUno.Cells[10].Value = clienteAux.Servicio.PruebasRealizadas;
            filaUno.Cells[11].Value = clienteAux.Servicio.Repuestos;
            filaUno.Cells[12].Value = $"${clienteAux.Servicio.Precio}";
            filaUno.Cells[13].Value = clienteAux.Servicio.Observaciones;
            filaUno.Cells[14].Value = clienteAux.FechaLlegada.ToString("dd/MM/yyyy");
            filaUno.Cells[15].Value = clienteAux.FechaSalida.ToString("dd/MM/yyyy");


            this.dgvClientes.Rows.Add(filaUno);
        }

        /*
        private void MostrarClientes()
        {
            dgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.ID,
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Direccion,
                    cliente.Telefono,
                    cliente.Facebook,
                    cliente.Auto.Patente,
                    cliente.Auto.EnumModelo,
                    cliente.Auto.EnumAño,
                    cliente.Servicio.Problemas,
                    cliente.Servicio.PruebasRealizadas,
                    cliente.Servicio.Repuestos,
                    cliente.Servicio.Precio,
                    cliente.Servicio.Observaciones,
                    cliente.FechaLlegada,
                    cliente.FechaSalida
                );
            }
        }*/
    }
}
