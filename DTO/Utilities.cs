using Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte
{
   public abstract class Utilities
    {
        public static  List<View. PersonaView> GetPersonas(List<View . PersonaView> personas, string property,  string search)
        {
            List<View . PersonaView> result = personas.Where(x => x.GetType().GetProperty(property )
                                                                     .GetValue(x).ToString()
                                                                     .Contains(search)).ToList();
            return result.Count == 0 ? personas : result;
        }
        public static  void MostrarControl(Panel pnl, Control control)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(control);
        }
        public static List<Cuota> GetCuotas(DateTime fechaIni, string tipocobro, double monto, double porcentajeInteres, double tiempo)
        {
            List<Cuota> cuotas = new List<Cuota>();
            double cuota = CalcularCuotas(monto, porcentajeInteres, tiempo);
            double montoInicial = monto;
            for (int i = 1; i <= tiempo; i++)
            {
                double interes = Math.Round(montoInicial * porcentajeInteres);
                double capital = Math.Round(cuota - interes);
                double saldoInicial = Math.Round(montoInicial - capital);
                switch (tipocobro)
                {
                    case "Diario":
                        {
                            //dtpFechaFinal.Value = dateTimePicker.Value.AddDays(1);
                            break;
                        }
                    case "Mensual":
                        {
                            DateTime date = fechaIni.AddMonths(i);
                            Cuota cobro = new Cuota
                            {
                                Fecha = date,
                                Couta = decimal.Parse(cuota.ToString()),
                                Capital = decimal.Parse(capital.ToString()),
                                Saldo = decimal.Parse(saldoInicial.ToString()),
                                Interes = decimal.Parse(interes.ToString()),
                                Codigo = date.ToOADate().ToString()
                            };
                            cuotas.Add(cobro);
                            montoInicial = saldoInicial;
                            break;
                        }
                }
            }
            return cuotas;
        }
        public static void GetMessage(string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "", buttons, icon);
        }
        static DbEntityValidationResult GetValidationResult(DbEntityValidationException ex)
        {
            DbEntityValidationResult validationResult = ex.EntityValidationErrors.First();
            return validationResult;

        }
        static ICollection<DbValidationError> GetValidationErrors(DbEntityValidationException ex)
        {
            DbEntityValidationResult validationResult = GetValidationResult(ex);
            ICollection<DbValidationError> validations = validationResult.ValidationErrors.ToList();
            return validations;
        }
        public static string GetMessageError(DbEntityValidationException ex)
        {
            ICollection<DbValidationError> validationErrors = GetValidationErrors(ex);
            string message = "";
            foreach (DbValidationError error in validationErrors)
            {
                message = message + "Propiedad: " + error.PropertyName + Environment.NewLine + error.ErrorMessage + Environment.NewLine;
            }
            return message;
        }
        public static double CalcularCuotas(double monto, double interes, double tiempo)
        {
            double numerador = monto * interes;
            double denominador = 1 - Math.Pow(1 / (1 + interes), tiempo);
            double cuota = numerador / denominador;
            return Math.Round(cuota, 2);
        }
        public static void Cmb(ComboBox cmb, object lst)
        {
            string[] arr = { "Id", "Nombre" };
            cmb.DataSource = lst;
            cmb.ValueMember = arr.GetValue(0).ToString();
            cmb.DisplayMember = arr.GetValue(1).ToString();
            cmb.SelectedIndex = -1;
        }
        public static int CalcularEdad(DateTime fecha)
        {

            int edad = (DateTime.Now - fecha).Days / 365;
            return edad;
        }
        public static string Encriptar(string password)
        {
            byte[] encryted = Encoding.Unicode.GetBytes(password);
            string result = Convert.ToBase64String(encryted);
            return result;
        }
        public static Type  CrearInstancia(string fullName)
        {
            try
            {
                Assembly asm = Assembly.GetEntryAssembly();
                string nombre = asm.GetName().Name;
                Type type = asm.GetType( fullName );
                if (type != null)
                {
                    throw new Exception("No se ha creado la instancia");

                }
                return type;
                //var form = Activator.CreateInstance(type);
                //return form;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
