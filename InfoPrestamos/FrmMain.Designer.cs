using Helper;
using Transporte;

namespace InfoPrestamos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEstudiante = new System.Windows.Forms.ToolStripButton();
            this.btnFiador = new System.Windows.Forms.ToolStripButton();
            this.btnCursos = new System.Windows.Forms.ToolStripButton();
            this.btnCuentasCobrar = new System.Windows.Forms.ToolStripButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.ToolStripButton();
            this.pnlToolBar.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Controls.Add(this.ToolStrip1);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1200, 102);
            this.pnlToolBar.TabIndex = 0;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEstudiante,
            this.btnFiador,
            this.btnCursos,
            this.btnCuentasCobrar,
            this.btnUsuarios,
            this.btnHistorial,
            this.btnCerrar});
            this.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStrip1.Size = new System.Drawing.Size(1200, 102);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.White;
            this.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiante.Image")));
            this.btnEstudiante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstudiante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEstudiante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(77, 97);
            this.btnEstudiante.Text = "Clientes";
            this.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstudiante.ToolTipText = "Estudiantes";
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnFiador
            // 
            this.btnFiador.BackColor = System.Drawing.Color.White;
            this.btnFiador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiador.Image = ((System.Drawing.Image)(resources.GetObject("btnFiador.Image")));
            this.btnFiador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiador.Name = "btnFiador";
            this.btnFiador.Size = new System.Drawing.Size(83, 97);
            this.btnFiador.Text = "Fiadores";
            this.btnFiador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFiador.Click += new System.EventHandler(this.btnFiador_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.White;
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnCursos.Image")));
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCursos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(99, 97);
            this.btnCursos.Text = "Prestamos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCursos.ToolTipText = "Cursos";
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnCuentasCobrar
            // 
            this.btnCuentasCobrar.BackColor = System.Drawing.Color.White;
            this.btnCuentasCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuentasCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentasCobrar.Image")));
            this.btnCuentasCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuentasCobrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCuentasCobrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuentasCobrar.Name = "btnCuentasCobrar";
            this.btnCuentasCobrar.Size = new System.Drawing.Size(74, 97);
            this.btnCuentasCobrar.Text = "Cobros";
            this.btnCuentasCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCuentasCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCuentasCobrar.Click += new System.EventHandler(this.btnCuentasCobrar_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(84, 97);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.ToolTipText = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(63, 97);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(230, 102);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(970, 590);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 590);
            this.panel2.TabIndex = 2;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHistorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(229, 97);
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Info Pretamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlToolBar.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.Panel pnlPrincipal;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnEstudiante;
        internal System.Windows.Forms.ToolStripButton btnCursos;
        internal System.Windows.Forms.ToolStripButton btnCuentasCobrar;
        internal System.Windows.Forms.ToolStripButton btnUsuarios;
        internal System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.ToolStripButton btnFiador;
        UsuarioHelp usuarioHelp;
        CuotaHelp cuotaHelp;
        EmpleadoHelp empleadoHelp;
        FiadorHelp fiadorHelp;
        FormaPagoHelp formaPagoHelp;
        PagoHelp pagoHelp;
        PrestamoHelp prestamoHelp;
        RoleHelp roleHelp;
        TipoCobroHelp tipoCobroHelp;
        TipoIdentificacionHelp tipoIdentificacionHelp;
        ClienteHelp clienteHelp;
        ClienteTransporte clienteTransporte;
        PrestamoTransporte prestamoTransporte;
        FiadorTransporte fiadorTransporte;
        CuotaTransporte cuotaTransporte;
        EmpleadoTransporte empleadoTransporte;
        TelefonoHelp telefonoHelp;
        TipoTelefonoHelp tipoTelefonoHelp;
        TelefonoTransporte TelefonoTransporte;
        private System.Windows.Forms.ToolStripButton btnHistorial;
    }
}

