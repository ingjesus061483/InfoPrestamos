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
using Transporte;
namespace InfoPrestamos
{
    public partial class Prestamos : UserControl
    {
        public Usuario Usuario { get; set; }
        ClienteHelp ClienteHelp;
        FiadorTransporte FiadorTransporte;
        ClienteTransporte ClienteTransporte;
        PrestamoTransporte PrestamoTransporte;
        Dictionary<string, object> collection;
        CuotaHelp CuotaHelp;
        TipoCobroHelp TipoCobroHelp;
        FiadorHelp FiadorHelp;
        PrestamoHelp PrestamoHelp; 
        List<Cuota> cuotas;
        FrmBusqueda frmBusqueda;
        double monto;
        double PorcentajeInteres;
        int id;
        int idCliente;
        int idFiador;

        public Prestamos(FiadorHelp _fiadorHelp,
                         ClienteHelp _clienteHelp,
                         TipoCobroHelp _tipoCobroHelp,
                         PrestamoHelp _prestamoHelp,
                         CuotaHelp _cuotaHelp )
        {
            InitializeComponent();
            FiadorTransporte = new FiadorTransporte(_fiadorHelp);
            FiadorHelp = _fiadorHelp ;
            ClienteHelp = _clienteHelp;
            TipoCobroHelp = _tipoCobroHelp;
            PrestamoHelp = _prestamoHelp;
            CuotaHelp = _cuotaHelp;
            PrestamoTransporte = new PrestamoTransporte(_prestamoHelp);
            ClienteTransporte = new ClienteTransporte(_clienteHelp  );
        }
        private void Prestamos_Load(object sender, EventArgs e)
        {
            List<TipoCobro> tipoCobros = TipoCobroHelp.TipoCobros.ToList();
            Utilities.Cmb(cmbTipoCobro, tipoCobros);
            frmBusqueda = new FrmBusqueda
            {
                Persona = new Transporte.View .PersonaView(),
            };
            Nuevo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtTiempo.Text, out int tiempo);
            if(tiempo==0)
            {
                Utilities.GetMessage("El campo tiempo esta vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTiempo.Focus();
                return;
            }
            if(string .IsNullOrEmpty ( cmbTipoCobro.Text ))
            {
                Utilities.GetMessage("El campo Tipo cobro esta vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoCobro .Focus();
                return;
            }
            frmCuotas frmCuotas = new frmCuotas(CuotaHelp )
            {
                Tiempo = tiempo,
                Cuotas = cuotas ,
                Monto =monto,
                PorcentajeInteres=PorcentajeInteres ,
                TipoCobro = cmbTipoCobro.Text,            
            };
            frmCuotas.ShowDialog();
            monto = frmCuotas.Monto;
            cuotas = frmCuotas.Cuotas;
            PorcentajeInteres = frmCuotas.PorcentajeInteres;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmBusqueda.Lst = FiadorTransporte.List;            
            frmBusqueda.ShowDialog();
            idFiador  = frmBusqueda.Id;
            var fiador = FiadorHelp .Fiadors .Where(x => x.Id == idFiador ).FirstOrDefault();
            if (fiador  == null)
            {
                return;
            }
            txtFiador.Text = fiador .Identificacion + " - " + fiador.Nombre + " " + fiador .Apellido;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmBusqueda.Lst = ClienteTransporte.List; 
            frmBusqueda.ShowDialog();
            idCliente = frmBusqueda.Id;
            var cliente = ClienteHelp.Clientes.Where(x => x.Id == idCliente).FirstOrDefault();
            if (cliente == null)
            {
                return;
            }
            txtcliente.Text = cliente.Identificacion + " - " + cliente.Nombre + " " + cliente.Apellido;         

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void  Nuevo()
        {
            dgPrestamo.DataSource = PrestamoTransporte .List;
            txtCodigo.Text = DateTime.Now.ToOADate().ToString();
            txtTiempo.Clear();
            txtObservaciones.Clear();                     
            txtcliente.Clear();
            txtFiador.Clear();
            idCliente=0;
            idFiador=0;
            monto = 0;
            PorcentajeInteres = 0;
            id = 0;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = false;
            cuotas = new List<Cuota>();
            cmbTipoCobro.SelectedIndex = -1;
            txtTiempo.Focus();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            collection = new Dictionary<string, object> {
                { "Codigo",txtCodigo .Text  },
                { "Monto" ,monto  },
                {"Tiempo",txtTiempo .Text  },
                {"Interes",PorcentajeInteres  },
                {"Fecha", DateTime .Now },
                {"Observacion",txtObservaciones .Text  },
                {"EsCancelado",false },
                {"ClienteId", idCliente },
                { "TipoCobroId",cmbTipoCobro .SelectedValue  },
                {"FiadorId",idFiador },
                {"EmpleadoId", Usuario.Empleados [0].Id},
                {"cuotas",cuotas }
            };
            if (id == 0)
            {
                PrestamoHelp.Guardar(collection);
            }
            Nuevo();

        }
        private void dgPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ColId"].Value.ToString());
            var prestamo = PrestamoHelp.Prestamos.Where(x => x.Id == id).FirstOrDefault();
            txtCodigo.Text = prestamo.Codigo;
            txtTiempo.Text = prestamo.Tiempo.ToString();
            txtObservaciones.Text = prestamo.Observacion;
            txtcliente.Text = prestamo.Cliente.Identificacion + " - " + prestamo.Cliente.NombreCompleto;
            txtFiador.Text = prestamo.Fiador != null ? prestamo.Fiador.Identificacion + " - " + prestamo.Fiador.NombreCompleto : "";
            idCliente = prestamo.ClienteId;
            idFiador = prestamo.Fiador != null ? prestamo.Fiador.Id : 0 ;
            cmbTipoCobro.SelectedValue = prestamo .TipoCobroId  ;
            monto =double .Parse ( prestamo .Monto.ToString () );
            PorcentajeInteres =double .Parse ( prestamo .Interes.ToString ()) ;
            cuotas = CuotaHelp.GetCuotasByPrestamos(id).ToList(). Select(x => new Cuota
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Fecha = x.Fecha,
                Couta = x.Couta,
                Interes = x.Interes,
                Capital = x.Capital,
                Saldo = x.Saldo,
                Observaciones = x.Observaciones,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = x.Prestamo
            }).ToList();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar este registro?", "", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               PrestamoHelp .Eliminar(id);
               Nuevo();
            }
        }
    }
}
