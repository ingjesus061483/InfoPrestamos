using Datos;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Helper
{
    public class TipoIdentificacionHelp:Help
    {
        public  IQueryable<TipoIdentificacion> TipoIdentificacions
        {
            get
            {
                return context.TipoIdentificacions.AsQueryable();
            }
        }
        public TipoIdentificacionHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }

        public List<SelectListItem> GetSelectList()
        {
            List<TipoIdentificacion> tipoIdentificacions = TipoIdentificacions.ToList();
            List<SelectListItem> result = new List<SelectListItem>();
            try
            {
                foreach (TipoIdentificacion tipoIdentificacion in tipoIdentificacions)
                {
                    SelectListItem item = new SelectListItem
                    {
                        Text = tipoIdentificacion.Nombre,
                        Value = tipoIdentificacion.Id.ToString(),
                    };
                    result.Add(item);
                }
            }
            catch
            {
                result = new List<SelectListItem>();
            }

            return result;
        }
        public override void Actualizar(int id, Dictionary<string, object> values)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(Dictionary<string, object> values)
        {
            throw new NotImplementedException();
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
