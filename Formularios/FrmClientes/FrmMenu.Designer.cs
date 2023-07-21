namespace FrmClientes
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelSIdeMenu = new System.Windows.Forms.Panel();
            panelSubMenuEstadistica = new System.Windows.Forms.Panel();
            btn_Destino = new System.Windows.Forms.Button();
            btn_CantPasajeros = new System.Windows.Forms.Button();
            btn_Recaudacion = new System.Windows.Forms.Button();
            btn_Estadisticas = new System.Windows.Forms.Button();
            panelSubMenuLstados = new System.Windows.Forms.Panel();
            btn_ListaRepuestos = new System.Windows.Forms.Button();
            btn_ListaClientes = new System.Windows.Forms.Button();
            btn_Listados = new System.Windows.Forms.Button();
            panelSubMenuClientes = new System.Windows.Forms.Panel();
            btn_Eliminar = new System.Windows.Forms.Button();
            btn_Modificar = new System.Windows.Forms.Button();
            btn_Cargar = new System.Windows.Forms.Button();
            btn_Clientes = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            panelFormulario = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panelSIdeMenu.SuspendLayout();
            panelSubMenuEstadistica.SuspendLayout();
            panelSubMenuLstados.SuspendLayout();
            panelSubMenuClientes.SuspendLayout();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSIdeMenu
            // 
            panelSIdeMenu.AutoScroll = true;
            panelSIdeMenu.BackColor = System.Drawing.Color.Black;
            panelSIdeMenu.Controls.Add(panelSubMenuEstadistica);
            panelSIdeMenu.Controls.Add(btn_Estadisticas);
            panelSIdeMenu.Controls.Add(panelSubMenuLstados);
            panelSIdeMenu.Controls.Add(btn_Listados);
            panelSIdeMenu.Controls.Add(panelSubMenuClientes);
            panelSIdeMenu.Controls.Add(btn_Clientes);
            panelSIdeMenu.Controls.Add(panelLogo);
            panelSIdeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelSIdeMenu.Location = new System.Drawing.Point(0, 0);
            panelSIdeMenu.Name = "panelSIdeMenu";
            panelSIdeMenu.Size = new System.Drawing.Size(200, 561);
            panelSIdeMenu.TabIndex = 6;
            // 
            // panelSubMenuEstadistica
            // 
            panelSubMenuEstadistica.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuEstadistica.Controls.Add(btn_Destino);
            panelSubMenuEstadistica.Controls.Add(btn_CantPasajeros);
            panelSubMenuEstadistica.Controls.Add(btn_Recaudacion);
            panelSubMenuEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuEstadistica.Location = new System.Drawing.Point(0, 370);
            panelSubMenuEstadistica.Name = "panelSubMenuEstadistica";
            panelSubMenuEstadistica.Size = new System.Drawing.Size(200, 102);
            panelSubMenuEstadistica.TabIndex = 6;
            panelSubMenuEstadistica.Visible = false;
            // 
            // btn_Destino
            // 
            btn_Destino.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Destino.FlatAppearance.BorderSize = 0;
            btn_Destino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Destino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Destino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Destino.ForeColor = System.Drawing.Color.LightGray;
            btn_Destino.Location = new System.Drawing.Point(0, 69);
            btn_Destino.Name = "btn_Destino";
            btn_Destino.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Destino.Size = new System.Drawing.Size(200, 30);
            btn_Destino.TabIndex = 4;
            btn_Destino.Text = "Destino mas elegido";
            btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Destino.UseVisualStyleBackColor = true;
            // 
            // btn_CantPasajeros
            // 
            btn_CantPasajeros.Dock = System.Windows.Forms.DockStyle.Top;
            btn_CantPasajeros.FlatAppearance.BorderSize = 0;
            btn_CantPasajeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_CantPasajeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_CantPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_CantPasajeros.ForeColor = System.Drawing.Color.LightGray;
            btn_CantPasajeros.Location = new System.Drawing.Point(0, 30);
            btn_CantPasajeros.Name = "btn_CantPasajeros";
            btn_CantPasajeros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_CantPasajeros.Size = new System.Drawing.Size(200, 39);
            btn_CantPasajeros.TabIndex = 3;
            btn_CantPasajeros.Text = "Cant. de pasajeros por crucero";
            btn_CantPasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_CantPasajeros.UseVisualStyleBackColor = true;
            // 
            // btn_Recaudacion
            // 
            btn_Recaudacion.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Recaudacion.FlatAppearance.BorderSize = 0;
            btn_Recaudacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Recaudacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Recaudacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Recaudacion.ForeColor = System.Drawing.Color.LightGray;
            btn_Recaudacion.Location = new System.Drawing.Point(0, 0);
            btn_Recaudacion.Name = "btn_Recaudacion";
            btn_Recaudacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Recaudacion.Size = new System.Drawing.Size(200, 30);
            btn_Recaudacion.TabIndex = 2;
            btn_Recaudacion.Text = "Recaudación";
            btn_Recaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Recaudacion.UseVisualStyleBackColor = true;
            // 
            // btn_Estadisticas
            // 
            btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Estadisticas.FlatAppearance.BorderSize = 0;
            btn_Estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Estadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Estadisticas.Location = new System.Drawing.Point(0, 330);
            btn_Estadisticas.Name = "btn_Estadisticas";
            btn_Estadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Estadisticas.Size = new System.Drawing.Size(200, 40);
            btn_Estadisticas.TabIndex = 5;
            btn_Estadisticas.Text = "Estadisticas";
            btn_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Estadisticas.UseVisualStyleBackColor = true;
            btn_Estadisticas.Click += btn_Estadisticas_Click;
            // 
            // panelSubMenuLstados
            // 
            panelSubMenuLstados.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuLstados.Controls.Add(btn_ListaRepuestos);
            panelSubMenuLstados.Controls.Add(btn_ListaClientes);
            panelSubMenuLstados.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuLstados.Location = new System.Drawing.Point(0, 265);
            panelSubMenuLstados.Name = "panelSubMenuLstados";
            panelSubMenuLstados.Size = new System.Drawing.Size(200, 65);
            panelSubMenuLstados.TabIndex = 4;
            panelSubMenuLstados.Visible = false;
            // 
            // btn_ListaRepuestos
            // 
            btn_ListaRepuestos.Dock = System.Windows.Forms.DockStyle.Top;
            btn_ListaRepuestos.FlatAppearance.BorderSize = 0;
            btn_ListaRepuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_ListaRepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_ListaRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ListaRepuestos.ForeColor = System.Drawing.Color.LightGray;
            btn_ListaRepuestos.Location = new System.Drawing.Point(0, 30);
            btn_ListaRepuestos.Name = "btn_ListaRepuestos";
            btn_ListaRepuestos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_ListaRepuestos.Size = new System.Drawing.Size(200, 32);
            btn_ListaRepuestos.TabIndex = 3;
            btn_ListaRepuestos.Text = "Lista Repuestos";
            btn_ListaRepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_ListaRepuestos.UseVisualStyleBackColor = true;
            // 
            // btn_ListaClientes
            // 
            btn_ListaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            btn_ListaClientes.FlatAppearance.BorderSize = 0;
            btn_ListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_ListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_ListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ListaClientes.ForeColor = System.Drawing.Color.LightGray;
            btn_ListaClientes.Location = new System.Drawing.Point(0, 0);
            btn_ListaClientes.Name = "btn_ListaClientes";
            btn_ListaClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_ListaClientes.Size = new System.Drawing.Size(200, 30);
            btn_ListaClientes.TabIndex = 2;
            btn_ListaClientes.Text = "Lista Clientes";
            btn_ListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_ListaClientes.UseVisualStyleBackColor = true;
            btn_ListaClientes.Click += btn_ListaClientes_Click;
            // 
            // btn_Listados
            // 
            btn_Listados.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Listados.FlatAppearance.BorderSize = 0;
            btn_Listados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Listados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Listados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Listados.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Listados.Location = new System.Drawing.Point(0, 225);
            btn_Listados.Name = "btn_Listados";
            btn_Listados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Listados.Size = new System.Drawing.Size(200, 40);
            btn_Listados.TabIndex = 3;
            btn_Listados.Text = "Listados";
            btn_Listados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Listados.UseVisualStyleBackColor = true;
            btn_Listados.Click += btn_Listados_Click;
            // 
            // panelSubMenuClientes
            // 
            panelSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuClientes.Controls.Add(btn_Eliminar);
            panelSubMenuClientes.Controls.Add(btn_Modificar);
            panelSubMenuClientes.Controls.Add(btn_Cargar);
            panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuClientes.Location = new System.Drawing.Point(0, 131);
            panelSubMenuClientes.Name = "panelSubMenuClientes";
            panelSubMenuClientes.Size = new System.Drawing.Size(200, 94);
            panelSubMenuClientes.TabIndex = 2;
            panelSubMenuClientes.Visible = false;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Eliminar.FlatAppearance.BorderSize = 0;
            btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Eliminar.ForeColor = System.Drawing.Color.LightGray;
            btn_Eliminar.Location = new System.Drawing.Point(0, 60);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Eliminar.Size = new System.Drawing.Size(200, 30);
            btn_Eliminar.TabIndex = 4;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Modificar.FlatAppearance.BorderSize = 0;
            btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Modificar.ForeColor = System.Drawing.Color.LightGray;
            btn_Modificar.Location = new System.Drawing.Point(0, 30);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Modificar.Size = new System.Drawing.Size(200, 30);
            btn_Modificar.TabIndex = 3;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Cargar
            // 
            btn_Cargar.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Cargar.FlatAppearance.BorderSize = 0;
            btn_Cargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Cargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cargar.ForeColor = System.Drawing.Color.LightGray;
            btn_Cargar.Location = new System.Drawing.Point(0, 0);
            btn_Cargar.Name = "btn_Cargar";
            btn_Cargar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Cargar.Size = new System.Drawing.Size(200, 30);
            btn_Cargar.TabIndex = 2;
            btn_Cargar.Text = "Cargar ";
            btn_Cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Cargar.UseVisualStyleBackColor = true;
            btn_Cargar.Click += btn_Cargar_Click;
            // 
            // btn_Clientes
            // 
            btn_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Clientes.FlatAppearance.BorderSize = 0;
            btn_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Clientes.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Clientes.Location = new System.Drawing.Point(0, 91);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Clientes.Size = new System.Drawing.Size(200, 40);
            btn_Clientes.TabIndex = 1;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(200, 91);
            panelLogo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
            panelFormulario.Controls.Add(pictureBox1);
            panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFormulario.Location = new System.Drawing.Point(200, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new System.Drawing.Size(1101, 561);
            panelFormulario.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(333, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(428, 405);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1301, 561);
            Controls.Add(panelFormulario);
            Controls.Add(panelSIdeMenu);
            IsMdiContainer = true;
            MinimumSize = new System.Drawing.Size(900, 600);
            Name = "FrmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Don Sergio's";
            Load += FrmMenu_Load;
            panelSIdeMenu.ResumeLayout(false);
            panelSubMenuEstadistica.ResumeLayout(false);
            panelSubMenuLstados.ResumeLayout(false);
            panelSubMenuClientes.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelSIdeMenu;
        private System.Windows.Forms.Panel panelSubMenuEstadistica;
        private System.Windows.Forms.Button btn_Destino;
        private System.Windows.Forms.Button btn_CantPasajeros;
        private System.Windows.Forms.Button btn_Recaudacion;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Panel panelSubMenuLstados;
        private System.Windows.Forms.Button btn_ListaRepuestos;
        private System.Windows.Forms.Button btn_ListaClientes;
        private System.Windows.Forms.Button btn_Listados;
        private System.Windows.Forms.Panel panelSubMenuClientes;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
