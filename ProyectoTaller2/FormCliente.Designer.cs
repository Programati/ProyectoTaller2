namespace ProyectoTaller2
{
    partial class FormCliente
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
            this.LDniCliente = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDniCliente
            // 
            this.LDniCliente.AutoSize = true;
            this.LDniCliente.Location = new System.Drawing.Point(203, 52);
            this.LDniCliente.Name = "LDniCliente";
            this.LDniCliente.Size = new System.Drawing.Size(129, 13);
            this.LDniCliente.TabIndex = 0;
            this.LDniCliente.Text = "Ingrese el DNI del cliente:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(338, 49);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDniCliente.TabIndex = 1;
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniCliente_KeyPress);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(338, 75);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(68, 22);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaDni,
            this.ColumnaNombreCliente,
            this.ColumnaTelCliente,
            this.ColumnaDireccion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnaDni
            // 
            this.ColumnaDni.HeaderText = "DNI";
            this.ColumnaDni.Name = "ColumnaDni";
            // 
            // ColumnaNombreCliente
            // 
            this.ColumnaNombreCliente.HeaderText = "Nombre";
            this.ColumnaNombreCliente.Name = "ColumnaNombreCliente";
            this.ColumnaNombreCliente.Width = 200;
            // 
            // ColumnaTelCliente
            // 
            this.ColumnaTelCliente.HeaderText = "Telefono";
            this.ColumnaTelCliente.Name = "ColumnaTelCliente";
            this.ColumnaTelCliente.Width = 150;
            // 
            // ColumnaDireccion
            // 
            this.ColumnaDireccion.HeaderText = "Direccion";
            this.ColumnaDireccion.Name = "ColumnaDireccion";
            this.ColumnaDireccion.Width = 280;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(338, 103);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(68, 23);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.LDniCliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDniCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDireccion;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}