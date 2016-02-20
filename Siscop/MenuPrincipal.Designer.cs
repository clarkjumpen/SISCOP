namespace Siscop
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioYBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ingresarActivoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.descontarExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresoDeExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCatalogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.administrarCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarOrdenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.verOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoPresupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAPartirDeUnaOrednToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.verPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlDeUsuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioYBodegaToolStripMenuItem,
            this.ordenesDeTrabajoToolStripMenuItem,
            this.presupuestoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem});
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de usuarios";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // administrarClientesToolStripMenuItem
            // 
            this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.administrarClientesToolStripMenuItem.Text = "Administrar Clientes";
            this.administrarClientesToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesToolStripMenuItem_Click);
            // 
            // inventarioYBodegaToolStripMenuItem
            // 
            this.inventarioYBodegaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verBodegaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ingresarToolStripMenuItem,
            this.toolStripMenuItem3,
            this.descontarExistenciasToolStripMenuItem,
            this.toolStripMenuItem8,
            this.catalogoToolStripMenuItem});
            this.inventarioYBodegaToolStripMenuItem.Name = "inventarioYBodegaToolStripMenuItem";
            this.inventarioYBodegaToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.inventarioYBodegaToolStripMenuItem.Text = "Inventario y bodega";
            // 
            // verBodegaToolStripMenuItem
            // 
            this.verBodegaToolStripMenuItem.Name = "verBodegaToolStripMenuItem";
            this.verBodegaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verBodegaToolStripMenuItem.Text = "Ver Bodega";
            this.verBodegaToolStripMenuItem.Click += new System.EventHandler(this.verBodegaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarExistenciaToolStripMenuItem,
            this.toolStripMenuItem4,
            this.ingresarActivoFijoToolStripMenuItem});
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ingresarToolStripMenuItem.Text = "Ingreso";
            // 
            // ingresarExistenciaToolStripMenuItem
            // 
            this.ingresarExistenciaToolStripMenuItem.Name = "ingresarExistenciaToolStripMenuItem";
            this.ingresarExistenciaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ingresarExistenciaToolStripMenuItem.Text = "Ingresar Existencia";
            this.ingresarExistenciaToolStripMenuItem.Click += new System.EventHandler(this.ingresarExistenciaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(172, 6);
            // 
            // ingresarActivoFijoToolStripMenuItem
            // 
            this.ingresarActivoFijoToolStripMenuItem.Name = "ingresarActivoFijoToolStripMenuItem";
            this.ingresarActivoFijoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ingresarActivoFijoToolStripMenuItem.Text = "Ingresar Activo Fijo";
            this.ingresarActivoFijoToolStripMenuItem.Click += new System.EventHandler(this.ingresarActivoFijoToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 6);
            // 
            // descontarExistenciasToolStripMenuItem
            // 
            this.descontarExistenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egresoDeExistenciasToolStripMenuItem});
            this.descontarExistenciasToolStripMenuItem.Name = "descontarExistenciasToolStripMenuItem";
            this.descontarExistenciasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.descontarExistenciasToolStripMenuItem.Text = "Egreso";
            // 
            // egresoDeExistenciasToolStripMenuItem
            // 
            this.egresoDeExistenciasToolStripMenuItem.Name = "egresoDeExistenciasToolStripMenuItem";
            this.egresoDeExistenciasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.egresoDeExistenciasToolStripMenuItem.Text = "Egreso de Existencias";
            this.egresoDeExistenciasToolStripMenuItem.Click += new System.EventHandler(this.egresoDeExistenciasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(130, 6);
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.administrarCatalogoToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // verCatalogoToolStripMenuItem1
            // 
            this.verCatalogoToolStripMenuItem1.Name = "verCatalogoToolStripMenuItem1";
            this.verCatalogoToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.verCatalogoToolStripMenuItem1.Text = "Ver Catalogo ";
            this.verCatalogoToolStripMenuItem1.Click += new System.EventHandler(this.verCatalogoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(184, 6);
            // 
            // administrarCatalogoToolStripMenuItem
            // 
            this.administrarCatalogoToolStripMenuItem.Name = "administrarCatalogoToolStripMenuItem";
            this.administrarCatalogoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.administrarCatalogoToolStripMenuItem.Text = "Administrar Catalogo";
            this.administrarCatalogoToolStripMenuItem.Click += new System.EventHandler(this.administrarCatalogoToolStripMenuItem_Click);
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarOrdenDeTrabajoToolStripMenuItem,
            this.toolStripMenuItem5,
            this.verOrdenesToolStripMenuItem});
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de trabajo";
            // 
            // ingresarOrdenDeTrabajoToolStripMenuItem
            // 
            this.ingresarOrdenDeTrabajoToolStripMenuItem.Name = "ingresarOrdenDeTrabajoToolStripMenuItem";
            this.ingresarOrdenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarOrdenDeTrabajoToolStripMenuItem.Text = "Menu Ordenes";
            this.ingresarOrdenDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ingresarOrdenDeTrabajoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // verOrdenesToolStripMenuItem
            // 
            this.verOrdenesToolStripMenuItem.Name = "verOrdenesToolStripMenuItem";
            this.verOrdenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verOrdenesToolStripMenuItem.Text = "Ver Lista de Ordenes";
            this.verOrdenesToolStripMenuItem.Click += new System.EventHandler(this.verOrdenesToolStripMenuItem_Click);
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoPresupuestoToolStripMenuItem,
            this.nuevoAPartirDeUnaOrednToolStripMenuItem,
            this.toolStripMenuItem7,
            this.verPresupuestosToolStripMenuItem});
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.presupuestoToolStripMenuItem.Text = "Presupuestos";
            // 
            // ingresarNuevoPresupuestoToolStripMenuItem
            // 
            this.ingresarNuevoPresupuestoToolStripMenuItem.Name = "ingresarNuevoPresupuestoToolStripMenuItem";
            this.ingresarNuevoPresupuestoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ingresarNuevoPresupuestoToolStripMenuItem.Text = "Nuevo...";
            // 
            // nuevoAPartirDeUnaOrednToolStripMenuItem
            // 
            this.nuevoAPartirDeUnaOrednToolStripMenuItem.Name = "nuevoAPartirDeUnaOrednToolStripMenuItem";
            this.nuevoAPartirDeUnaOrednToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.nuevoAPartirDeUnaOrednToolStripMenuItem.Text = "Nuevo a partir de una Orden";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(221, 6);
            // 
            // verPresupuestosToolStripMenuItem
            // 
            this.verPresupuestosToolStripMenuItem.Name = "verPresupuestosToolStripMenuItem";
            this.verPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.verPresupuestosToolStripMenuItem.Text = "Ver Presupuestos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblConexion,
            this.lblStatusUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "ESTADO:";
            // 
            // lblConexion
            // 
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(99, 17);
            this.lblConexion.Text = "NO CONECTADO";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1159, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton1.Text = "Estado de ordenes";
            this.toolStripButton1.ToolTipText = "Estado de Ordenes";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 664);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Siscop V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioYBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripMenuItem verBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem ingresarOrdenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem verOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarActivoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descontarExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresoDeExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCatalogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoPresupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAPartirDeUnaOrednToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem verPresupuestosToolStripMenuItem;
    }
}

