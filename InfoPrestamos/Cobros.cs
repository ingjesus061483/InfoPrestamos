using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Factory;
using Helper;
using Transporte;
namespace InfoPrestamos
{
    public partial class Cobros : UserControl
    {
      PrestamoTransporte PrestamoTransporte;
        ClienteHelp ClienteHelp;
        List<Cuota> cuotas;
        Cuota cuota;
      ClienteTransporte ClienteTransporte;
      CuotaTransporte CuotaTransporte;
        CuotaHelp CuotaHelp;
        PagoHelp PagoHelp;
        FormaPagoHelp formaPagoHelp;
        public Cobros(ClienteHelp _clienteHelp,CuotaHelp _cuotaHelp,PagoHelp _pagoHelp,FormaPagoHelp _formaPagoHelp,PrestamoHelp _prestamoHelp    )
        {
            InitializeComponent();
            ClienteTransporte = new ClienteTransporte(_clienteHelp );
            PrestamoTransporte = new PrestamoTransporte(_prestamoHelp );
            CuotaTransporte = new CuotaTransporte(_cuotaHelp );
            ClienteHelp =_clienteHelp;
            CuotaHelp = _cuotaHelp;
           PagoHelp=_pagoHelp ;
            formaPagoHelp = _formaPagoHelp;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmBusqueda frmBusqueda = new FrmBusqueda
            {
                Persona  = new Transporte.View   .PersonaView () ,
                Lst =ClienteTransporte .List  
            };
            frmBusqueda.ShowDialog();
            int idCliente = frmBusqueda.Id;
            var cliente = ClienteHelp.TEntity.Where(x => x.Id == idCliente).FirstOrDefault();
            if (cliente == null)
            {
                return;
            }
            txtCliente.Text = cliente.Identificacion + " - " + cliente.Nombre + " " + cliente.Apellido;
            dgPrestamo.DataSource = PrestamoTransporte.GetList(idCliente);
        }
        private void dgprestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int idprestamo = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ColId"].Value.ToString());
            dgCuotas.DataSource =CuotaTransporte.GetList(idprestamo);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cuotas.Count ==0)
            {
                Utilities.GetMessage("No hay cuotas en la lista de pagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmPagos frmPagos = new FrmPagos(CuotaHelp ,PagoHelp ,formaPagoHelp )
            { 
                Cuotas =cuotas
            };
            frmPagos.ShowDialog();
            cuotas.Clear();
        }
        private void dgCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                int id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ColIdCuota"].Value.ToString());
                cuota = CuotaHelp.TEntity.Where (x=>x.Id ==id).ToList ().Select(x => new Cuota
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
                }).FirstOrDefault();
                if(cuotas.Where(x=>x.Id==cuota .Id ).FirstOrDefault()!=null)
                {
                    Utilities.GetMessage("La cuota a pagar ya se encuentra registrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                cuotas.Add(cuota);
            }

        }
        private void Cobros_Load(object sender, EventArgs e)
        {
            cuotas = new List<Cuota>();
        }
    }
}
