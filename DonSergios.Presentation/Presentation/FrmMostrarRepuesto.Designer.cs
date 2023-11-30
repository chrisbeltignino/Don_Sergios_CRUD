namespace DonSergios.Presentation.Presentation
{
    partial class FrmMostrarRepuesto
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
            gpb_Campos = new GroupBox();
            txt_ID = new TextBox();
            label5 = new Label();
            btn_AgregarIMG = new FontAwesome.Sharp.IconButton();
            btn_Guardar = new FontAwesome.Sharp.IconButton();
            btn_Editar = new FontAwesome.Sharp.IconButton();
            txt_Descripcion = new TextBox();
            pb_Imagen = new PictureBox();
            label4 = new Label();
            txt_Precio = new TextBox();
            txt_Marca = new TextBox();
            txt_Nombre = new TextBox();
            label13 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gpb_Campos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Imagen).BeginInit();
            SuspendLayout();
            // 
            // gpb_Campos
            // 
            gpb_Campos.Controls.Add(txt_ID);
            gpb_Campos.Controls.Add(label5);
            gpb_Campos.Controls.Add(btn_AgregarIMG);
            gpb_Campos.Controls.Add(btn_Guardar);
            gpb_Campos.Controls.Add(btn_Editar);
            gpb_Campos.Controls.Add(txt_Descripcion);
            gpb_Campos.Controls.Add(pb_Imagen);
            gpb_Campos.Controls.Add(label4);
            gpb_Campos.Controls.Add(txt_Precio);
            gpb_Campos.Controls.Add(txt_Marca);
            gpb_Campos.Controls.Add(txt_Nombre);
            gpb_Campos.Controls.Add(label13);
            gpb_Campos.Controls.Add(label3);
            gpb_Campos.Controls.Add(label2);
            gpb_Campos.Controls.Add(label1);
            gpb_Campos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gpb_Campos.ForeColor = Color.White;
            gpb_Campos.Location = new Point(12, 14);
            gpb_Campos.Name = "gpb_Campos";
            gpb_Campos.Size = new Size(749, 455);
            gpb_Campos.TabIndex = 2;
            gpb_Campos.TabStop = false;
            gpb_Campos.Text = "Campos a llenar";
            // 
            // txt_ID
            // 
            txt_ID.Enabled = false;
            txt_ID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ID.Location = new Point(119, 28);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(70, 23);
            txt_ID.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 28);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 45;
            label5.Text = "ID:";
            // 
            // btn_AgregarIMG
            // 
            btn_AgregarIMG.Anchor = AnchorStyles.Left;
            btn_AgregarIMG.BackColor = Color.RoyalBlue;
            btn_AgregarIMG.Enabled = false;
            btn_AgregarIMG.FlatAppearance.BorderSize = 0;
            btn_AgregarIMG.FlatStyle = FlatStyle.Flat;
            btn_AgregarIMG.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AgregarIMG.ForeColor = Color.White;
            btn_AgregarIMG.IconChar = FontAwesome.Sharp.IconChar.Image;
            btn_AgregarIMG.IconColor = Color.White;
            btn_AgregarIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_AgregarIMG.IconSize = 30;
            btn_AgregarIMG.Location = new Point(482, 401);
            btn_AgregarIMG.Name = "btn_AgregarIMG";
            btn_AgregarIMG.Size = new Size(164, 40);
            btn_AgregarIMG.TabIndex = 44;
            btn_AgregarIMG.Text = "Agregar Imagen";
            btn_AgregarIMG.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AgregarIMG.UseVisualStyleBackColor = false;
            btn_AgregarIMG.Click += btn_AgregarIMG_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Anchor = AnchorStyles.Left;
            btn_Guardar.BackColor = Color.SeaGreen;
            btn_Guardar.Enabled = false;
            btn_Guardar.FlatAppearance.BorderSize = 0;
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btn_Guardar.IconColor = Color.White;
            btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Guardar.IconSize = 30;
            btn_Guardar.Location = new Point(223, 400);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(128, 41);
            btn_Guardar.TabIndex = 43;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
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
            btn_Editar.Location = new Point(52, 400);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(128, 41);
            btn_Editar.TabIndex = 42;
            btn_Editar.Text = "Editar";
            btn_Editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Enabled = false;
            txt_Descripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Descripcion.Location = new Point(119, 212);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(241, 172);
            txt_Descripcion.TabIndex = 38;
            // 
            // pb_Imagen
            // 
            pb_Imagen.BackColor = Color.FromArgb(50, 0, 50);
            pb_Imagen.Location = new Point(386, 43);
            pb_Imagen.Name = "pb_Imagen";
            pb_Imagen.Size = new Size(350, 350);
            pb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Imagen.TabIndex = 34;
            pb_Imagen.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 19);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 33;
            label4.Text = "Imagen:";
            // 
            // txt_Precio
            // 
            txt_Precio.Enabled = false;
            txt_Precio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Precio.Location = new Point(179, 157);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(129, 23);
            txt_Precio.TabIndex = 28;
            txt_Precio.KeyPress += txt_Precio_KeyPress;
            // 
            // txt_Marca
            // 
            txt_Marca.Enabled = false;
            txt_Marca.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Marca.Location = new Point(119, 103);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(241, 23);
            txt_Marca.TabIndex = 17;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Enabled = false;
            txt_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(119, 64);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(241, 23);
            txt_Nombre.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 155);
            label13.Name = "label13";
            label13.Size = new Size(137, 21);
            label13.TabIndex = 13;
            label13.Text = "Precio: (Aprox) $";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 212);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // FrmMostrarRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(773, 482);
            Controls.Add(gpb_Campos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMostrarRepuesto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += FrmMostrarRepuesto_FormClosed;
            gpb_Campos.ResumeLayout(false);
            gpb_Campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_Campos;
        private TextBox txt_Descripcion;
        private PictureBox pb_Imagen;
        private Label label4;
        private TextBox txt_Precio;
        private TextBox txt_Marca;
        private TextBox txt_Nombre;
        private Label label13;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_Editar;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private FontAwesome.Sharp.IconButton btn_AgregarIMG;
        private TextBox txt_ID;
        private Label label5;
    }
}