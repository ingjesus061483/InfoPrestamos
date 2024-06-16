
namespace InfoPrestamos
{
    partial class FrmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.rbtAbonoInteres = new System.Windows.Forms.RadioButton();
            this.rbtAbonoCapital = new System.Windows.Forms.RadioButton();
            this.rbtPagoCuota = new System.Windows.Forms.RadioButton();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorMinCancelar = new System.Windows.Forms.TextBox();
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
            this.Panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Location = new System.Drawing.Point(13, 697);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(774, 62);
            this.Panel3.TabIndex = 1111;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(714, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1084;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.rbtAbonoInteres);
            this.panel1.Controls.Add(this.rbtAbonoCapital);
            this.panel1.Controls.Add(this.rbtPagoCuota);
            this.panel1.Controls.Add(this.cmbFormaPago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtValorPagar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtValorMinCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 359);
            this.panel1.TabIndex = 1119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 1130;
            this.label1.Text = "Referencia de pago";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(253, 53);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(504, 30);
            this.txtReferencia.TabIndex = 1129;
            // 
            // rbtAbonoInteres
            // 
            this.rbtAbonoInteres.AutoSize = true;
            this.rbtAbonoInteres.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAbonoInteres.Location = new System.Drawing.Point(464, 14);
            this.rbtAbonoInteres.Name = "rbtAbonoInteres";
            this.rbtAbonoInteres.Size = new System.Drawing.Size(184, 28);
            this.rbtAbonoInteres.TabIndex = 1128;
            this.rbtAbonoInteres.Text = "Abono a interes";
            this.rbtAbonoInteres.UseVisualStyleBackColor = true;
            this.rbtAbonoInteres.CheckedChanged += new System.EventHandler(this.rbtAbonoInteres_CheckedChanged);
            // 
            // rbtAbonoCapital
            // 
            this.rbtAbonoCapital.AutoSize = true;
            this.rbtAbonoCapital.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAbonoCapital.Location = new System.Drawing.Point(257, 14);
            this.rbtAbonoCapital.Name = "rbtAbonoCapital";
            this.rbtAbonoCapital.Size = new System.Drawing.Size(181, 28);
            this.rbtAbonoCapital.TabIndex = 1127;
            this.rbtAbonoCapital.Text = "Abono a capital";
            this.rbtAbonoCapital.UseVisualStyleBackColor = true;
            this.rbtAbonoCapital.CheckedChanged += new System.EventHandler(this.rbtAbonoCapital_CheckedChanged);
            // 
            // rbtPagoCuota
            // 
            this.rbtPagoCuota.AutoSize = true;
            this.rbtPagoCuota.Checked = true;
            this.rbtPagoCuota.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPagoCuota.Location = new System.Drawing.Point(72, 14);
            this.rbtPagoCuota.Name = "rbtPagoCuota";
            this.rbtPagoCuota.Size = new System.Drawing.Size(171, 28);
            this.rbtPagoCuota.TabIndex = 1126;
            this.rbtPagoCuota.TabStop = true;
            this.rbtPagoCuota.Text = "Pago de cuota";
            this.rbtPagoCuota.UseVisualStyleBackColor = true;
            this.rbtPagoCuota.CheckedChanged += new System.EventHandler(this.rbtPagoCuota_CheckedChanged);
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(253, 300);
            this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(503, 31);
            this.cmbFormaPago.TabIndex = 1125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 1124;
            this.label4.Text = "Forma de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 1123;
            this.label5.Text = "Valor a pagar";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagar.Location = new System.Drawing.Point(253, 165);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(504, 30);
            this.txtValorPagar.TabIndex = 1122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 1121;
            this.label3.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(253, 203);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(504, 87);
            this.txtComentarios.TabIndex = 1120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1119;
            this.label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(253, 91);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(504, 30);
            this.dtpFecha.TabIndex = 1118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 24);
            this.label9.TabIndex = 1117;
            this.label9.Text = "Valor minimo a cancelar";
            // 
            // txtValorMinCancelar
            // 
            this.txtValorMinCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMinCancelar.Location = new System.Drawing.Point(253, 128);
            this.txtValorMinCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMinCancelar.Name = "txtValorMinCancelar";
            this.txtValorMinCancelar.ReadOnly = true;
            this.txtValorMinCancelar.Size = new System.Drawing.Size(504, 30);
            this.txtValorMinCancelar.TabIndex = 1116;
            // 
            // dgCuotas
            // 
            this.dgCuotas.AllowUserToAddRows = false;
            this.dgCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgCuotas.Location = new System.Drawing.Point(13, 14);
            this.dgCuotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgCuotas.Name = "dgCuotas";
            this.dgCuotas.ReadOnly = true;
            this.dgCuotas.RowHeadersVisible = false;
            this.dgCuotas.RowHeadersWidth = 62;
            this.dgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCuotas.Size = new System.Drawing.Size(774, 311);
            this.dgCuotas.TabIndex = 1126;
            this.dgCuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuotas_CellContentClick);
            // 
            // ColAgregar
            // 
            this.ColAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColAgregar.HeaderText = "";
            this.ColAgregar.MinimumWidth = 8;
            this.ColAgregar.Name = "ColAgregar";
            this.ColAgregar.ReadOnly = true;
            this.ColAgregar.Text = "Eliminar pago";
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
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.dgCuotas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel3);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.Panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorMinCancelar;
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
        private System.Windows.Forms.RadioButton rbtAbonoInteres;
        private System.Windows.Forms.RadioButton rbtAbonoCapital;
        private System.Windows.Forms.RadioButton rbtPagoCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
    }
}