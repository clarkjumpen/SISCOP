namespace Siscop
{
    partial class PickEncargado
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
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstEncargados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.grpLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.lstEncargados);
            this.grpLista.Location = new System.Drawing.Point(12, 12);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(184, 319);
            this.grpLista.TabIndex = 23;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista de Encargados";
            // 
            // lstEncargados
            // 
            this.lstEncargados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEncargados.FormattingEnabled = true;
            this.lstEncargados.HorizontalScrollbar = true;
            this.lstEncargados.Location = new System.Drawing.Point(3, 16);
            this.lstEncargados.Name = "lstEncargados";
            this.lstEncargados.Size = new System.Drawing.Size(178, 300);
            this.lstEncargados.TabIndex = 0;
            this.lstEncargados.SelectedIndexChanged += new System.EventHandler(this.lstEncargados_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnAgregarNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 79);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(6, 19);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(82, 23);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(96, 19);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(82, 23);
            this.btnAgregarNuevo.TabIndex = 24;
            this.btnAgregarNuevo.Text = "Nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            // 
            // PickEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLista);
            this.Name = "PickEncargado";
            this.Text = "PickEncargado";
            this.Load += new System.EventHandler(this.PickEncargado_Load);
            this.grpLista.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListBox lstEncargados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}