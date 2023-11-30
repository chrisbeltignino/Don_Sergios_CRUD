namespace DonSergios.Presentation.Presentation
{
    partial class FrmAgregarRepuesto
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
            txt_Descripcion = new TextBox();
            btn_AgregarIMG = new FontAwesome.Sharp.IconButton();
            btn_Cancelar = new FontAwesome.Sharp.IconButton();
            btn_Aceptar = new FontAwesome.Sharp.IconButton();
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
            gpb_Campos.Controls.Add(txt_Descripcion);
            gpb_Campos.Controls.Add(btn_AgregarIMG);
            gpb_Campos.Controls.Add(btn_Cancelar);
            gpb_Campos.Controls.Add(btn_Aceptar);
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
            gpb_Campos.Location = new Point(12, 12);
            gpb_Campos.Name = "gpb_Campos";
            gpb_Campos.Size = new Size(749, 455);
            gpb_Campos.TabIndex = 1;
            gpb_Campos.TabStop = false;
            gpb_Campos.Text = "Campos a llenar";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Descripcion.Location = new Point(119, 212);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(241, 172);
            txt_Descripcion.TabIndex = 38;
            // 
            // btn_AgregarIMG
            // 
            btn_AgregarIMG.Anchor = AnchorStyles.Left;
            btn_AgregarIMG.BackColor = Color.RoyalBlue;
            btn_AgregarIMG.FlatAppearance.BorderSize = 0;
            btn_AgregarIMG.FlatStyle = FlatStyle.Flat;
            btn_AgregarIMG.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AgregarIMG.ForeColor = Color.White;
            btn_AgregarIMG.IconChar = FontAwesome.Sharp.IconChar.Image;
            btn_AgregarIMG.IconColor = Color.White;
            btn_AgregarIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_AgregarIMG.IconSize = 30;
            btn_AgregarIMG.Location = new Point(486, 403);
            btn_AgregarIMG.Name = "btn_AgregarIMG";
            btn_AgregarIMG.Size = new Size(164, 40);
            btn_AgregarIMG.TabIndex = 37;
            btn_AgregarIMG.Text = "Agregar Imagen";
            btn_AgregarIMG.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AgregarIMG.UseVisualStyleBackColor = false;
            btn_AgregarIMG.Click += btn_AgregarIMG_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Left;
            btn_Cancelar.BackColor = Color.Firebrick;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            btn_Cancelar.IconColor = Color.White;
            btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Cancelar.IconSize = 24;
            btn_Cancelar.Location = new Point(240, 402);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(115, 41);
            btn_Cancelar.TabIndex = 36;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Anchor = AnchorStyles.Left;
            btn_Aceptar.BackColor = Color.SeaGreen;
            btn_Aceptar.FlatAppearance.BorderSize = 0;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Aceptar.ForeColor = Color.White;
            btn_Aceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btn_Aceptar.IconColor = Color.White;
            btn_Aceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Aceptar.IconSize = 30;
            btn_Aceptar.Location = new Point(83, 402);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(115, 41);
            btn_Aceptar.TabIndex = 35;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
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
            txt_Precio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Precio.Location = new Point(179, 157);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(129, 23);
            txt_Precio.TabIndex = 28;
            txt_Precio.KeyPress += txt_Precio_KeyPress;
            // 
            // txt_Marca
            // 
            txt_Marca.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Marca.Location = new Point(119, 103);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(241, 23);
            txt_Marca.TabIndex = 17;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(119, 43);
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
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // FrmAgregarRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(773, 482);
            Controls.Add(gpb_Campos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarRepuesto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            gpb_Campos.ResumeLayout(false);
            gpb_Campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_Campos;

        private TextBox txt_Precio;
        private TextBox txt_Marca;
        private TextBox txt_Nombre;
        private Label label13;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pb_Imagen;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_AgregarIMG;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Aceptar;
        private TextBox txt_Descripcion;
    }
}