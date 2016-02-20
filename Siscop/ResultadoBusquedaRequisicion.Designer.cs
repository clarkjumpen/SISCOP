namespace Siscop
{
    partial class ResultadoBusquedaRequisicion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.dgvRequisicion = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresadaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpControles.SuspendLayout();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnCancelar);
            this.grpControles.Controls.Add(this.btnSeleccionar);
            this.grpControles.Location = new System.Drawing.Point(536, 117);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(206, 55);
            this.grpControles.TabIndex = 22;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(114, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(16, 19);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(76, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.dgvRequisicion);
            this.grpResultado.Location = new System.Drawing.Point(12, 12);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(736, 99);
            this.grpResultado.TabIndex = 21;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = " ";
            // 
            // dgvRequisicion
            // 
            this.dgvRequisicion.AllowUserToAddRows = false;
            this.dgvRequisicion.AllowUserToDeleteRows = false;
            this.dgvRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Fecha,
            this.Tipo,
            this.Descripcion,
            this.Estado,
            this.Prioridad,
            this.IngresadaPor});
            this.dgvRequisicion.Location = new System.Drawing.Point(6, 19);
            this.dgvRequisicion.Name = "dgvRequisicion";
            this.dgvRequisicion.ReadOnly = true;
            this.dgvRequisicion.Size = new System.Drawing.Size(724, 74);
            this.dgvRequisicion.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // IngresadaPor
            // 
            this.IngresadaPor.HeaderText = "Ingresada Por";
            this.IngresadaPor.Name = "IngresadaPor";
            this.IngresadaPor.ReadOnly = true;
            // 
            // ResultadoBusquedaRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 176);
            this.ControlBox = false;
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResultadoBusquedaRequisicion";
            this.Text = "Resultado Busqueda Requisicion";
            this.Load += new System.EventHandler(this.ResultadoBusquedaRequisicion_Load);
            this.grpControles.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.DataGridView dgvRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresadaPor;
    }
}