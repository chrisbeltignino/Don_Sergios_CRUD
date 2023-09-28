namespace DonSergios.Presentation.Presentation
{
    partial class FrmAgregarCliente
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
            cmb_Modelo = new ComboBox();
            btn_Cancelar = new FontAwesome.Sharp.IconButton();
            btn_Aceptar = new FontAwesome.Sharp.IconButton();
            dtp_Salida = new DateTimePicker();
            dtp_Llegada = new DateTimePicker();
            txt_PrecioTotal = new TextBox();
            txt_Repuestos = new TextBox();
            txt_Pruebas = new TextBox();
            txt_Observaciones = new TextBox();
            txt_Problemas = new TextBox();
            txt_Año = new TextBox();
            txt_Patente = new TextBox();
            txt_Facebook = new TextBox();
            txt_Telefono = new TextBox();
            txt_Direccion = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Motor = new TextBox();
            label16 = new Label();
            gpb_Campos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_Campos
            // 
            gpb_Campos.Controls.Add(txt_Motor);
            gpb_Campos.Controls.Add(label16);
            gpb_Campos.Controls.Add(cmb_Modelo);
            gpb_Campos.Controls.Add(btn_Cancelar);
            gpb_Campos.Controls.Add(btn_Aceptar);
            gpb_Campos.Controls.Add(dtp_Salida);
            gpb_Campos.Controls.Add(dtp_Llegada);
            gpb_Campos.Controls.Add(txt_PrecioTotal);
            gpb_Campos.Controls.Add(txt_Repuestos);
            gpb_Campos.Controls.Add(txt_Pruebas);
            gpb_Campos.Controls.Add(txt_Observaciones);
            gpb_Campos.Controls.Add(txt_Problemas);
            gpb_Campos.Controls.Add(txt_Año);
            gpb_Campos.Controls.Add(txt_Patente);
            gpb_Campos.Controls.Add(txt_Facebook);
            gpb_Campos.Controls.Add(txt_Telefono);
            gpb_Campos.Controls.Add(txt_Direccion);
            gpb_Campos.Controls.Add(txt_Apellido);
            gpb_Campos.Controls.Add(txt_Nombre);
            gpb_Campos.Controls.Add(label15);
            gpb_Campos.Controls.Add(label14);
            gpb_Campos.Controls.Add(label13);
            gpb_Campos.Controls.Add(label12);
            gpb_Campos.Controls.Add(label11);
            gpb_Campos.Controls.Add(label10);
            gpb_Campos.Controls.Add(label9);
            gpb_Campos.Controls.Add(label8);
            gpb_Campos.Controls.Add(label7);
            gpb_Campos.Controls.Add(label6);
            gpb_Campos.Controls.Add(label5);
            gpb_Campos.Controls.Add(label4);
            gpb_Campos.Controls.Add(label3);
            gpb_Campos.Controls.Add(label2);
            gpb_Campos.Controls.Add(label1);
            gpb_Campos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gpb_Campos.ForeColor = Color.White;
            gpb_Campos.Location = new Point(12, 12);
            gpb_Campos.Name = "gpb_Campos";
            gpb_Campos.Size = new Size(910, 550);
            gpb_Campos.TabIndex = 0;
            gpb_Campos.TabStop = false;
            gpb_Campos.Text = "Campos a llenar";
            // 
            // cmb_Modelo
            // 
            cmb_Modelo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Modelo.FormattingEnabled = true;
            cmb_Modelo.Location = new Point(115, 294);
            cmb_Modelo.Name = "cmb_Modelo";
            cmb_Modelo.Size = new Size(147, 23);
            cmb_Modelo.TabIndex = 33;
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
            btn_Cancelar.Location = new Point(741, 485);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(151, 41);
            btn_Cancelar.TabIndex = 32;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Eliminar_Click;
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
            btn_Aceptar.Location = new Point(584, 485);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(151, 41);
            btn_Aceptar.TabIndex = 31;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // dtp_Salida
            // 
            dtp_Salida.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Salida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Salida.Location = new Point(211, 505);
            dtp_Salida.Name = "dtp_Salida";
            dtp_Salida.Size = new Size(236, 23);
            dtp_Salida.TabIndex = 30;
            // 
            // dtp_Llegada
            // 
            dtp_Llegada.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Llegada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Llegada.Location = new Point(211, 465);
            dtp_Llegada.Name = "dtp_Llegada";
            dtp_Llegada.Size = new Size(236, 23);
            dtp_Llegada.TabIndex = 29;
            // 
            // txt_PrecioTotal
            // 
            txt_PrecioTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PrecioTotal.Location = new Point(140, 422);
            txt_PrecioTotal.Name = "txt_PrecioTotal";
            txt_PrecioTotal.Size = new Size(100, 23);
            txt_PrecioTotal.TabIndex = 28;
            // 
            // txt_Repuestos
            // 
            txt_Repuestos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Repuestos.Location = new Point(608, 271);
            txt_Repuestos.Multiline = true;
            txt_Repuestos.Name = "txt_Repuestos";
            txt_Repuestos.Size = new Size(266, 172);
            txt_Repuestos.TabIndex = 27;
            // 
            // txt_Pruebas
            // 
            txt_Pruebas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Pruebas.Location = new Point(316, 271);
            txt_Pruebas.Multiline = true;
            txt_Pruebas.Name = "txt_Pruebas";
            txt_Pruebas.Size = new Size(266, 172);
            txt_Pruebas.TabIndex = 26;
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Observaciones.Location = new Point(608, 48);
            txt_Observaciones.Multiline = true;
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(266, 172);
            txt_Observaciones.TabIndex = 25;
            // 
            // txt_Problemas
            // 
            txt_Problemas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Problemas.Location = new Point(316, 48);
            txt_Problemas.Multiline = true;
            txt_Problemas.Name = "txt_Problemas";
            txt_Problemas.Size = new Size(266, 172);
            txt_Problemas.TabIndex = 24;
            // 
            // txt_Año
            // 
            txt_Año.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Año.Location = new Point(115, 334);
            txt_Año.Name = "txt_Año";
            txt_Año.Size = new Size(147, 23);
            txt_Año.TabIndex = 23;
            // 
            // txt_Patente
            // 
            txt_Patente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Patente.Location = new Point(115, 254);
            txt_Patente.Name = "txt_Patente";
            txt_Patente.Size = new Size(147, 23);
            txt_Patente.TabIndex = 21;
            // 
            // txt_Facebook
            // 
            txt_Facebook.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Facebook.Location = new Point(115, 213);
            txt_Facebook.Name = "txt_Facebook";
            txt_Facebook.Size = new Size(147, 23);
            txt_Facebook.TabIndex = 20;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Telefono.Location = new Point(115, 172);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(147, 23);
            txt_Telefono.TabIndex = 19;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.Location = new Point(115, 131);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(147, 23);
            txt_Direccion.TabIndex = 18;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Apellido.Location = new Point(115, 91);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(147, 23);
            txt_Apellido.TabIndex = 17;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.Location = new Point(115, 51);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(147, 23);
            txt_Nombre.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 505);
            label15.Name = "label15";
            label15.Size = new Size(190, 21);
            label15.TabIndex = 15;
            label15.Text = "Fecha de Salida(Aprox):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(64, 465);
            label14.Name = "label14";
            label14.Size = new Size(145, 21);
            label14.TabIndex = 14;
            label14.Text = "Fecha de Llegada:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 422);
            label13.Name = "label13";
            label13.Size = new Size(117, 21);
            label13.TabIndex = 13;
            label13.Text = "Precio Total: $";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(608, 248);
            label12.Name = "label12";
            label12.Size = new Size(92, 21);
            label12.TabIndex = 12;
            label12.Text = "Repuestos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(608, 24);
            label11.Name = "label11";
            label11.Size = new Size(126, 21);
            label11.TabIndex = 11;
            label11.Text = "Observaciones:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(316, 245);
            label10.Name = "label10";
            label10.Size = new Size(156, 21);
            label10.TabIndex = 10;
            label10.Text = "Pruebas realizadas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 24);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 9;
            label9.Text = "Problemas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 332);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 8;
            label8.Text = "Año:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 296);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 7;
            label7.Text = "Modelo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 254);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 6;
            label6.Text = "Patente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 213);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 5;
            label5.Text = "Facebook:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 172);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 4;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 131);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 3;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 91);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Apellido/s:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre/s:";
            // 
            // txt_Motor
            // 
            txt_Motor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Motor.Location = new Point(115, 374);
            txt_Motor.Name = "txt_Motor";
            txt_Motor.Size = new Size(147, 23);
            txt_Motor.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(47, 372);
            label16.Name = "label16";
            label16.Size = new Size(62, 21);
            label16.TabIndex = 34;
            label16.Text = "Motor:";
            // 
            // FrmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(934, 574);
            Controls.Add(gpb_Campos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarCliente";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cliente";
            Load += FrmAgregarCliente_Load;
            gpb_Campos.ResumeLayout(false);
            gpb_Campos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_Campos;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_PrecioTotal;
        private TextBox txt_Repuestos;
        private TextBox txt_Pruebas;
        private TextBox txt_Observaciones;
        private TextBox txt_Problemas;
        private TextBox txt_Año;
        private TextBox txt_Patente;
        private TextBox txt_Facebook;
        private TextBox txt_Telefono;
        private TextBox txt_Direccion;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private DateTimePicker dtp_Salida;
        private DateTimePicker dtp_Llegada;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_Aceptar;
        private ComboBox cmb_Modelo;
        private TextBox txt_Motor;
        private Label label16;
    }
}