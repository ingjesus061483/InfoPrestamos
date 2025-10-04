using Factory;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
namespace Helper
{
   public abstract class Utilities
    {
 
        public static  void MostrarControl(Panel pnl, Control control)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(control);
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
