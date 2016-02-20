namespace Siscop
{
    partial class AddMano
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
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpInformacion.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.txtHoras);
            this.grpInformacion.Controls.Add(this.txtTarea);
            this.grpInformacion.Controls.Add(this.lblHoras);
            this.grpInformacion.Controls.Add(this.lblNombreTarea);
            this.grpInformacion.Location = new System.Drawing.Point(12, 12);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(183, 122);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(9, 88);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(168, 20);
            this.txtHoras.TabIndex = 3;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(9, 38);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(168, 20);
            this.txtTarea.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(6, 72);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Horas";
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(6, 22);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(75, 13);
            this.lblNombreTarea.TabIndex = 0;
            this.lblNombreTarea.Text = "Nombre Tarea";
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.btnCancelar);
            this.grpControles.Controls.Add(this.btnAgregar);
            this.grpControles.Location = new System.Drawing.Point(12, 140);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(183, 52);
            this.grpControles.TabIndex = 1;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(102, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AddMano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 200);
            this.ControlBox = false;
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grpInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMano";
            this.Text = "AddMano";
            this.Load += new System.EventHandler(this.AddMano_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}