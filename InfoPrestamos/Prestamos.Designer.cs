namespace InfoPrestamos
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiador = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoCobro = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(8, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 82);
            this.panel2.TabIndex = 1113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 56);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prestamos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFiador);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtTiempo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcliente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbTipoCobro);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(8, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 335);
            this.panel1.TabIndex = 1114;
            // 
            // txtFiador
            // 
            this.txtFiador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiador.Location = new System.Drawing.Point(245, 197);
            this.txtFiador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiador.Name = "txtFiador";
            this.txtFiador.ReadOnly = true;
            this.txtFiador.Size = new System.Drawing.Size(404, 30);
            this.txtFiador.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(114, 195);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 23;
            this.button4.Text = "Fiador";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(242, 56);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(411, 30);
            this.txtTiempo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tiempo Cancelacion";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(244, 94);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(407, 95);
            this.txtObservaciones.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observaciones";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(242, 21);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(411, 30);
            this.txtCodigo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(247, 240);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(406, 30);
            this.txtcliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Periodo Cancelacion";
            // 
            // cmbTipoCobro
            // 
            this.cmbTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCobro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCobro.FormattingEnabled = true;
            this.cmbTipoCobro.Location = new System.Drawing.Point(245, 282);
            this.cmbTipoCobro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoCobro.Name = "cmbTipoCobro";
            this.cmbTipoCobro.Size = new System.Drawing.Size(408, 31);
            this.cmbTipoCobro.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(116, 239);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clientes";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.button1);
            this.Panel3.Controls.Add(this.btnCancelar);
            this.Panel3.Controls.Add(this.btnNuevo);
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Location = new System.Drawing.Point(9, 438);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(672, 62);
            this.Panel3.TabIndex = 1115;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::InfoPrestamos.Properties.Resources.calculadora;
            this.button1.Location = new System.Drawing.Point(432, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 62);
            this.button1.TabIndex = 1099;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(492, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 62);
            this.btnCancelar.TabIndex = 1097;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(552, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 62);
            this.btnNuevo.TabIndex = 1098;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(612, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1084;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.dgPrestamo.Location = new System.Drawing.Point(8, 504);
            this.dgPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPrestamo.Name = "dgPrestamo";
            this.dgPrestamo.ReadOnly = true;
            this.dgPrestamo.RowHeadersVisible = false;
            this.dgPrestamo.RowHeadersWidth = 62;
            this.dgPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPrestamo.Size = new System.Drawing.Size(675, 338);
            this.dgPrestamo.TabIndex = 1116;
            this.dgPrestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrestamo_CellContentClick);
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
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.dgPrestamo);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Prestamos";
            this.Size = new System.Drawing.Size(688, 849);
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbTipoCobro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFiador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
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
