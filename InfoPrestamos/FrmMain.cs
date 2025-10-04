using Factory;
using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InfoPrestamos
{
    public partial class MainForm : Form
    {
        Usuario Usuario { get; set; }
        public MainForm(UsuarioHelp _usuarioHelp,
                        ClienteHelp _clienteHelp,
                        EmpleadoHelp _empleadoHelp,
                        AmortizacionHelp _cuotaHelp,
                        FiadorHelp _fiadorHelp,
                        FormaPagoHelp _formaPagoHelp,
                        PagoHelp _pagoHelp,
                        PrestamoHelp _prestamoHelp,
                        RoleHelp _roleHelp,
                        TipoCobroHelp _tipoCobroHelp,
                        TipoIdentificacionHelp _tipoIdentificacionHelp,
               
                        TelefonoHelp _telefonoHelp  ,
                        TipoTelefonoHelp _tipoTelefonoHelp               )
        {
            InitializeComponent();
            telefonoHelp = _telefonoHelp;
            usuarioHelp = _usuarioHelp;
            clienteHelp = _clienteHelp;
            empleadoHelp = _empleadoHelp;
            cuotaHelp = _cuotaHelp;
            fiadorHelp = _fiadorHelp;
            formaPagoHelp = _formaPagoHelp;
            pagoHelp = _pagoHelp;
            prestamoHelp = _prestamoHelp;
            roleHelp = _roleHelp;
            tipoCobroHelp = _tipoCobroHelp;
            tipoIdentificacionHelp = _tipoIdentificacionHelp;
            tipoTelefonoHelp = _tipoTelefonoHelp;
           
        }
   
        private void btnEstudiante_Click(object sender, EventArgs e)
        { 
            Clientes cliente = new Clientes(clienteHelp ,tipoIdentificacionHelp  ,telefonoHelp ,tipoTelefonoHelp );
  Helper.          Utilities.MostrarControl(pnlPrincipal, cliente);
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos(fiadorHelp ,clienteHelp ,
                tipoCobroHelp ,prestamoHelp ,cuotaHelp)
            { 
              //  Usuario = Usuario 
            };
        Helper.    Utilities.MostrarControl(pnlPrincipal, prestamos);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin(usuarioHelp ) ;       
            login.ShowDialog();
            Usuario = login.Usuario;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Empleados empleados  = new Empleados(empleadoHelp ,roleHelp ,tipoIdentificacionHelp ,usuarioHelp );
          Helper.  Utilities.MostrarControl(pnlPrincipal, empleados );
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Desea salir de la aplicacion", "info prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
                Application.Exit();
        }
        private void btnFiador_Click(object sender, EventArgs e)
        {
            Fiadores fiadores = new Fiadores(tipoIdentificacionHelp , fiadorHelp );
            Helper.Utilities.MostrarControl(pnlPrincipal, fiadores);
        }
        private void btnCuentasCobrar_Click(object sender, EventArgs e)
        {
            Cobros cobros = new Cobros(clienteHelp ,cuotaHelp ,pagoHelp ,formaPagoHelp,prestamoHelp  );
            Helper.Utilities.MostrarControl(pnlPrincipal, cobros);
        }        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Usuario !=null)
            {
                usuarioHelp.ActivarSesion(Usuario.Id, false);
            }           
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

            HistorialPago historialPago = new HistorialPago();
            Helper.Utilities.MostrarControl(pnlPrincipal, historialPago);
        }
    }
}
