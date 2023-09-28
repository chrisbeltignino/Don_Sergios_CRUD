namespace DonSergios.Presentation.Presentation
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelFormulario = new Panel();
            panel2 = new Panel();
            btn_Refresh = new FontAwesome.Sharp.IconButton();
            cmb_Modelo = new ComboBox();
            txt_BuscarTelefono = new TextBox();
            txt_BuscarNombre = new TextBox();
            panel1 = new Panel();
            dgvListaClientes = new DataGridView();
            panelControl = new Panel();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            btn_Editar = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            mODELOSBindingSource = new BindingSource(components);
            panelFormulario.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mODELOSBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.FromArgb(64, 0, 64);
            panelFormulario.Controls.Add(panel2);
            panelFormulario.Controls.Add(panel1);
            panelFormulario.Controls.Add(panelControl);
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(0, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1156, 667);
            panelFormulario.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(50, 0, 50);
            panel2.Controls.Add(btn_Refresh);
            panel2.Controls.Add(cmb_Modelo);
            panel2.Controls.Add(txt_BuscarTelefono);
            panel2.Controls.Add(txt_BuscarNombre);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 45);
            panel2.TabIndex = 6;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Refresh.BackColor = Color.SteelBlue;
            btn_Refresh.FlatAppearance.BorderSize = 0;
            btn_Refresh.FlatStyle = FlatStyle.Flat;
            btn_Refresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Refresh.ForeColor = Color.White;
            btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btn_Refresh.IconColor = Color.White;
            btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Refresh.IconSize = 26;
            btn_Refresh.Location = new Point(1090, 7);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(34, 30);
            btn_Refresh.TabIndex = 3;
            btn_Refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // cmb_Modelo
            // 
            cmb_Modelo.FormattingEnabled = true;
            cmb_Modelo.Location = new Point(6, 13);
            cmb_Modelo.Name = "cmb_Modelo";
            cmb_Modelo.Size = new Size(167, 23);
            cmb_Modelo.TabIndex = 3;
            cmb_Modelo.SelectedIndexChanged += cmb_Modelo_SelectedIndexChanged;
            // 
            // txt_BuscarTelefono
            // 
            txt_BuscarTelefono.Location = new Point(359, 13);
            txt_BuscarTelefono.Name = "txt_BuscarTelefono";
            txt_BuscarTelefono.PlaceholderText = "Buscar por Telefono";
            txt_BuscarTelefono.Size = new Size(174, 23);
            txt_BuscarTelefono.TabIndex = 5;
            txt_BuscarTelefono.TextChanged += txt_BuscarTelefono_TextChanged;
            // 
            // txt_BuscarNombre
            // 
            txt_BuscarNombre.Location = new Point(179, 13);
            txt_BuscarNombre.Name = "txt_BuscarNombre";
            txt_BuscarNombre.PlaceholderText = "Buscar por Nombre";
            txt_BuscarNombre.Size = new Size(174, 23);
            txt_BuscarNombre.TabIndex = 4;
            txt_BuscarNombre.TextChanged += txt_BuscarNombre_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvListaClientes);
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 527);
            panel1.TabIndex = 2;
            // 
            // dgvListaClientes
            // 
            dgvListaClientes.AllowUserToAddRows = false;
            dgvListaClientes.AllowUserToDeleteRows = false;
            dgvListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaClientes.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaClientes.Dock = DockStyle.Fill;
            dgvListaClientes.Location = new Point(0, 0);
            dgvListaClientes.Name = "dgvListaClientes";
            dgvListaClientes.ReadOnly = true;
            dgvListaClientes.RowTemplate.Height = 25;
            dgvListaClientes.Size = new Size(1130, 527);
            dgvListaClientes.TabIndex = 0;
            dgvListaClientes.CellDoubleClick += dgvListaClientes_CellDoubleClick;
            // 
            // panelControl
            // 
            panelControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl.AutoSize = true;
            panelControl.BackColor = Color.FromArgb(50, 0, 50);
            panelControl.Controls.Add(btn_Eliminar);
            panelControl.Controls.Add(btn_Editar);
            panelControl.Controls.Add(btn_Agregar);
            panelControl.Location = new Point(12, 596);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1130, 59);
            panelControl.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.Left;
            btn_Eliminar.BackColor = Color.Firebrick;
            btn_Eliminar.FlatAppearance.BorderSize = 0;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            btn_Eliminar.IconColor = Color.White;
            btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar.IconSize = 30;
            btn_Eliminar.Location = new Point(337, 9);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(151, 41);
            btn_Eliminar.TabIndex = 2;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Anchor = AnchorStyles.Left;
            btn_Editar.BackColor = Color.RoyalBlue;
            btn_Editar.FlatAppearance.BorderSize = 0;
            btn_Editar.FlatStyle = FlatStyle.Flat;
            btn_Editar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Editar.ForeColor = Color.White;
            btn_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btn_Editar.IconColor = Color.White;
            btn_Editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Editar.IconSize = 30;
            btn_Editar.Location = new Point(173, 9);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(151, 41);
            btn_Editar.TabIndex = 1;
            btn_Editar.Text = "Editar";
            btn_Editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Left;
            btn_Agregar.BackColor = Color.SeaGreen;
            btn_Agregar.FlatAppearance.BorderSize = 0;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btn_Agregar.IconColor = Color.White;
            btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Agregar.IconSize = 30;
            btn_Agregar.Location = new Point(9, 9);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(151, 41);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // mODELOSBindingSource
            // 
            mODELOSBindingSource.DataSource = typeof(Domain.Entities.MODELOS);
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 667);
            Controls.Add(panelFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientes";
            Text = "Clientes";
            Load += FrmClientes_Load;
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaClientes).EndInit();
            panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mODELOSBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormulario;
        private DataGridView dgvListaClientes;
        private Panel panelControl;
        private Panel panel1;
        private TextBox txt_BuscarTelefono;
        private TextBox txt_BuscarNombre;
        private ComboBox cmb_Modelo;
        private BindingSource mODELOSBindingSource;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private Panel panel2;
    }
}