using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Helper;
using Factory;
using System.Data.Entity.Validation;
using Transporte;
using Transporte.View;

namespace InfoPrestamos
{
    public partial class Clientes : UserControl
    {
        Dictionary<string, object> collection;
        ClienteHelp clienteHelp ;
        ClienteTransporte clienteTransporte;        
        TipoIdentificacionHelp TipoIdentificacionHelp;
        TelefonoHelp telefonoHelp;
        TipoTelefonoHelp tipoTelefonoHelp;
        List<TelefonoView> telefonos;
        TelefonoTransporte telefonoTransporte;
        int id;
        public Clientes(ClienteHelp _clienteHelp ,
            TipoIdentificacionHelp _tipoIdentificacionHelp,
            ClienteTransporte _clienteTransporte,
            TelefonoHelp _telefonoHelp,
            TipoTelefonoHelp _tipoTelefonoHelp  ,
            TelefonoTransporte _telefonoTransporte )
        {
            InitializeComponent();            
            //clienteTransporte = new ClienteTransporte(_clienteHelp);
            clienteHelp = _clienteHelp;
            clienteTransporte = _clienteTransporte;
            telefonoHelp = _telefonoHelp;
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            tipoTelefonoHelp = _tipoTelefonoHelp;
            telefonoTransporte = _telefonoTransporte;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacionHelp.TipoIdentificacions.ToList();
            Utilities.Cmb(cmbTipoIdentificacion, tipoIdentificacions);
            Nuevo();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                collection = new Dictionary<string, object>{
                            {"Identificacion", txtIdentificacion.Text },
                            {"Nombre", txtNombre.Text },
                            { "Apellido", txtApellido.Text },
                            { "FechaNacimiento",dtpFechaNacimiento .Value },
                            { "Direccion", txtDireccion.Text },                           
                            {"Email", txtEmail.Text },
                            {"TipoIdentificacionId", cmbTipoIdentificacion.SelectedValue != null
                                           ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString())
                                           : -1 },
                };
                if (id==0)
                {
                    clienteHelp.Guardar(collection);
                }
                else
                {
                    clienteHelp.Actualizar(id, collection);
                }
                Nuevo();
            }
            catch (DbEntityValidationException ex)
            {
                string message = Utilities.GetMessageError(ex);
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
            dgClientes.DataSource =clienteTransporte .List ;
            id = 0;
        }
        private void dtpFechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            txtEdad.Text = Utilities.CalcularEdad(dateTimePicker.Value).ToString(); 
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
                var cliente = clienteHelp.Clientes.Where(x => x.Id == id).FirstOrDefault();
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
            var cliente = clienteTransporte.List.Where(x => x.Id == id).FirstOrDefault();
            
            frmTelefono frmTelefono = new frmTelefono(tipoTelefonoHelp ,telefonoHelp,telefonoTransporte )
            {
                Telefonos=telefonos,
                Cliente = cliente ,
            };
            frmTelefono.ShowDialog();
            telefonos = frmTelefono.Telefonos;
        }
    }
}
