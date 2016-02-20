namespace Siscop
{
    partial class IngresarRequisicion
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dTFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblIngresadaPor = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtIngresadaPor = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscarNumero = new System.Windows.Forms.TextBox();
            this.lblBuscarNumero = new System.Windows.Forms.Label();
            this.btnBuscarNumero = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtNumero);
            this.grpInfo.Controls.Add(this.lblEstado);
            this.grpInfo.Controls.Add(this.cmbEstado);
            this.grpInfo.Controls.Add(this.dTFecha);
            this.grpInfo.Controls.Add(this.lblFecha);
            this.grpInfo.Controls.Add(this.lblNumero);
            this.grpInfo.Controls.Add(this.lblDescripcion);
            this.grpInfo.Controls.Add(this.txtDescripcion);
            this.grpInfo.Controls.Add(this.lblIngresadaPor);
            this.grpInfo.Controls.Add(this.lblPrioridad);
            this.grpInfo.Controls.Add(this.cmbPrioridad);
            this.grpInfo.Controls.Add(this.lblTipo);
            this.grpInfo.Controls.Add(this.txtIngresadaPor);
            this.grpInfo.Controls.Add(this.cmbTipo);
            this.grpInfo.Location = new System.Drawing.Point(12, 69);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(467, 327);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informacion";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(83, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(118, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 107);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbEstado.Location = new System.Drawing.Point(84, 107);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(118, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // dTFecha
            // 
            this.dTFecha.Location = new System.Drawing.Point(257, 19);
            this.dTFecha.Name = "dTFecha";
            this.dTFecha.Size = new System.Drawing.Size(198, 20);
            this.dTFecha.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(214, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Nº";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 138);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(84, 135);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(369, 178);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "";
            // 
            // lblIngresadaPor
            // 
            this.lblIngresadaPor.AutoSize = true;
            this.lblIngresadaPor.Location = new System.Drawing.Point(6, 48);
            this.lblIngresadaPor.Name = "lblIngresadaPor";
            this.lblIngresadaPor.Size = new System.Drawing.Size(72, 13);
            this.lblIngresadaPor.TabIndex = 3;
            this.lblIngresadaPor.Text = "Ingresada por";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(214, 111);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 2;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbPrioridad.Location = new System.Drawing.Point(268, 107);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(185, 21);
            this.cmbPrioridad.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // txtIngresadaPor
            // 
            this.txtIngresadaPor.Enabled = false;
            this.txtIngresadaPor.Location = new System.Drawing.Point(84, 45);
            this.txtIngresadaPor.Name = "txtIngresadaPor";
            this.txtIngresadaPor.Size = new System.Drawing.Size(118, 20);
            this.txtIngresadaPor.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbTipo.Location = new System.Drawing.Point(84, 77);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(369, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnLimpiar);
            this.grpControles.Controls.Add(this.btnSalir);
            this.grpControles.Controls.Add(this.btnEliminar);
            this.grpControles.Controls.Add(this.btnModificar);
            this.grpControles.Controls.Add(this.btnAgregar);
            this.grpControles.Location = new System.Drawing.Point(81, 402);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(398, 79);
            this.grpControles.TabIndex = 14;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(14, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(265, 48);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(265, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.txtBuscarNumero);
            this.grpBusqueda.Controls.Add(this.lblBuscarNumero);
            this.grpBusqueda.Controls.Add(this.btnBuscarNumero);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(347, 51);
            this.grpBusqueda.TabIndex = 21;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // txtBuscarNumero
            // 
            this.txtBuscarNumero.Location = new System.Drawing.Point(84, 19);
            this.txtBuscarNumero.Name = "txtBuscarNumero";
            this.txtBuscarNumero.Size = new System.Drawing.Size(117, 20);
            this.txtBuscarNumero.TabIndex = 11;
            // 
            // lblBuscarNumero
            // 
            this.lblBuscarNumero.AutoSize = true;
            this.lblBuscarNumero.Location = new System.Drawing.Point(6, 22);
            this.lblBuscarNumero.Name = "lblBuscarNumero";
            this.lblBuscarNumero.Size = new System.Drawing.Size(44, 13);
            this.lblBuscarNumero.TabIndex = 10;
            this.lblBuscarNumero.Text = "Numero";
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Location = new System.Drawing.Point(217, 17);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(119, 23);
            this.btnBuscarNumero.TabIndex = 6;
            this.btnBuscarNumero.Text = "Buscar";
            this.btnBuscarNumero.UseVisualStyleBackColor = true;
            this.btnBuscarNumero.Click += new System.EventHandler(this.btnBuscarNumero_Click);
            // 
            // IngresarRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 485);
            this.ControlBox = false;
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngresarRequisicion";
            this.Text = "IngresarRequisicion";
            this.Load += new System.EventHandler(this.IngresarRequisicion_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtIngresadaPor;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblIngresadaPor;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dTFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtBuscarNumero;
        private System.Windows.Forms.Label lblBuscarNumero;
        private System.Windows.Forms.Button btnBuscarNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtNumero;
    }
}