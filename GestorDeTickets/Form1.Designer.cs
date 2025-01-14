namespace GestorDeTickets
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.resumenTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.inputTicketID = new System.Windows.Forms.TextBox();
            this.inputNuevoUsuarioID = new System.Windows.Forms.TextBox();
            this.BotonModificarAsignacion = new System.Windows.Forms.Button();
            this.BotonImportar = new System.Windows.Forms.Button();
            this.BotonExportar = new System.Windows.Forms.Button();
            this.BotonMostrarResumen = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grupoAcciones = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputDestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenTicketsDataGridView)).BeginInit();
            this.grupoAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaTicketsDataGridView
            // 
            this.tablaTicketsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaTicketsDataGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.tablaTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTicketsDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.tablaTicketsDataGridView.Location = new System.Drawing.Point(30, 50);
            this.tablaTicketsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tablaTicketsDataGridView.Name = "tablaTicketsDataGridView";
            this.tablaTicketsDataGridView.Size = new System.Drawing.Size(390, 219);
            this.tablaTicketsDataGridView.TabIndex = 0;
            // 
            // resumenTicketsDataGridView
            // 
            this.resumenTicketsDataGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.resumenTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resumenTicketsDataGridView.Location = new System.Drawing.Point(613, 50);
            this.resumenTicketsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.resumenTicketsDataGridView.Name = "resumenTicketsDataGridView";
            this.resumenTicketsDataGridView.Size = new System.Drawing.Size(392, 219);
            this.resumenTicketsDataGridView.TabIndex = 1;
            // 
            // inputTicketID
            // 
            this.inputTicketID.Location = new System.Drawing.Point(135, 69);
            this.inputTicketID.Margin = new System.Windows.Forms.Padding(4);
            this.inputTicketID.Name = "inputTicketID";
            this.inputTicketID.Size = new System.Drawing.Size(132, 26);
            this.inputTicketID.TabIndex = 2;
            // 
            // inputNuevoUsuarioID
            // 
            this.inputNuevoUsuarioID.Location = new System.Drawing.Point(135, 35);
            this.inputNuevoUsuarioID.Margin = new System.Windows.Forms.Padding(4);
            this.inputNuevoUsuarioID.Name = "inputNuevoUsuarioID";
            this.inputNuevoUsuarioID.Size = new System.Drawing.Size(169, 26);
            this.inputNuevoUsuarioID.TabIndex = 3;
            // 
            // BotonModificarAsignacion
            // 
            this.BotonModificarAsignacion.Location = new System.Drawing.Point(135, 40);
            this.BotonModificarAsignacion.Margin = new System.Windows.Forms.Padding(4);
            this.BotonModificarAsignacion.Name = "BotonModificarAsignacion";
            this.BotonModificarAsignacion.Size = new System.Drawing.Size(100, 30);
            this.BotonModificarAsignacion.TabIndex = 4;
            this.BotonModificarAsignacion.Text = "ModificarAsig.";
            this.BotonModificarAsignacion.UseVisualStyleBackColor = true;
            this.BotonModificarAsignacion.Click += new System.EventHandler(this.BotonModificarAsignacion_Click_1);
            // 
            // BotonImportar
            // 
            this.BotonImportar.Location = new System.Drawing.Point(243, 40);
            this.BotonImportar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonImportar.Name = "BotonImportar";
            this.BotonImportar.Size = new System.Drawing.Size(100, 30);
            this.BotonImportar.TabIndex = 5;
            this.BotonImportar.Text = "Importar";
            this.BotonImportar.UseVisualStyleBackColor = true;
            this.BotonImportar.Click += new System.EventHandler(this.BotonImportar_Click_1);
            // 
            // BotonExportar
            // 
            this.BotonExportar.Location = new System.Drawing.Point(351, 40);
            this.BotonExportar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonExportar.Name = "BotonExportar";
            this.BotonExportar.Size = new System.Drawing.Size(100, 30);
            this.BotonExportar.TabIndex = 6;
            this.BotonExportar.Text = "Exportar";
            this.BotonExportar.UseVisualStyleBackColor = true;
            this.BotonExportar.Click += new System.EventHandler(this.BotonExportar_Click_1);
            // 
            // BotonMostrarResumen
            // 
            this.BotonMostrarResumen.Location = new System.Drawing.Point(459, 40);
            this.BotonMostrarResumen.Margin = new System.Windows.Forms.Padding(4);
            this.BotonMostrarResumen.Name = "BotonMostrarResumen";
            this.BotonMostrarResumen.Size = new System.Drawing.Size(100, 30);
            this.BotonMostrarResumen.TabIndex = 7;
            this.BotonMostrarResumen.Text = "Resumen";
            this.BotonMostrarResumen.UseVisualStyleBackColor = true;
            this.BotonMostrarResumen.Click += new System.EventHandler(this.BotonMostrarResumen_Click_1);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(27, 40);
            this.BotonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(100, 30);
            this.BotonGuardar.TabIndex = 8;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // grupoAcciones
            // 
            this.grupoAcciones.Controls.Add(this.BotonModificarAsignacion);
            this.grupoAcciones.Controls.Add(this.BotonGuardar);
            this.grupoAcciones.Controls.Add(this.BotonImportar);
            this.grupoAcciones.Controls.Add(this.BotonMostrarResumen);
            this.grupoAcciones.Controls.Add(this.BotonExportar);
            this.grupoAcciones.Location = new System.Drawing.Point(262, 501);
            this.grupoAcciones.Name = "grupoAcciones";
            this.grupoAcciones.Size = new System.Drawing.Size(599, 154);
            this.grupoAcciones.TabIndex = 9;
            this.grupoAcciones.TabStop = false;
            this.grupoAcciones.Text = "Gestión de Tickets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputDestinatario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputTicketID);
            this.groupBox1.Controls.Add(this.inputNuevoUsuarioID);
            this.groupBox1.Location = new System.Drawing.Point(262, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar datos";
            // 
            // InputDestinatario
            // 
            this.InputDestinatario.Location = new System.Drawing.Point(135, 108);
            this.InputDestinatario.Margin = new System.Windows.Forms.Padding(4);
            this.InputDestinatario.Name = "InputDestinatario";
            this.InputDestinatario.Size = new System.Drawing.Size(132, 26);
            this.InputDestinatario.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Destinatario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Incidencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(609, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resumen:";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1045, 820);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoAcciones);
            this.Controls.Add(this.resumenTicketsDataGridView);
            this.Controls.Add(this.tablaTicketsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenTicketsDataGridView)).EndInit();
            this.grupoAcciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaTicketsDataGridView;
        private System.Windows.Forms.DataGridView resumenTicketsDataGridView;
        private System.Windows.Forms.TextBox inputTicketID;
        private System.Windows.Forms.TextBox inputNuevoUsuarioID;
        private System.Windows.Forms.Button BotonModificarAsignacion;
        private System.Windows.Forms.Button BotonImportar;
        private System.Windows.Forms.Button BotonExportar;
        private System.Windows.Forms.Button BotonMostrarResumen;
        private System.Windows.Forms.Button BotonGuardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grupoAcciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputDestinatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

