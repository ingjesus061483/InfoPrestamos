using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory;
using Helper;
using System.Data.Entity.Validation;
using Transporte;
namespace InfoPrestamos
{
    public partial class Empleados : UserControl
    {
        int id;
        int usuarioId;
        UsuarioHelp usuarioHelp;
        Dictionary<string, object> collection;
        EmpleadoHelp EmpleadoHelp;
        EmpleadoTransporte EmpleadoTranporte;
        TipoIdentificacionHelp TipoIdentificacionHelp;
        RoleHelp RoleHelp;
        public Empleados(
                        EmpleadoHelp _empleadoHelp,
                        RoleHelp _roleHelp,
                        TipoIdentificacionHelp _tipoIdentificacionHelp,
                        UsuarioHelp _usuarioHelp )
        {
            EmpleadoHelp = _empleadoHelp;
            InitializeComponent();
            EmpleadoTranporte = new EmpleadoTransporte(_empleadoHelp,_roleHelp);
            RoleHelp = _roleHelp;
            TipoIdentificacionHelp = _tipoIdentificacionHelp;
            usuarioHelp = _usuarioHelp;
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacionHelp.TipoIdentificacions.ToList();
            Utilities.Cmb(cmbTipoIdentificacion, tipoIdentificacions);
            Utilities.Cmb(cmbRole,RoleHelp .Roles .ToList () );
            Nuevo();
        }
        void Nuevo()
        {
            usuarioId = 0;
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbTipoIdentificacion.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEdad.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtPwd.Clear();
            cmbRole.SelectedIndex = -1;
            txtIdentificacion.Focus();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = false;
            dgEmpleado.DataSource = EmpleadoTranporte .List;
            id = 0;
        }
        private void dgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dataGrid.Rows[e.RowIndex].Cells["ColId"].Value.ToString());
                var cliente = EmpleadoHelp.Empleados .Where(x => x.Id == id).FirstOrDefault();
                txtIdentificacion.Text = cliente.Identificacion;
                cmbTipoIdentificacion.SelectedValue = cliente.TipoIdentificacionId;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                dtpFechaNacimiento.Value = cliente.FechaNacimiento;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
                txtUsuario.Text = cliente.Usuario.Nombre ;
                cmbRole.SelectedValue = cliente.Usuario.RoleId;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                usuarioId = cliente.Usuario.Id;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
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
                            {"Telefono", txtTelefono.Text },
                            {"Email", txtEmail.Text },
                            {"TipoIdentificacionId", cmbTipoIdentificacion.SelectedValue != null
                                           ? int.Parse(cmbTipoIdentificacion.SelectedValue.ToString())
                                           : -1 },
                    {"usuario",null }
                };
                Dictionary<string, object> usuarioCol = new Dictionary<string, object>
                {
                    {"Nombre", txtUsuario.Text },
                    {"password",txtPwd  .Text },
                    { "Role",cmbRole.SelectedValue != null
                                                            ? int.Parse(cmbRole.SelectedValue.ToString())
                                                            : -1 },
                };
                if (id == 0)
                {
                    usuarioHelp.Guardar(usuarioCol);
                    var usuario = usuarioHelp.Usuarios.Where(x => x.Nombre == txtUsuario.Text).FirstOrDefault();
                    collection["usuario"] = usuario.Id;
                    EmpleadoHelp.Guardar(collection);
                }
                else
                {
                    var usuario = usuarioHelp.Usuarios.Where(x => x.Id  == usuarioId).FirstOrDefault();
                    usuarioHelp.Actualizar(usuario.Id, usuarioCol);
                    EmpleadoHelp.Actualizar(id, collection);
                }
                Nuevo();
            }
            catch (DbEntityValidationException ex)
            {
                string message = Utilities.GetMessageError(ex);
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            txtEdad.Text = Utilities.CalcularEdad(dateTimePicker.Value).ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var user= usuarioHelp.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefault();
            if (user.Sesion)
            {
                Utilities.GetMessage("La sesion de este usuario esta activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Desea eliminar este registro?", "",    MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                usuarioHelp.Eliminar(usuarioId);
                Nuevo();
            }
        }
    }
}
