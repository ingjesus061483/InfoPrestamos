using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Helper;
using Factory;
using System.Data.Entity.Validation;
using DTO;

namespace InfoPrestamos
{
    public partial class Clientes : UserControl
    {
        ClienteDTO clienteDTO;
        ClienteHelp clienteHelp ;
        TipoIdentificacionHelp TipoIdentificacionHelp;
        TelefonoHelp telefonoHelp;
        TipoTelefonoHelp tipoTelefonoHelp;
        List<TelefonoDTO> telefonos;
        int id;
        public Clientes(ClienteHelp _clienteHelp ,
            TipoIdentificacionHelp _tipoIdentificacionHelp,            
            TelefonoHelp _telefonoHelp,
            TipoTelefonoHelp _tipoTelefonoHelp)
        {
            InitializeComponent();            
            //clienteTransporte = new ClienteTransporte(_clienteHelp);
            clienteHelp = _clienteHelp;            
            telefonoHelp = _telefonoHelp;
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            tipoTelefonoHelp = _tipoTelefonoHelp;            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacionHelp.TEntity .ToList();
            Helper.Utilities.Cmb(cmbTipoIdentificacion, tipoIdentificacions);
            Nuevo();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteDTO = new ClienteDTO { 
                    Identificacion= txtIdentificacion.Text ,
                    Nombre= txtNombre.Text ,
                    Apellido= txtApellido.Text ,
                    FechaNacimiento=dtpFechaNacimiento .Value ,
                    Direccion= txtDireccion.Text ,                           
                    Email= txtEmail.Text ,
                    TipoIdentificacionId= cmbTipoIdentificacion.SelectedValue != null? 
                                          int.Parse(cmbTipoIdentificacion.SelectedValue.ToString())
                                          : -1 ,
                };
                if (id==0)
                {
                    clienteHelp.Guardar(clienteDTO);
                }
                else
                {
                    clienteHelp.Actualizar(id,clienteDTO);
                }
                Nuevo();
            }
            catch (DbEntityValidationException ex)
            {
                string message = Helper.Utilities.GetMessageError(ex);
                MessageBox.Show(message , "",MessageBoxButtons.OK , MessageBoxIcon.Error );
            }

        }
        void Nuevo()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear  ();            
            cmbTipoIdentificacion.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEdad.Clear();
            txtEmail.Clear();
            txtIdentificacion.Focus();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = false;
            id = 0;
        }
        private void dtpFechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            txtEdad.Text = Helper.Utilities.CalcularEdad(dateTimePicker.Value).ToString(); 
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid  = (DataGridView )sender;
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["ColId"].Value.ToString());
                var cliente = clienteHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
                txtIdentificacion.Text = cliente.Identificacion;
                cmbTipoIdentificacion.SelectedValue = cliente.TipoIdentificacionId;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                dtpFechaNacimiento.Value = cliente.FechaNacimiento;
                txtDireccion.Text = cliente.Direccion;           
                txtEmail.Text = cliente.Email;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar este registro?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (result == DialogResult.Yes)
            {
                clienteHelp.Eliminar(id);
                Nuevo();
            }
        }

        private void btnListaTelefonos_Click(object sender, EventArgs e)
        {

            
            frmTelefono frmTelefono = new frmTelefono(tipoTelefonoHelp ,telefonoHelp )
            {
                Telefonos=telefonos,
                
            };
            frmTelefono.ShowDialog();
            telefonos = frmTelefono.Telefonos;
        }
    }
}
