namespace DonSergios.Presentation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelMenu = new Panel();
            btn_Dashboard = new FontAwesome.Sharp.IconButton();
            btn_Repuestos = new FontAwesome.Sharp.IconButton();
            btn_Autos = new FontAwesome.Sharp.IconButton();
            btn_Clientes = new FontAwesome.Sharp.IconButton();
            panelPictureBox = new Panel();
            btn_Home = new PictureBox();
            cLIENTESBindingSource = new BindingSource(components);
            panelChildForm = new Panel();
            panel2 = new Panel();
            lbl_Fecha = new Label();
            lbl_Hora = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btn_Exit = new FontAwesome.Sharp.IconButton();
            btn_Maximize = new FontAwesome.Sharp.IconButton();
            btn_Minimize = new FontAwesome.Sharp.IconButton();
            lbl_TitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cLIENTESBindingSource).BeginInit();
            panelChildForm.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 0, 30);
            panelMenu.Controls.Add(btn_Dashboard);
            panelMenu.Controls.Add(btn_Repuestos);
            panelMenu.Controls.Add(btn_Autos);
            panelMenu.Controls.Add(btn_Clientes);
            panelMenu.Controls.Add(panelPictureBox);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(188, 729);
            panelMenu.TabIndex = 0;
            // 
            // btn_Dashboard
            // 
            btn_Dashboard.Dock = DockStyle.Top;
            btn_Dashboard.FlatAppearance.BorderSize = 0;
            btn_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_Dashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Dashboard.ForeColor = Color.Gainsboro;
            btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            btn_Dashboard.IconColor = Color.Gainsboro;
            btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Dashboard.Location = new Point(0, 283);
            btn_Dashboard.Name = "btn_Dashboard";
            btn_Dashboard.Size = new Size(188, 52);
            btn_Dashboard.TabIndex = 4;
            btn_Dashboard.Text = "Dashborad";
            btn_Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Dashboard.UseVisualStyleBackColor = true;
            btn_Dashboard.Click += btn_Dashboard_Click;
            // 
            // btn_Repuestos
            // 
            btn_Repuestos.Dock = DockStyle.Top;
            btn_Repuestos.FlatAppearance.BorderSize = 0;
            btn_Repuestos.FlatStyle = FlatStyle.Flat;
            btn_Repuestos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Repuestos.ForeColor = Color.Gainsboro;
            btn_Repuestos.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btn_Repuestos.IconColor = Color.Gainsboro;
            btn_Repuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Repuestos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Repuestos.Location = new Point(0, 231);
            btn_Repuestos.Name = "btn_Repuestos";
            btn_Repuestos.Size = new Size(188, 52);
            btn_Repuestos.TabIndex = 3;
            btn_Repuestos.Text = "Repuestos";
            btn_Repuestos.TextAlign = ContentAlignment.MiddleLeft;
            btn_Repuestos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Repuestos.UseVisualStyleBackColor = true;
            btn_Repuestos.Click += btn_Repuestos_Click;
            // 
            // btn_Autos
            // 
            btn_Autos.Dock = DockStyle.Top;
            btn_Autos.FlatAppearance.BorderSize = 0;
            btn_Autos.FlatStyle = FlatStyle.Flat;
            btn_Autos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Autos.ForeColor = Color.Gainsboro;
            btn_Autos.IconChar = FontAwesome.Sharp.IconChar.Car;
            btn_Autos.IconColor = Color.Gainsboro;
            btn_Autos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Autos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Autos.Location = new Point(0, 179);
            btn_Autos.Name = "btn_Autos";
            btn_Autos.Size = new Size(188, 52);
            btn_Autos.TabIndex = 2;
            btn_Autos.Text = "Autos";
            btn_Autos.TextAlign = ContentAlignment.MiddleLeft;
            btn_Autos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Autos.UseVisualStyleBackColor = true;
            btn_Autos.Click += btn_Autos_Click;
            // 
            // btn_Clientes
            // 
            btn_Clientes.Dock = DockStyle.Top;
            btn_Clientes.FlatAppearance.BorderSize = 0;
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clientes.ForeColor = Color.Gainsboro;
            btn_Clientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            btn_Clientes.IconColor = Color.Gainsboro;
            btn_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.Location = new Point(0, 127);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Size = new Size(188, 52);
            btn_Clientes.TabIndex = 1;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_Clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Clientes.UseVisualStyleBackColor = true;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // panelPictureBox
            // 
            panelPictureBox.Controls.Add(btn_Home);
            panelPictureBox.Dock = DockStyle.Top;
            panelPictureBox.Location = new Point(0, 0);
            panelPictureBox.Name = "panelPictureBox";
            panelPictureBox.Size = new Size(188, 127);
            panelPictureBox.TabIndex = 0;
            // 
            // btn_Home
            // 
            btn_Home.Image = Properties.Resources.imagen_2023_08_15_191040285_removebg_preview;
            btn_Home.Location = new Point(4, 3);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(181, 124);
            btn_Home.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Home.TabIndex = 0;
            btn_Home.TabStop = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // cLIENTESBindingSource
            // 
            cLIENTESBindingSource.DataSource = typeof(Domain.Entities.CLIENTES);
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(64, 0, 64);
            panelChildForm.Controls.Add(panel2);
            panelChildForm.Controls.Add(panel1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(188, 62);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1156, 667);
            panelChildForm.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(lbl_Fecha);
            panel2.Controls.Add(lbl_Hora);
            panel2.Location = new Point(330, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 100);
            panel2.TabIndex = 2;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha.ForeColor = Color.Gold;
            lbl_Fecha.Location = new Point(123, 60);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(78, 32);
            lbl_Fecha.TabIndex = 1;
            lbl_Fecha.Text = "label2";
            // 
            // lbl_Hora
            // 
            lbl_Hora.AutoSize = true;
            lbl_Hora.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Hora.ForeColor = Color.Gainsboro;
            lbl_Hora.Location = new Point(183, 10);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(120, 50);
            lbl_Hora.TabIndex = 0;
            lbl_Hora.Text = "label1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(330, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 391);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagen_2023_08_15_191040285_removebg_preview;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(50, 0, 50);
            panelTitleBar.Controls.Add(btn_Exit);
            panelTitleBar.Controls.Add(btn_Maximize);
            panelTitleBar.Controls.Add(btn_Minimize);
            panelTitleBar.Controls.Add(lbl_TitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(188, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1156, 62);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.IconChar = FontAwesome.Sharp.IconChar.X;
            btn_Exit.IconColor = Color.Gainsboro;
            btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Exit.IconSize = 16;
            btn_Exit.Location = new Point(1108, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(45, 24);
            btn_Exit.TabIndex = 6;
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Maximize
            // 
            btn_Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maximize.FlatAppearance.BorderSize = 0;
            btn_Maximize.FlatStyle = FlatStyle.Flat;
            btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btn_Maximize.IconColor = Color.Gainsboro;
            btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Maximize.IconSize = 16;
            btn_Maximize.Location = new Point(1066, 3);
            btn_Maximize.Name = "btn_Maximize";
            btn_Maximize.Size = new Size(45, 24);
            btn_Maximize.TabIndex = 5;
            btn_Maximize.UseVisualStyleBackColor = true;
            btn_Maximize.Click += btn_Maximize_Click;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btn_Minimize.IconColor = Color.Gainsboro;
            btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Minimize.IconSize = 16;
            btn_Minimize.Location = new Point(1024, 3);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(45, 24);
            btn_Minimize.TabIndex = 4;
            btn_Minimize.UseVisualStyleBackColor = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // lbl_TitleChildForm
            // 
            lbl_TitleChildForm.AutoSize = true;
            lbl_TitleChildForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TitleChildForm.ForeColor = Color.Gainsboro;
            lbl_TitleChildForm.Location = new Point(52, 21);
            lbl_TitleChildForm.Name = "lbl_TitleChildForm";
            lbl_TitleChildForm.Size = new Size(51, 20);
            lbl_TitleChildForm.TabIndex = 3;
            lbl_TitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(50, 0, 50);
            iconCurrentChildForm.ForeColor = Color.Gainsboro;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 39;
            iconCurrentChildForm.Location = new Point(6, 12);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 39);
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 729);
            Controls.Add(panelChildForm);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(900, 650);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Don Sergios Mechanic Services";
            Load += FrmMenu_Load;
            panelMenu.ResumeLayout(false);
            panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)cLIENTESBindingSource).EndInit();
            panelChildForm.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private BindingSource cLIENTESBindingSource;
        private Panel panelChildForm;
        private Panel panelPictureBox;
        private Panel panelTitleBar;
        private PictureBox btn_Home;
        private FontAwesome.Sharp.IconButton btn_Clientes;
        private FontAwesome.Sharp.IconButton btn_Autos;
        private FontAwesome.Sharp.IconButton btn_Repuestos;
        private FontAwesome.Sharp.IconButton btn_Dashboard;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lbl_TitleChildForm;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private Panel panel2;
        private Label lbl_Fecha;
        private Label lbl_Hora;
        private System.Windows.Forms.Timer horaFecha;
    }
}