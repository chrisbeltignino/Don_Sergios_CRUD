namespace DonSergios.Presentation.Presentation
{
    partial class FrmAutos
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
            dgvListaAutos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaAutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvListaAutos);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 527);
            panel1.TabIndex = 3;
            // 
            // dgvListaAutos
            // 
            dgvListaAutos.AllowUserToAddRows = false;
            dgvListaAutos.AllowUserToDeleteRows = false;
            dgvListaAutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaAutos.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvListaAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaAutos.Dock = DockStyle.Fill;
            dgvListaAutos.Location = new Point(0, 0);
            dgvListaAutos.Name = "dgvListaAutos";
            dgvListaAutos.ReadOnly = true;
            dgvListaAutos.RowTemplate.Height = 25;
            dgvListaAutos.Size = new Size(1130, 527);
            dgvListaAutos.TabIndex = 0;
            // 
            // FrmAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1156, 667);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAutos";
            Text = "Autos";
            Load += FrmAutos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaAutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvListaAutos;
    }
}