using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
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
    public partial class FrmAgregarRepuesto : Form
    {
        private readonly IRepuestoService repuestoService;

        byte[] imageByte;

        public FrmAgregarRepuesto(IRepuestoService repuestoService)
        {
            InitializeComponent();

            this.repuestoService = repuestoService;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImage = new OpenFileDialog();
            selectorImage.Title = "Seleccionar imagen";

            if (selectorImage.ShowDialog() == DialogResult.OK)
            {
                pb_Imagen.Image = Image.FromStream(selectorImage.OpenFile());
                MemoryStream memoria = new MemoryStream();
                pb_Imagen.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                imageByte = memoria.ToArray();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTxt() == true)
                {
                    // Recopila los datos de los campos de entrada
                    string nombreRepuesto = txt_Nombre.Text;
                    string marcaRepuesto = txt_Marca.Text;
                    string descripcionRepuesto = txt_Descripcion.Text;
                    int precioRepuesto = Convert.ToInt32(txt_Precio.Text);
                    byte[] imagenRepuesto = imageByte;

                    // Crea una instancia de la entidad REPUESTOS
                    var repuesto = new REPUESTOS
                    {
                        NOMBRE = nombreRepuesto,
                        MARCA = marcaRepuesto,
                        DESCRIPCION = descripcionRepuesto,
                        PRECIO = precioRepuesto,
                        IMAGEN = imagenRepuesto // Aquí asigna el arreglo de bytes de la imagen que seleccione
                    };

                    // Llama al servicio y repositorio para guardar el repuesto en la base de datos
                    repuestoService.Create(repuesto);

                    // Limpia los campos después de guardar los datos
                    LimpiarCampos();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el proceso de guardado
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Marca.Clear();
            txt_Descripcion.Clear();
            txt_Precio.Clear();
        }

        private bool ValidarTxt()
        {
            return txt_Nombre.Text != string.Empty || txt_Marca.Text != string.Empty || txt_Descripcion.Text != string.Empty || txt_Precio.Text != string.Empty;
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permite que el caracter sea ingresado en el TextBox
            }
        }
    }
}
