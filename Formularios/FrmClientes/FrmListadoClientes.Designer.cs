namespace FrmDonSergios
{
    partial class FrmListadoClientes
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
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dataGridPasajeros = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnFiltrarPasajeros = new System.Windows.Forms.Button();
            lblMatriculaCrucero = new System.Windows.Forms.Label();
            txtMatriculaCrucero = new System.Windows.Forms.TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridPasajeros);
            panel2.Controls.Add(btnFiltrarPasajeros);
            panel2.Controls.Add(lblMatriculaCrucero);
            panel2.Controls.Add(txtMatriculaCrucero);
            panel2.Location = new System.Drawing.Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1077, 537);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(5, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "LISTADO DE CLIENTES";
            // 
            // dataGridPasajeros
            // 
            dataGridPasajeros.AllowUserToOrderColumns = true;
            dataGridPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridPasajeros.Location = new System.Drawing.Point(176, 0);
            dataGridPasajeros.Name = "dataGridPasajeros";
            dataGridPasajeros.ReadOnly = true;
            dataGridPasajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridPasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridPasajeros.RowTemplate.Height = 25;
            dataGridPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridPasajeros.Size = new System.Drawing.Size(896, 534);
            dataGridPasajeros.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "DNI";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Sexo";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Pasaporte";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Nacionalidad";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "LLeva Bolso";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 75;
            // 
            // Column9
            // 
            Column9.HeaderText = "Peso Valijas";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "Es Premium";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 75;
            // 
            // btnFiltrarPasajeros
            // 
            btnFiltrarPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnFiltrarPasajeros.BackColor = System.Drawing.Color.FromArgb(214, 164, 46);
            btnFiltrarPasajeros.FlatAppearance.BorderSize = 0;
            btnFiltrarPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFiltrarPasajeros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFiltrarPasajeros.Location = new System.Drawing.Point(37, 619);
            btnFiltrarPasajeros.Name = "btnFiltrarPasajeros";
            btnFiltrarPasajeros.Size = new System.Drawing.Size(100, 46);
            btnFiltrarPasajeros.TabIndex = 3;
            btnFiltrarPasajeros.Text = "Filtrar Pasajeros";
            btnFiltrarPasajeros.UseVisualStyleBackColor = false;
            // 
            // lblMatriculaCrucero
            // 
            lblMatriculaCrucero.AutoSize = true;
            lblMatriculaCrucero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMatriculaCrucero.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblMatriculaCrucero.Location = new System.Drawing.Point(15, 85);
            lblMatriculaCrucero.Name = "lblMatriculaCrucero";
            lblMatriculaCrucero.Size = new System.Drawing.Size(132, 17);
            lblMatriculaCrucero.TabIndex = 2;
            lblMatriculaCrucero.Text = "Buscar por PATENTE";
            // 
            // txtMatriculaCrucero
            // 
            txtMatriculaCrucero.Location = new System.Drawing.Point(37, 105);
            txtMatriculaCrucero.Name = "txtMatriculaCrucero";
            txtMatriculaCrucero.Size = new System.Drawing.Size(100, 23);
            txtMatriculaCrucero.TabIndex = 0;
            // 
            // FrmListadoClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
            ClientSize = new System.Drawing.Size(1101, 561);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmListadoClientes";
            Text = "FrmListadoClientes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnFiltrarPasajeros;
        private System.Windows.Forms.Label lblMatriculaCrucero;
        private System.Windows.Forms.TextBox txtMatriculaCrucero;
    }
}