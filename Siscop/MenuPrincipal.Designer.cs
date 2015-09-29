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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioYBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlDeUsuariosToolStripMenuItem,
            this.inventarioYBodegaToolStripMenuItem,
            this.requisicionToolStripMenuItem,
            this.presupuestoToolStripMenuItem,
            this.ordenesDeTrabajoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
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
            // 
            // inventarioYBodegaToolStripMenuItem
            // 
            this.inventarioYBodegaToolStripMenuItem.Name = "inventarioYBodegaToolStripMenuItem";
            this.inventarioYBodegaToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.inventarioYBodegaToolStripMenuItem.Text = "Inventario y bodega";
            // 
            // requisicionToolStripMenuItem
            // 
            this.requisicionToolStripMenuItem.Name = "requisicionToolStripMenuItem";
            this.requisicionToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.requisicionToolStripMenuItem.Text = "Requisiciones";
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.presupuestoToolStripMenuItem.Text = "Presupuestos";
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de trabajo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblConexion,
            this.lblStatusUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel2.Text = "ESTADO:";
            // 
            // lblConexion
            // 
            this.lblConexion.ForeColor = System.Drawing.Color.Red;
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(100, 17);
            this.lblConexion.Text = "NO CONECTADO";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Siscop V1.0";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem requisicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
    }
}

