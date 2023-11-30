namespace DonSergios.Presentation.Presentation
{
    partial class FrmRepuestos
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
            panel1 = new Panel();
            dgvListaRepuestos = new DataGridView();
            panelControl = new Panel();
            btn_Refresh = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            btn_Editar = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaRepuestos).BeginInit();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvListaRepuestos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 578);
            panel1.TabIndex = 8;
            // 
            // dgvListaRepuestos
            // 
            dgvListaRepuestos.AllowUserToAddRows = false;
            dgvListaRepuestos.AllowUserToDeleteRows = false;
            dgvListaRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaRepuestos.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvListaRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRepuestos.Dock = DockStyle.Fill;
            dgvListaRepuestos.Location = new Point(0, 0);
            dgvListaRepuestos.Name = "dgvListaRepuestos";
            dgvListaRepuestos.ReadOnly = true;
            dgvListaRepuestos.RowTemplate.Height = 25;
            dgvListaRepuestos.Size = new Size(1130, 578);
            dgvListaRepuestos.TabIndex = 0;
            dgvListaRepuestos.CellDoubleClick += dgvListaRepuestos_CellDoubleClick;
            // 
            // panelControl
            // 
            panelControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl.AutoSize = true;
            panelControl.BackColor = Color.FromArgb(50, 0, 50);
            panelControl.Controls.Add(btn_Refresh);
            panelControl.Controls.Add(btn_Eliminar);
            panelControl.Controls.Add(btn_Editar);
            panelControl.Controls.Add(btn_Agregar);
            panelControl.Location = new Point(12, 596);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1130, 59);
            panelControl.TabIndex = 7;
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
            btn_Refresh.Location = new Point(1082, 14);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(34, 30);
            btn_Refresh.TabIndex = 6;
            btn_Refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
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
            btn_Eliminar.Location = new Point(334, 9);
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
            btn_Editar.Location = new Point(170, 9);
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
            btn_Agregar.Location = new Point(6, 9);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(151, 41);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // FrmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1156, 667);
            Controls.Add(panel1);
            Controls.Add(panelControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRepuestos";
            Text = "Repuestos";
            Load += FrmRepuestos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaRepuestos).EndInit();
            panelControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvListaRepuestos;
        private Panel panelControl;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Refresh;
    }
}