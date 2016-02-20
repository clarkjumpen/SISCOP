namespace Siscop
{
    partial class AdmCatalogo
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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoEquip = new System.Windows.Forms.ComboBox();
            this.txtCodPrelude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCodMc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPrelude = new System.Windows.Forms.Button();
            this.txtBuscarCodPrelude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarMC = new System.Windows.Forms.Button();
            this.txtBuscarCodMc = new System.Windows.Forms.TextBox();
            this.lblBuscarRut = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpInformacion.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.label6);
            this.grpInformacion.Controls.Add(this.cmbTipoEquip);
            this.grpInformacion.Controls.Add(this.txtCodPrelude);
            this.grpInformacion.Controls.Add(this.label3);
            this.grpInformacion.Controls.Add(this.label4);
            this.grpInformacion.Controls.Add(this.cmbProveedor);
            this.grpInformacion.Controls.Add(this.txtCodMc);
            this.grpInformacion.Controls.Add(this.label1);
            this.grpInformacion.Controls.Add(this.cmbCuenta);
            this.grpInformacion.Controls.Add(this.lblRut);
            this.grpInformacion.Controls.Add(this.txtNombre);
            this.grpInformacion.Controls.Add(this.lblNombre);
            this.grpInformacion.Location = new System.Drawing.Point(12, 118);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(396, 184);
            this.grpInformacion.TabIndex = 16;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Grupo / Familia";
            // 
            // cmbTipoEquip
            // 
            this.cmbTipoEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquip.FormattingEnabled = true;
            this.cmbTipoEquip.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbTipoEquip.Location = new System.Drawing.Point(109, 151);
            this.cmbTipoEquip.Name = "cmbTipoEquip";
            this.cmbTipoEquip.Size = new System.Drawing.Size(218, 21);
            this.cmbTipoEquip.TabIndex = 22;
            // 
            // txtCodPrelude
            // 
            this.txtCodPrelude.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPrelude.Location = new System.Drawing.Point(109, 45);
            this.txtCodPrelude.Name = "txtCodPrelude";
            this.txtCodPrelude.Size = new System.Drawing.Size(150, 20);
            this.txtCodPrelude.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Codigo McElroy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo Prelude";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbProveedor.Location = new System.Drawing.Point(109, 97);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(218, 21);
            this.cmbProveedor.TabIndex = 10;
            // 
            // txtCodMc
            // 
            this.txtCodMc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodMc.Location = new System.Drawing.Point(109, 19);
            this.txtCodMc.Name = "txtCodMc";
            this.txtCodMc.Size = new System.Drawing.Size(150, 20);
            this.txtCodMc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nº Cuenta";
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbCuenta.Location = new System.Drawing.Point(109, 124);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(218, 21);
            this.cmbCuenta.TabIndex = 0;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(6, 100);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(56, 13);
            this.lblRut.TabIndex = 5;
            this.lblRut.Text = "Proveedor";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(109, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.txtBuscarNombre);
            this.grpBusqueda.Controls.Add(this.label5);
            this.grpBusqueda.Controls.Add(this.btnBuscarPrelude);
            this.grpBusqueda.Controls.Add(this.txtBuscarCodPrelude);
            this.grpBusqueda.Controls.Add(this.label2);
            this.grpBusqueda.Controls.Add(this.btnBuscarMC);
            this.grpBusqueda.Controls.Add(this.txtBuscarCodMc);
            this.grpBusqueda.Controls.Add(this.lblBuscarRut);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(396, 100);
            this.grpBusqueda.TabIndex = 19;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarNombre.Location = new System.Drawing.Point(109, 19);
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
            this.txtBuscarCodPrelude.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarCodPrelude.Location = new System.Drawing.Point(109, 71);
            this.txtBuscarCodPrelude.Name = "txtBuscarCodPrelude";
            this.txtBuscarCodPrelude.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarCodPrelude.TabIndex = 8;
            this.txtBuscarCodPrelude.TextChanged += new System.EventHandler(this.txtBuscarCodPrelude_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo Prelude";
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
            this.txtBuscarCodMc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarCodMc.Location = new System.Drawing.Point(109, 45);
            this.txtBuscarCodMc.Name = "txtBuscarCodMc";
            this.txtBuscarCodMc.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarCodMc.TabIndex = 3;
            this.txtBuscarCodMc.TextChanged += new System.EventHandler(this.txtBuscarCodMc_TextChanged);
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
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnLimpiar);
            this.grpControles.Controls.Add(this.btnSalir);
            this.grpControles.Controls.Add(this.btnEliminar);
            this.grpControles.Controls.Add(this.btnModificar);
            this.grpControles.Controls.Add(this.btnAgregar);
            this.grpControles.Location = new System.Drawing.Point(12, 308);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(398, 79);
            this.grpControles.TabIndex = 20;
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
            // AdmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 392);
            this.ControlBox = false;
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdmCatalogo";
            this.Text = "Administrar Catalogo";
            this.Load += new System.EventHandler(this.AdmExistencia_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtCodPrelude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodMc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Button btnBuscarMC;
        private System.Windows.Forms.TextBox txtBuscarCodMc;
        private System.Windows.Forms.Label lblBuscarRut;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPrelude;
        private System.Windows.Forms.TextBox txtBuscarCodPrelude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoEquip;
    }
}