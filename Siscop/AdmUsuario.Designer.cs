namespace Siscop
{
    partial class AdmUsuario
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
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarRut = new System.Windows.Forms.TextBox();
            this.lblBuscarRut = new System.Windows.Forms.Label();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.rdTrabajador = new System.Windows.Forms.RadioButton();
            this.rdOperador = new System.Windows.Forms.RadioButton();
            this.rdBodeguero = new System.Windows.Forms.RadioButton();
            this.rdFinanzas = new System.Windows.Forms.RadioButton();
            this.rdAdministrador = new System.Windows.Forms.RadioButton();
            this.chkBloqueado = new System.Windows.Forms.CheckBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.grpBusqueda.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            this.grpLista.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.txtBuscarRut);
            this.grpBusqueda.Controls.Add(this.lblBuscarRut);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(398, 62);
            this.grpBusqueda.TabIndex = 0;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarRut
            // 
            this.txtBuscarRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarRut.Location = new System.Drawing.Point(61, 26);
            this.txtBuscarRut.Name = "txtBuscarRut";
            this.txtBuscarRut.Size = new System.Drawing.Size(147, 20);
            this.txtBuscarRut.TabIndex = 3;
            // 
            // lblBuscarRut
            // 
            this.lblBuscarRut.AutoSize = true;
            this.lblBuscarRut.Location = new System.Drawing.Point(11, 29);
            this.lblBuscarRut.Name = "lblBuscarRut";
            this.lblBuscarRut.Size = new System.Drawing.Size(24, 13);
            this.lblBuscarRut.TabIndex = 0;
            this.lblBuscarRut.Text = "Rut";
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.txtApellido);
            this.grpInformacion.Controls.Add(this.lblApellido);
            this.grpInformacion.Controls.Add(this.txtNombre);
            this.grpInformacion.Controls.Add(this.lblNombre);
            this.grpInformacion.Controls.Add(this.txtRut);
            this.grpInformacion.Controls.Add(this.lblRut);
            this.grpInformacion.Location = new System.Drawing.Point(12, 80);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(220, 104);
            this.grpInformacion.TabIndex = 1;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(61, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(61, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtRut
            // 
            this.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRut.Location = new System.Drawing.Point(61, 19);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(147, 20);
            this.txtRut.TabIndex = 6;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(11, 22);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 5;
            this.lblRut.Text = "Rut";
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.rdTrabajador);
            this.grpPermisos.Controls.Add(this.rdOperador);
            this.grpPermisos.Controls.Add(this.rdBodeguero);
            this.grpPermisos.Controls.Add(this.rdFinanzas);
            this.grpPermisos.Controls.Add(this.rdAdministrador);
            this.grpPermisos.Location = new System.Drawing.Point(12, 190);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(106, 137);
            this.grpPermisos.TabIndex = 12;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Permisos";
            // 
            // rdTrabajador
            // 
            this.rdTrabajador.AutoSize = true;
            this.rdTrabajador.Location = new System.Drawing.Point(14, 110);
            this.rdTrabajador.Name = "rdTrabajador";
            this.rdTrabajador.Size = new System.Drawing.Size(76, 17);
            this.rdTrabajador.TabIndex = 23;
            this.rdTrabajador.TabStop = true;
            this.rdTrabajador.Text = "Trabajador";
            this.rdTrabajador.UseVisualStyleBackColor = true;
            // 
            // rdOperador
            // 
            this.rdOperador.AutoSize = true;
            this.rdOperador.Location = new System.Drawing.Point(14, 87);
            this.rdOperador.Name = "rdOperador";
            this.rdOperador.Size = new System.Drawing.Size(69, 17);
            this.rdOperador.TabIndex = 22;
            this.rdOperador.Text = "Operador";
            this.rdOperador.UseVisualStyleBackColor = true;
            // 
            // rdBodeguero
            // 
            this.rdBodeguero.AutoSize = true;
            this.rdBodeguero.Location = new System.Drawing.Point(14, 64);
            this.rdBodeguero.Name = "rdBodeguero";
            this.rdBodeguero.Size = new System.Drawing.Size(77, 17);
            this.rdBodeguero.TabIndex = 21;
            this.rdBodeguero.TabStop = true;
            this.rdBodeguero.Text = "Bodeguero";
            this.rdBodeguero.UseVisualStyleBackColor = true;
            // 
            // rdFinanzas
            // 
            this.rdFinanzas.AutoSize = true;
            this.rdFinanzas.Location = new System.Drawing.Point(14, 41);
            this.rdFinanzas.Name = "rdFinanzas";
            this.rdFinanzas.Size = new System.Drawing.Size(67, 17);
            this.rdFinanzas.TabIndex = 19;
            this.rdFinanzas.TabStop = true;
            this.rdFinanzas.Text = "Finanzas";
            this.rdFinanzas.UseVisualStyleBackColor = true;
            // 
            // rdAdministrador
            // 
            this.rdAdministrador.AutoSize = true;
            this.rdAdministrador.Location = new System.Drawing.Point(14, 18);
            this.rdAdministrador.Name = "rdAdministrador";
            this.rdAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rdAdministrador.TabIndex = 20;
            this.rdAdministrador.TabStop = true;
            this.rdAdministrador.Text = "Administrador";
            this.rdAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.Location = new System.Drawing.Point(15, 19);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Size = new System.Drawing.Size(77, 17);
            this.chkBloqueado.TabIndex = 11;
            this.chkBloqueado.Text = "Bloqueado";
            this.chkBloqueado.UseVisualStyleBackColor = true;
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.lstUsuarios);
            this.grpLista.Controls.Add(this.lblInfo);
            this.grpLista.Location = new System.Drawing.Point(238, 80);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(172, 332);
            this.grpLista.TabIndex = 12;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista de usuarios";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.HorizontalScrollbar = true;
            this.lstUsuarios.Location = new System.Drawing.Point(8, 19);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(158, 264);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.DoubleClick += new System.EventHandler(this.lstUsuarios_DoubleClick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(36, 295);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(91, 26);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "*Doble click\r\n  para seleccionar";
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnLimpiar);
            this.grpControles.Controls.Add(this.btnSalir);
            this.grpControles.Controls.Add(this.btnEliminar);
            this.grpControles.Controls.Add(this.btnModificar);
            this.grpControles.Controls.Add(this.btnAgregar);
            this.grpControles.Location = new System.Drawing.Point(12, 418);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(398, 79);
            this.grpControles.TabIndex = 13;
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
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.chkBloqueado);
            this.grpEstado.Location = new System.Drawing.Point(124, 190);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(108, 48);
            this.grpEstado.TabIndex = 17;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCambiarClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 79);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(61, 45);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(147, 23);
            this.btnCambiarClave.TabIndex = 10;
            this.btnCambiarClave.Text = "Cambiar Clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(61, 19);
            this.txtClave.MaxLength = 32;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(147, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(11, 22);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // AdmUsuario
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 507);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.grpBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdmUsuario";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.AdmUsuario_Load);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpLista.ResumeLayout(false);
            this.grpLista.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtBuscarRut;
        private System.Windows.Forms.Label lblBuscarRut;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.Windows.Forms.CheckBox chkBloqueado;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rdTrabajador;
        private System.Windows.Forms.RadioButton rdOperador;
        private System.Windows.Forms.RadioButton rdBodeguero;
        private System.Windows.Forms.RadioButton rdFinanzas;
        private System.Windows.Forms.RadioButton rdAdministrador;
        private System.Windows.Forms.Button btnCambiarClave;
    }
}