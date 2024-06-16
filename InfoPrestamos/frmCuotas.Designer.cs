
namespace InfoPrestamos
{
    partial class frmCuotas
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
            this.dgCuotas = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPagoCompleto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColPrestamoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorcentajeInteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCuotas
            // 
            this.dgCuotas.AllowUserToAddRows = false;
            this.dgCuotas.AllowUserToDeleteRows = false;
            this.dgCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCuotas.BackgroundColor = System.Drawing.Color.White;
            this.dgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColCodigo,
            this.ColFecha,
            this.ColCuotas,
            this.ColInteres,
            this.ColCapital,
            this.ColSaldo,
            this.ColObservaciones,
            this.ColPagoCompleto,
            this.ColPrestamoId,
            this.ColPrestamo});
            this.dgCuotas.Location = new System.Drawing.Point(8, 180);
            this.dgCuotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgCuotas.Name = "dgCuotas";
            this.dgCuotas.ReadOnly = true;
            this.dgCuotas.RowHeadersVisible = false;
            this.dgCuotas.RowHeadersWidth = 62;
            this.dgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCuotas.Size = new System.Drawing.Size(819, 279);
            this.dgCuotas.TabIndex = 1117;
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
            // ColCuotas
            // 
            this.ColCuotas.DataPropertyName = "Cuota";
            this.ColCuotas.HeaderText = "Cuotas";
            this.ColCuotas.MinimumWidth = 8;
            this.ColCuotas.Name = "ColCuotas";
            this.ColCuotas.ReadOnly = true;
            this.ColCuotas.Width = 150;
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
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(142, 23);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(659, 30);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.Enter += new System.EventHandler(this.txtMonto_Enter);
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "% de interes";
            // 
            // txtPorcentajeInteres
            // 
            this.txtPorcentajeInteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorcentajeInteres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeInteres.Location = new System.Drawing.Point(142, 61);
            this.txtPorcentajeInteres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPorcentajeInteres.Name = "txtPorcentajeInteres";
            this.txtPorcentajeInteres.Size = new System.Drawing.Size(659, 30);
            this.txtPorcentajeInteres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(142, 101);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(658, 30);
            this.dtpFechaInicial.TabIndex = 9;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPorcentajeInteres);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFechaInicial);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 162);
            this.panel1.TabIndex = 1118;
            // 
            // frmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgCuotas);
            this.Name = "frmCuotas";
            this.Text = "frmCuotas";
            this.Load += new System.EventHandler(this.frmCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCuotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCuotas;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorcentajeInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObservaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPagoCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrestamoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrestamo;
        private System.Windows.Forms.Panel panel1;
    }
}