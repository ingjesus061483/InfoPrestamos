using Datos;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace Helper
{
    public class TipoIdentificacionHelp:Help<TipoIdentificacion>
    {
        public List<SelectListItem> listItems
        {
            get
            {
                List<SelectListItem> result = new List<SelectListItem>();
                try
                {
                    foreach (TipoIdentificacion tipoIdentificacion in TEntity.ToList())
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
        }
        public override IQueryable<TipoIdentificacion> TEntity => context.TipoIdentificacions.AsQueryable();
        public TipoIdentificacionHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        } 
        public override void Eliminar(int id)
        {
            throw new NotImplementedException();
        }       
        public override void Guardar(TipoIdentificacion Entity)
        {
            throw new NotImplementedException();
        }
        public override void Actualizar(int id, TipoIdentificacion Entity)
        {
            throw new NotImplementedException();
        }
    }
}
