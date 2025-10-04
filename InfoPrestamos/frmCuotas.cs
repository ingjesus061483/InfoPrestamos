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
    public partial class frmCuotas : Form
    {
        double monto;
        public  List<Amortizacion> Cuotas { get; set; }
        public double Tiempo { get; set; }
        public double PorcentajeInteres { get; set; }
        public string TipoCobro { get; set; }
        public double Monto { get; set; }
        public frmCuotas(AmortizacionHelp cuotaHelp )
        {
            InitializeComponent();

        }
        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if(monto==0)
            {
Helper.              Utilities.GetMessage("Verifique el formato o escriba un numero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double.TryParse(txtPorcentajeInteres.Text, out double porcentajeInteres);           
            porcentajeInteres /= 100;
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
    //        Cuotas =  Utilities.GetCuotas(dateTimePicker.Value, TipoCobro, monto, porcentajeInteres, Tiempo);            
            Monto = monto;
            PorcentajeInteres = porcentajeInteres;
//            dgCuotas.DataSource =CuotaTransporte .GetList(Cuotas);
        }
        private void frmCuotas_Load(object sender, EventArgs e)
        {
            txtMonto.Text = String.Format("{0:C}", Monto);
            txtPorcentajeInteres.Text = PorcentajeInteres.ToString();
 //           dgCuotas.DataSource = CuotaTransporte.GetList(Cuotas);
            this.Focus();
        }
        private void txtMonto_Leave(object sender, EventArgs e)
        {
            string textWithhoutFormat = txtMonto.Text;
            textWithhoutFormat .Replace("$ ", "").Replace(".", "");
            double.TryParse(textWithhoutFormat , out monto);
            txtMonto.Text = String.Format("{0:C}", monto);

        }       
        private void txtMonto_Enter(object sender, EventArgs e)
        {
            txtMonto.Text=     txtMonto.Text.Replace("$ ", "").Replace(".", "").Replace(",00","");
            double.TryParse(txtMonto .Text   , out monto);
        }
    }
}
