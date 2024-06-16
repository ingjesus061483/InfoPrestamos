using Datos;
using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Helper
{
    public class FiadorHelp:Help
    {
        public FiadorHelp (PrestamoDbContext dbContext)
        {
            context = dbContext;
        }
        public IQueryable<FiadorDTO> Fiadors
        {
            get
            {
                return context.Fiadors.Include("TipoIdentificacion").Select(x => new FiadorDTO
                {
                    Id = x.Id,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    EmperesaDondeLabora=x.EmperesaDondeLabora ,
                    FechaNacimiento = x.FechaNacimiento,
                    Email = x.Email,
                    Telefono = x.Telefono,
                    TipoIdentificacion = x.TipoIdentificacion,
                    TipoIdentificacionId = x.TipoIdentificacionId
                });
            }
        }
        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            var Fiador = context.Fiadors.Find(id);
            Fiador.Identificacion = collection["Identificacion"].ToString();
            Fiador.Nombre = collection["Nombre"].ToString();
            Fiador.Apellido = collection["Apellido"].ToString();
            Fiador.Direccion = collection["Direccion"].ToString();
            Fiador.Telefono = collection["Telefono"].ToString();
            Fiador.Email = collection["Email"].ToString();
            Fiador.EmperesaDondeLabora = collection["EmperesaDondeLabora"].ToString();
            Fiador.FechaNacimiento = (DateTime)collection["FechaNacimiento"];
            Fiador.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            context.SaveChanges();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            var Fiador = context.Fiadors.Find(id);
            Fiador.Identificacion = collection["Identificacion"].ToString();
            Fiador.Nombre = collection["Nombre"].ToString();
            Fiador.Apellido = collection["Apellido"].ToString();
            Fiador.Direccion = collection["Direccion"].ToString();
            Fiador.Telefono = collection["Telefono"].ToString();
            Fiador.Email = collection["Email"].ToString();
            Fiador.EmperesaDondeLabora = collection["EmperesaDondeLabora"].ToString();
            Fiador.FechaNacimiento = DateTime.Parse( collection["FechaNacimiento"].ToString ());
            Fiador.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            context.SaveChanges();
        }

        public override void Eliminar(int id)
        {
            var Fiador = context.Fiadors.Find(id);
            context.Fiadors.Remove(Fiador);
            context.SaveChanges();
        }
        public override void Guardar(Dictionary<string, object> collection)
        {

            Fiador Fiador = new Fiador
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido = collection["Apellido"].ToString(),
                Direccion = collection["Direccion"].ToString(),
                Telefono = collection["Telefono"].ToString(),
                Email = collection["Email"].ToString(),
                EmperesaDondeLabora =collection ["EmperesaDondeLabora"].ToString (),
                FechaNacimiento = (DateTime)collection["FechaNacimiento"],
                TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString()),
            };
            context.Fiadors.Add(Fiador);
            context.SaveChanges();
        }

        public override void Guardar(FormCollection collection)
        {
            Fiador Fiador = new Fiador
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido = collection["Apellido"].ToString(),
                Direccion = collection["Direccion"].ToString(),
                Telefono = collection["Telefono"].ToString(),
                Email = collection["Email"].ToString(),
                EmperesaDondeLabora = collection["EmperesaDondeLabora"].ToString(),
                FechaNacimiento =DateTime .Parse( collection["FechaNacimiento"].ToString()),
                TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString()),
            };
            context.Fiadors.Add(Fiador);
            context.SaveChanges();
        }
    }
}
