namespace Siscop
{
    partial class IngresarMuestra
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
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpExistencias = new System.Windows.Forms.GroupBox();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorClpIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorClpTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPrelude = new System.Windows.Forms.Button();
            this.txtBuscarCodPrelude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarMC = new System.Windows.Forms.Button();
            this.txtBuscarCodMc = new System.Windows.Forms.TextBox();
            this.lblBuscarRut = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpControles.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            this.grpExistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnLimpiar);
            this.grpControles.Controls.Add(this.btnSalir);
            this.grpControles.Controls.Add(this.btnAgregar);
            this.grpControles.Location = new System.Drawing.Point(469, 435);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(261, 79);
            this.grpControles.TabIndex = 14;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(133, 48);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(246, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.txtCantidad);
            this.grpInformacion.Controls.Add(this.label2);
            this.grpInformacion.Controls.Add(this.txtValorUnitario);
            this.grpInformacion.Controls.Add(this.lblNombre);
            this.grpInformacion.Location = new System.Drawing.Point(12, 435);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(266, 79);
            this.grpInformacion.TabIndex = 16;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(105, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor Clp Unitario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(105, 45);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(147, 20);
            this.txtValorUnitario.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Cantidad";
            // 
            // grpExistencias
            // 
            this.grpExistencias.Controls.Add(this.dgvExistencias);
            this.grpExistencias.Location = new System.Drawing.Point(12, 207);
            this.grpExistencias.Name = "grpExistencias";
            this.grpExistencias.Size = new System.Drawing.Size(718, 222);
            this.grpExistencias.TabIndex = 17;
            this.grpExistencias.TabStop = false;
            this.grpExistencias.Text = "Existencias";
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.AllowUserToAddRows = false;
            this.dgvExistencias.AllowUserToDeleteRows = false;
            this.dgvExistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaIngreso,
            this.Cantidad,
            this.ValorClpIngreso,
            this.ValorClpTotal,
            this.Bodega});
            this.dgvExistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExistencias.Location = new System.Drawing.Point(3, 16);
            this.dgvExistencias.MultiSelect = false;
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.RowHeadersVisible = false;
            this.dgvExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistencias.Size = new System.Drawing.Size(712, 203);
            this.dgvExistencias.TabIndex = 0;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // ValorClpIngreso
            // 
            this.ValorClpIngreso.HeaderText = "ValorClpIngreso";
            this.ValorClpIngreso.Name = "ValorClpIngreso";
            this.ValorClpIngreso.ReadOnly = true;
            // 
            // ValorClpTotal
            // 
            this.ValorClpTotal.HeaderText = "ValorClpTotal";
            this.ValorClpTotal.Name = "ValorClpTotal";
            this.ValorClpTotal.ReadOnly = true;
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.TipoEquipo,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducto.Location = new System.Drawing.Point(3, 16);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(712, 64);
            this.dgvProducto.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.HeaderText = "TipoEquipo";
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "NºCuenta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CodigoMcElroy";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "CodigoPrelude";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.txtBuscarNombre);
            this.grpBusqueda.Controls.Add(this.label5);
            this.grpBusqueda.Controls.Add(this.btnBuscarPrelude);
            this.grpBusqueda.Controls.Add(this.txtBuscarCodPrelude);
            this.grpBusqueda.Controls.Add(this.label6);
            this.grpBusqueda.Controls.Add(this.btnBuscarMC);
            this.grpBusqueda.Controls.Add(this.txtBuscarCodMc);
            this.grpBusqueda.Controls.Add(this.lblBuscarRut);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(396, 100);
            this.grpBusqueda.TabIndex = 20;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(105, 19);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarNombre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // btnBuscarPrelude
            // 
            this.btnBuscarPrelude.Location = new System.Drawing.Point(265, 69);
            this.btnBuscarPrelude.Name = "btnBuscarPrelude";
            this.btnBuscarPrelude.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarPrelude.TabIndex = 9;
            this.btnBuscarPrelude.Text = "Buscar";
            this.btnBuscarPrelude.UseVisualStyleBackColor = true;
            this.btnBuscarPrelude.Click += new System.EventHandler(this.btnBuscarPrelude_Click);
            // 
            // txtBuscarCodPrelude
            // 
            this.txtBuscarCodPrelude.Location = new System.Drawing.Point(105, 71);
            this.txtBuscarCodPrelude.Name = "txtBuscarCodPrelude";
            this.txtBuscarCodPrelude.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarCodPrelude.TabIndex = 8;
            this.txtBuscarCodPrelude.Enter += new System.EventHandler(this.txtBuscarCodPrelude_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Codigo Prelude";
            // 
            // btnBuscarMC
            // 
            this.btnBuscarMC.Location = new System.Drawing.Point(265, 43);
            this.btnBuscarMC.Name = "btnBuscarMC";
            this.btnBuscarMC.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarMC.TabIndex = 6;
            this.btnBuscarMC.Text = "Buscar";
            this.btnBuscarMC.UseVisualStyleBackColor = true;
            this.btnBuscarMC.Click += new System.EventHandler(this.btnBuscarMC_Click);
            // 
            // txtBuscarCodMc
            // 
            this.txtBuscarCodMc.Location = new System.Drawing.Point(105, 45);
            this.txtBuscarCodMc.Name = "txtBuscarCodMc";
            this.txtBuscarCodMc.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarCodMc.TabIndex = 3;
            this.txtBuscarCodMc.Enter += new System.EventHandler(this.txtBuscarCodMc_Enter);
            // 
            // lblBuscarRut
            // 
            this.lblBuscarRut.AutoSize = true;
            this.lblBuscarRut.Location = new System.Drawing.Point(6, 48);
            this.lblBuscarRut.Name = "lblBuscarRut";
            this.lblBuscarRut.Size = new System.Drawing.Size(81, 13);
            this.lblBuscarRut.TabIndex = 0;
            this.lblBuscarRut.Text = "Codigo McElroy";
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbBodega.Location = new System.Drawing.Point(6, 17);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(167, 21);
            this.cmbBodega.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBodega);
            this.groupBox2.Location = new System.Drawing.Point(284, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 79);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bodega";
            // 
            // IngresarMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 522);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpExistencias);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.grpControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngresarMuestra";
            this.Text = "IngresarExistencia";
            this.Load += new System.EventHandler(this.IngresarExistencia_Load);
            this.grpControles.ResumeLayout(false);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpExistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpExistencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarPrelude;
        private System.Windows.Forms.TextBox txtBuscarCodPrelude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarMC;
        private System.Windows.Forms.TextBox txtBuscarCodMc;
        private System.Windows.Forms.Label lblBuscarRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorClpIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorClpTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
    }
}