using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Factory;
using Helper;
using System.Data.Entity.Validation;
using Transporte;
using DTO;
namespace InfoPrestamos
{
    public partial class Fiadores : UserControl
    {
        int id;
       FiadorDTO fiadorDTO;
        FiadorTransporte FiadorTransporte;
        TipoIdentificacionHelp TipoIdentificacionHelp;
        FiadorHelp FiadorHelp;
        public Fiadores(TipoIdentificacionHelp _tipoIdentificacionHelp,FiadorHelp _fiadorHelp  )
        {
            InitializeComponent();
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            FiadorHelp  = _fiadorHelp ;
            FiadorTransporte = new FiadorTransporte( FiadorHelp );
        }
        private void Fiadores_Load(object sender, EventArgs e)
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacionHelp.TEntity.ToList();
            Utilities.Cmb(cmbTipoIdentificacion, tipoIdentificacions);
            Nuevo();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void Nuevo()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbTipoIdentificacion.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEdad.Clear();
            txtEmail.Clear();
            txtIdentificacion.Focus();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = false;
            dgFiador.DataSource = FiadorTransporte.List;
            id = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                fiadorDTO= new FiadorDTO
                {
                    Identificacion = txtIdentificacion.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    EmperesaDondeLabora = txtEmperesaDondeLabora.Text,
                    TipoIdentificacionId = cmbTipoIdentificacion.SelectedValue != null
                                           ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString())
                                           : -1,
                };

                if (id == 0)
                {
                    FiadorHelp.Guardar(fiadorDTO );
                }
                else
                {
                    FiadorHelp.Actualizar(id,fiadorDTO );
                }
                Nuevo();
            }
            catch (DbEntityValidationException ex)
            {
                string message = Utilities.GetMessageError(ex);
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar este registro?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FiadorHelp.Eliminar(id);
                Nuevo();
            }
        }
        private void dgFiador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["ColId"].Value.ToString());
                var Fiador = FiadorHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
                txtIdentificacion.Text = Fiador.Identificacion;
                cmbTipoIdentificacion.SelectedValue = Fiador.TipoIdentificacionId;
                txtNombre.Text = Fiador.Nombre;
                txtApellido.Text = Fiador.Apellido;
                dtpFechaNacimiento.Value = Fiador.FechaNacimiento;
                txtEmperesaDondeLabora.Text = Fiador.EmperesaDondeLabora;
                txtDireccion.Text = Fiador.Direccion;
                txtTelefono.Text = Fiador.Telefono;
                txtEmail.Text = Fiador.Email;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            txtEdad.Text = Utilities.CalcularEdad(dateTimePicker.Value).ToString();
        }
    }
}
