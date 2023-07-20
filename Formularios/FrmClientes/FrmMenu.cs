using ClassClientes;
using FrmDonSergios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClientes
{
    public partial class FrmMenu : Form
    {
        public static List<Cliente> listaCLiente = new List<Cliente>();

        public static FrmCargaClient formCliente = new FrmCargaClient();
        public static FrmListadoClientes formListadoCliente = new FrmListadoClientes();

        private Form activeForm = new Form();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (panelSubMenuClientes.Visible == true)
            {
                panelSubMenuClientes.Visible = false;
            }
            if (panelSubMenuLstados.Visible == true)
            {
                panelSubMenuLstados.Visible = false;
            }
            if (panelSubMenuEstadistica.Visible == true)
            {
                panelSubMenuEstadistica.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.MdiParent = this;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(childForm);
                panelFormulario.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuClientes);
        }

        private void btn_Listados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLstados);
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEstadistica);
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            FrmCargaClient newForm = new FrmCargaClient();
            formCliente = newForm;

            openChildForm(FrmMenu.formCliente);

            hideSubMenu();
        }

        private void btn_ListaClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes newForm = new FrmListadoClientes();
            formListadoCliente = newForm;

            openChildForm(FrmMenu.formListadoCliente);

            hideSubMenu();
        }
    }
}
