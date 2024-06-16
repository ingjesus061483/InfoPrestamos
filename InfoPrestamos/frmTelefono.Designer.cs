
namespace InfoPrestamos
{
    partial class frmTelefono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefono));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgTelefono = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTelefonoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelefonico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTelefono)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAñadir);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Location = new System.Drawing.Point(10, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 41);
            this.panel2.TabIndex = 53;
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(459, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(52, 48);
            this.btnAñadir.TabIndex = 47;
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Narrow", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(555, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(40, 41);
            this.btnsalir.TabIndex = 45;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // dgTelefono
            // 
            this.dgTelefono.AllowUserToAddRows = false;
            this.dgTelefono.AllowUserToDeleteRows = false;
            this.dgTelefono.BackgroundColor = System.Drawing.Color.White;
            this.dgTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver,
            this.eliminar,
            this.Colid,
            this.TipoTelefonoId,
            this.ClienteId,
            this.numerotelefonico,
            this.TipoTelefono});
            this.dgTelefono.Location = new System.Drawing.Point(8, 83);
            this.dgTelefono.Name = "dgTelefono";
            this.dgTelefono.ReadOnly = true;
            this.dgTelefono.RowHeadersVisible = false;
            this.dgTelefono.RowHeadersWidth = 62;
            this.dgTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTelefono.Size = new System.Drawing.Size(596, 246);
            this.dgTelefono.TabIndex = 51;
            this.dgTelefono.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTelefono_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbTipoTelefono);
            this.panel1.Controls.Add(this.txtNumeroTelefonico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 70);
            this.panel1.TabIndex = 52;
            // 
            // cmbTipoTelefono
            // 
            this.cmbTipoTelefono.FormattingEnabled = true;
            this.cmbTipoTelefono.Location = new System.Drawing.Point(134, 34);
            this.cmbTipoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoTelefono.Name = "cmbTipoTelefono";
            this.cmbTipoTelefono.Size = new System.Drawing.Size(455, 21);
            this.cmbTipoTelefono.TabIndex = 47;
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(134, 9);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(455, 22);
            this.txtNumeroTelefonico.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tipo telefono";
            // 
            // Ver
            // 
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Text = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // eliminar
            // 
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // Colid
            // 
            this.Colid.DataPropertyName = "id";
            this.Colid.HeaderText = "Id";
            this.Colid.Name = "Colid";
            this.Colid.ReadOnly = true;
            this.Colid.Visible = false;
            // 
            // TipoTelefonoId
            // 
            this.TipoTelefonoId.DataPropertyName = "TipoTelefonoId";
            this.TipoTelefonoId.HeaderText = "TipoTelefonoId";
            this.TipoTelefonoId.Name = "TipoTelefonoId";
            this.TipoTelefonoId.ReadOnly = true;
            this.TipoTelefonoId.Visible = false;
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Visible = false;
            // 
            // numerotelefonico
            // 
            this.numerotelefonico.DataPropertyName = "NumeroTelefonico";
            this.numerotelefonico.HeaderText = "Numero telefonico";
            this.numerotelefonico.Name = "numerotelefonico";
            this.numerotelefonico.ReadOnly = true;
            // 
            // TipoTelefono
            // 
            this.TipoTelefono.DataPropertyName = "TipoTelefono";
            this.TipoTelefono.HeaderText = "Tipo Telefono";
            this.TipoTelefono.Name = "TipoTelefono";
            this.TipoTelefono.ReadOnly = true;
            // 
            // frmTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(611, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgTelefono);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTelefono";
            this.Text = "frmTelefono";
            this.Load += new System.EventHandler(this.frmTelefono_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTelefono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgTelefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ComboBox cmbTipoTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTelefonoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelefonico;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTelefono;
    }
}