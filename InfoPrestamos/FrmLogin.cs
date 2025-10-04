using Factory;
using Helper;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace InfoPrestamos
{
    public partial class FrmLogin : Form
    {
        UsuarioHelp UsuarioHelp;
        public  Usuario Usuario  { get; set; }
        public FrmLogin(UsuarioHelp _usuarioHelp)
        {
            InitializeComponent();
            UsuarioHelp = _usuarioHelp;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea salir de la aplicacion", "info prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
                Application.Exit();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string pwd = Helper.Utilities.Encriptar(txtPassword.Text);
            var usuario= UsuarioHelp.TEntity.Where(x => x.Nombre == txtUsuario.Text && x.Password == pwd). AsEnumerable(). Select ( x=> new Usuario
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Password = x.Password,
                RoleId = x.RoleId,
                Role = x.Role,
                Sesion =x.Sesion,
   //             Empleados = x.Empleados
            }). FirstOrDefault ();
            if (usuario ==null  )
            {
                Helper.Utilities.GetMessage("El usuario no se encuentra disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            UsuarioHelp.ActivarSesion(usuario.Id, true);
            Usuario  = UsuarioHelp.TEntity.Where(x => x.Id ==usuario.Id ).AsEnumerable().Select(x => new Usuario
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Password = x.Password,
                RoleId = x.RoleId,
                Role = x.Role,
                Sesion = x.Sesion,
               // Empleados = x.Empleados
            }).FirstOrDefault(); 
            this.Close();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnNuevo.PerformClick();
            }
        }
    }
}
