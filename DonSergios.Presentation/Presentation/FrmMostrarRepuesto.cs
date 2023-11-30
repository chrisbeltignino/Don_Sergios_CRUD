using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
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
    public partial class FrmMostrarRepuesto : Form
    {
        private readonly IRepuestoService repuestoService;
        private int repuestoID;                                             // Agrega un campo para almacenar el ID del repuesto

        byte[] imageByte;

        // En FrmMostrarRepuesto
        public event EventHandler FormClosedEvent;

        public FrmMostrarRepuesto(int repuestoID, IRepuestoService repuestoService)
        {
            InitializeComponent();

            this.repuestoService = repuestoService;
            this.repuestoID = repuestoID;

            CargarDatosRepuesto(repuestoID);
        }

        private void FrmMostrarRepuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
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

        private void CargarDatosRepuesto(int repuestoID)
        {
            try
            {
                // Obtiene el repuesto desde la base de datos utilizando el servicio
                REPUESTOS repuesto = repuestoService.GetRepuestoByID(repuestoID);

                // Verifica si se encontró el repuesto
                if (repuesto != null)
                {
                    // Llena los campos del formulario con los datos del repuesto
                    txt_ID.Text = repuesto.ID_REPUESTO.ToString();
                    txt_Nombre.Text = repuesto.NOMBRE;
                    txt_Marca.Text = repuesto.MARCA;
                    txt_Precio.Text = repuesto.PRECIO.ToString();
                    txt_Descripcion.Text = repuesto.DESCRIPCION;
                    if (repuesto.IMAGEN != null)
                    {
                        MemoryStream ms = new MemoryStream(repuesto.IMAGEN);
                        Image imagen = Image.FromStream(ms);
                        pb_Imagen.Image = imagen;
                        //pb_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageByte = ms.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("El repuesto no se encontró en la base de datos.", "Repuesto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del repuesto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Enabled = true;
            txt_Marca.Enabled = true;
            txt_Precio.Enabled = true;
            txt_Descripcion.Enabled = true;
            btn_AgregarIMG.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Marca.Clear();
            txt_Precio.Clear();
            txt_Descripcion.Clear();
        }

        private bool ValidarTxt()
        {
            return txt_Nombre.Text != string.Empty || txt_Descripcion.Text != string.Empty || txt_Marca.Text != string.Empty;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTxt() == true)
                {
                    if (MessageBox.Show("Desea guardar los cambios?", "Guardado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Recupera el repuesto de la base de datos para asegurarte de que estás trabajando con los datos más recientes
                        REPUESTOS repuesto = repuestoService.GetRepuestoByID(this.repuestoID);

                        // Actualiza los campos del repuesto con los nuevos valores ingresados en el formulario
                        repuesto.ID_REPUESTO = this.repuestoID;
                        repuesto.NOMBRE = txt_Nombre.Text;
                        repuesto.MARCA = txt_Marca.Text;
                        repuesto.PRECIO = Convert.ToInt32(txt_Precio.Text);
                        repuesto.DESCRIPCION = txt_Descripcion.Text;
                        repuesto.IMAGEN = imageByte;

                        repuestoService.Update(repuesto);

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
