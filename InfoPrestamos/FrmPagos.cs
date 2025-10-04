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
    public partial class FrmPagos : Form
    {
        Dictionary<string, object> collection;
        public  Usuario Usuario { get; set; }
        public List  <Amortizacion> Cuotas  { get; set; }
        FormaPagoHelp formaPagoHelp;
        int tipoPagoId;
        AmortizacionHelp cuotaHelp;
        PagoHelp PagoHelp;
     //   BindingList<Transporte .View . CuotaView > bingCuotas;
        decimal sumCuotas = 0;
        decimal sumCapital = 0;
        decimal sumInteres = 0;
        public FrmPagos(AmortizacionHelp _cuotaHelp,PagoHelp _pagoHelp,FormaPagoHelp _formaPagoHelp  )
        {
            InitializeComponent();
            cuotaHelp = _cuotaHelp;
            PagoHelp = _pagoHelp;
       //     cuotaTransporte = new CuotaTransporte(  cuotaHelp  );
         //   bingCuotas = new BindingList<Transporte.View . CuotaView  >();
            formaPagoHelp = _formaPagoHelp;
           // bingCuotas .ListChanged += bingCuotas_ListChanged;
        }
        private void bingCuotas_ListChanged(object sender, ListChangedEventArgs e)
        {           
          //  dgCuotas.DataSource = bingCuotas;
        }
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            txtReferencia.Text = DateTime.Now.ToOADate().ToString();
            //List <CuotaView > cuotaViews =(List < Transporte.View.CuotaView >) cuotaTransporte.GetList(Cuotas);
           Helper.  Utilities.Cmb(cmbFormaPago, formaPagoHelp.TEntity.ToList());
           /* foreach(Transporte.View .CuotaView cuotaView in cuotaViews)
            {
                var cuota = cuotaHelp.TEntity.Where(x => x.Id == cuotaView.Id).FirstOrDefault();
                sumCuotas += cuota.Couta;
                sumCapital += cuota.Capital;
                sumInteres += cuota.Interes;

                bingCuotas.Add(cuotaView);
            }*/
            txtValorMinCancelar.Text = sumCuotas.ToString();
        }
        private void dgCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                int id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["ColIdCuota"].Value.ToString());
               // var cuotaview =bingCuotas .Where(x => x.Id == id).FirstOrDefault();
               // bingCuotas.Remove(cuotaview );
                var cuota = cuotaHelp.TEntity.Where(x => x.Id == id).FirstOrDefault();
              
            }  
           /* if(bingCuotas .Count ==0)
            {
                Close();
            }*/
        }        
        private void rbtPagoCuota_CheckedChanged(object sender, EventArgs e)
        {
            txtValorMinCancelar.Text = sumCuotas.ToString();
            tipoPagoId = 1;
        }
        private void rbtAbonoCapital_CheckedChanged(object sender, EventArgs e)
        {
            txtValorMinCancelar.Text = sumCapital.ToString();
            tipoPagoId = 2;
        }

        private void rbtAbonoInteres_CheckedChanged(object sender, EventArgs e)
        {
            txtValorMinCancelar.Text = sumInteres.ToString();
            tipoPagoId = 3;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            collection = new Dictionary<string, object>
            {
                {"Referencia",txtReferencia .Text  },
                {"Fecha",dtpFecha.Value  },
                {"PagoMinimo",txtValorMinCancelar .Text  },
                {"ValorPagar",txtValorPagar .Text  },
                {"Observaciones",txtComentarios.Text },
                {"FormaPagoId",cmbFormaPago .SelectedValue  },
                {"TipoPagoId",tipoPagoId },
                {"EmpleadoId",Usuario .Empleados [0].Id},
                {"cuotas" ,Cuotas  }
            };
        //    PagoHelp.Guardar(collection);
        }
    }
}
