
namespace InfoPrestamos
{
    partial class HistorialPago
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPago));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgCuotas = new System.Windows.Forms.DataGridView();
            this.ColAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColIdCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPagoCompleto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColPrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrestamo = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCobroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFiador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFiadorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEsCancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 82);
            this.panel2.TabIndex = 1113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 56);
            this.label8.TabIndex = 0;
            this.label8.Text = "Historial de pagos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 82);
            this.panel1.TabIndex = 1120;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(182, 28);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(436, 30);
            this.txtCliente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(38, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clientes";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgCuotas
            // 
            this.dgCuotas.AllowUserToAddRows = false;
            this.dgCuotas.AllowUserToDeleteRows = false;
            this.dgCuotas.BackgroundColor = System.Drawing.Color.White;
            this.dgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAgregar,
            this.ColIdCuota,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ColCapital,
            this.ColSaldo,
            this.ColObservaciones,
            this.ColPagoCompleto,
            this.ColPrestamoId,
            this.ColPrestamo});
            this.dgCuotas.Location = new System.Drawing.Point(6, 502);
            this.dgCuotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgCuotas.Name = "dgCuotas";
            this.dgCuotas.ReadOnly = true;
            this.dgCuotas.RowHeadersVisible = false;
            this.dgCuotas.RowHeadersWidth = 62;
            this.dgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCuotas.Size = new System.Drawing.Size(671, 336);
            this.dgCuotas.TabIndex = 1127;
            // 
            // ColAgregar
            // 
            this.ColAgregar.HeaderText = "";
            this.ColAgregar.MinimumWidth = 8;
            this.ColAgregar.Name = "ColAgregar";
            this.ColAgregar.ReadOnly = true;
            this.ColAgregar.Text = "Ver historial";
            this.ColAgregar.UseColumnTextForButtonValue = true;
            this.ColAgregar.Width = 150;
            // 
            // ColIdCuota
            // 
            this.ColIdCuota.DataPropertyName = "Id";
            this.ColIdCuota.HeaderText = "Id";
            this.ColIdCuota.MinimumWidth = 8;
            this.ColIdCuota.Name = "ColIdCuota";
            this.ColIdCuota.ReadOnly = true;
            this.ColIdCuota.Visible = false;
            this.ColIdCuota.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cuota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cuotas";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Interes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Interes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ColCapital
            // 
            this.ColCapital.DataPropertyName = "Capital";
            this.ColCapital.HeaderText = "Capital";
            this.ColCapital.MinimumWidth = 8;
            this.ColCapital.Name = "ColCapital";
            this.ColCapital.ReadOnly = true;
            this.ColCapital.Width = 150;
            // 
            // ColSaldo
            // 
            this.ColSaldo.DataPropertyName = "Saldo";
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.MinimumWidth = 8;
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.ReadOnly = true;
            this.ColSaldo.Width = 150;
            // 
            // ColObservaciones
            // 
            this.ColObservaciones.DataPropertyName = "Observaciones";
            this.ColObservaciones.HeaderText = "Observaciones";
            this.ColObservaciones.MinimumWidth = 8;
            this.ColObservaciones.Name = "ColObservaciones";
            this.ColObservaciones.ReadOnly = true;
            this.ColObservaciones.Width = 150;
            // 
            // ColPagoCompleto
            // 
            this.ColPagoCompleto.DataPropertyName = "PagoCompleto";
            this.ColPagoCompleto.HeaderText = "PagoCompleto ";
            this.ColPagoCompleto.MinimumWidth = 8;
            this.ColPagoCompleto.Name = "ColPagoCompleto";
            this.ColPagoCompleto.ReadOnly = true;
            this.ColPagoCompleto.Width = 150;
            // 
            // ColPrestamoId
            // 
            this.ColPrestamoId.DataPropertyName = "PrestamoId";
            this.ColPrestamoId.HeaderText = "PrestamoId";
            this.ColPrestamoId.MinimumWidth = 8;
            this.ColPrestamoId.Name = "ColPrestamoId";
            this.ColPrestamoId.ReadOnly = true;
            this.ColPrestamoId.Visible = false;
            this.ColPrestamoId.Width = 150;
            // 
            // ColPrestamo
            // 
            this.ColPrestamo.DataPropertyName = "Prestamo";
            this.ColPrestamo.HeaderText = "Prestamo";
            this.ColPrestamo.MinimumWidth = 8;
            this.ColPrestamo.Name = "ColPrestamo";
            this.ColPrestamo.ReadOnly = true;
            this.ColPrestamo.Visible = false;
            this.ColPrestamo.Width = 150;
            // 
            // dgPrestamo
            // 
            this.dgPrestamo.AllowUserToAddRows = false;
            this.dgPrestamo.AllowUserToDeleteRows = false;
            this.dgPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dgPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColCodigo,
            this.ColFecha,
            this.ColMonto,
            this.ColTiempo,
            this.ColInteres,
            this.ColTipoCobro,
            this.ColCuotas,
            this.ColTipoCobroId,
            this.ColCliente,
            this.ColClienteId,
            this.ColFiador,
            this.ColFiadorId,
            this.ColEmpleado,
            this.ColEmpleadoId,
            this.ColObservacion,
            this.ColEsCancelado});
            this.dgPrestamo.Location = new System.Drawing.Point(8, 187);
            this.dgPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPrestamo.Name = "dgPrestamo";
            this.dgPrestamo.ReadOnly = true;
            this.dgPrestamo.RowHeadersVisible = false;
            this.dgPrestamo.RowHeadersWidth = 62;
            this.dgPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrestamo.Size = new System.Drawing.Size(669, 308);
            this.dgPrestamo.TabIndex = 1126;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 8;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 150;
            // 
            // ColCodigo
            // 
            this.ColCodigo.DataPropertyName = "Codigo";
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 8;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 150;
            // 
            // ColFecha
            // 
            this.ColFecha.DataPropertyName = "Fecha";
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.MinimumWidth = 8;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 150;
            // 
            // ColMonto
            // 
            this.ColMonto.DataPropertyName = "Monto";
            this.ColMonto.HeaderText = "Monto";
            this.ColMonto.MinimumWidth = 8;
            this.ColMonto.Name = "ColMonto";
            this.ColMonto.ReadOnly = true;
            this.ColMonto.Width = 150;
            // 
            // ColTiempo
            // 
            this.ColTiempo.DataPropertyName = "Tiempo";
            this.ColTiempo.HeaderText = "Tiempo";
            this.ColTiempo.MinimumWidth = 8;
            this.ColTiempo.Name = "ColTiempo";
            this.ColTiempo.ReadOnly = true;
            this.ColTiempo.Width = 150;
            // 
            // ColInteres
            // 
            this.ColInteres.DataPropertyName = "Interes";
            this.ColInteres.HeaderText = "Interes";
            this.ColInteres.MinimumWidth = 8;
            this.ColInteres.Name = "ColInteres";
            this.ColInteres.ReadOnly = true;
            this.ColInteres.Width = 150;
            // 
            // ColTipoCobro
            // 
            this.ColTipoCobro.DataPropertyName = "TipoCobro";
            this.ColTipoCobro.HeaderText = "Tipo cobro";
            this.ColTipoCobro.MinimumWidth = 8;
            this.ColTipoCobro.Name = "ColTipoCobro";
            this.ColTipoCobro.ReadOnly = true;
            this.ColTipoCobro.Width = 150;
            // 
            // ColCuotas
            // 
            this.ColCuotas.DataPropertyName = "Cuotas";
            this.ColCuotas.HeaderText = "Cuotas";
            this.ColCuotas.MinimumWidth = 8;
            this.ColCuotas.Name = "ColCuotas";
            this.ColCuotas.ReadOnly = true;
            this.ColCuotas.Width = 150;
            // 
            // ColTipoCobroId
            // 
            this.ColTipoCobroId.DataPropertyName = "TipoCobroId";
            this.ColTipoCobroId.HeaderText = "TipoCobroId";
            this.ColTipoCobroId.MinimumWidth = 8;
            this.ColTipoCobroId.Name = "ColTipoCobroId";
            this.ColTipoCobroId.ReadOnly = true;
            this.ColTipoCobroId.Visible = false;
            this.ColTipoCobroId.Width = 150;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "Cliente";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 8;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 150;
            // 
            // ColClienteId
            // 
            this.ColClienteId.DataPropertyName = "ClienteId";
            this.ColClienteId.HeaderText = "ClienteId";
            this.ColClienteId.MinimumWidth = 8;
            this.ColClienteId.Name = "ColClienteId";
            this.ColClienteId.ReadOnly = true;
            this.ColClienteId.Visible = false;
            this.ColClienteId.Width = 150;
            // 
            // ColFiador
            // 
            this.ColFiador.DataPropertyName = "Fiador";
            this.ColFiador.HeaderText = "Fiador";
            this.ColFiador.MinimumWidth = 8;
            this.ColFiador.Name = "ColFiador";
            this.ColFiador.ReadOnly = true;
            this.ColFiador.Width = 150;
            // 
            // ColFiadorId
            // 
            this.ColFiadorId.DataPropertyName = "FiadorId";
            this.ColFiadorId.HeaderText = "FiadorId";
            this.ColFiadorId.MinimumWidth = 8;
            this.ColFiadorId.Name = "ColFiadorId";
            this.ColFiadorId.ReadOnly = true;
            this.ColFiadorId.Visible = false;
            this.ColFiadorId.Width = 150;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.DataPropertyName = "Empleado";
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 8;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 150;
            // 
            // ColEmpleadoId
            // 
            this.ColEmpleadoId.DataPropertyName = "EmpleadoId";
            this.ColEmpleadoId.HeaderText = "EmpleadoId";
            this.ColEmpleadoId.MinimumWidth = 8;
            this.ColEmpleadoId.Name = "ColEmpleadoId";
            this.ColEmpleadoId.ReadOnly = true;
            this.ColEmpleadoId.Visible = false;
            this.ColEmpleadoId.Width = 150;
            // 
            // ColObservacion
            // 
            this.ColObservacion.DataPropertyName = "Observacion";
            this.ColObservacion.HeaderText = "Observacion";
            this.ColObservacion.MinimumWidth = 8;
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.ReadOnly = true;
            this.ColObservacion.Width = 150;
            // 
            // ColEsCancelado
            // 
            this.ColEsCancelado.DataPropertyName = "EsCancelado";
            this.ColEsCancelado.HeaderText = "Cancelado";
            this.ColEsCancelado.MinimumWidth = 8;
            this.ColEsCancelado.Name = "ColEsCancelado";
            this.ColEsCancelado.ReadOnly = true;
            this.ColEsCancelado.Width = 150;
            // 
            // HistorialPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.dgCuotas);
            this.Controls.Add(this.dgPrestamo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HistorialPago";
            this.Size = new System.Drawing.Size(688, 849);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgCuotas;
        private System.Windows.Forms.DataGridViewButtonColumn ColAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObservaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPagoCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrestamoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrestamo;
        private System.Windows.Forms.DataGridView dgPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCobroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFiador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFiadorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObservacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColEsCancelado;
    }
}
