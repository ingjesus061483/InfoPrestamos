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
    public class ClienteHelp : Help
    {
        public  IQueryable<ClienteDTO> Clientes
        {
            get
            {
               return  context.Clientes.Include("TipoIdentificacion").Include ("Telefono").OrderBy(x => x.Nombre ). Select(x=>new ClienteDTO{
                    Id=x.Id ,
                    Identificacion =x.Identificacion ,
                    Nombre=x.Nombre ,
                    Apellido=x.Apellido ,
                    Direccion =x.Direccion ,
                    FechaNacimiento=x.FechaNacimiento ,
                    Email =x. Email,
                    Telefonos=x .Telefonos ,
                   TipoIdentificacion =x.TipoIdentificacion ,
                    TipoIdentificacionId =x.TipoIdentificacionId 
                });
               
            }
        }
        public ClienteHelp(PrestamoDbContext dbContext)
        {
            context =dbContext;
        }
        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            var cliente = context.Clientes .Find (id);
            cliente.Identificacion = collection["Identificacion"].ToString();
            cliente.Nombre = collection["Nombre"].ToString();
            cliente.Apellido = collection["Apellido"].ToString();
            cliente.Direccion = collection["Direccion"].ToString();           
            cliente.Email = collection["Email"].ToString();
            cliente.FechaNacimiento = (DateTime)collection["FechaNacimiento"];            
            cliente.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            context.SaveChanges();
        }

        public override void Eliminar(int id)
        {
            var cliente = context.Clientes.Find(id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();    
        }

        public override void Guardar(Dictionary<string, object> collection)
        {
            
            Cliente cliente = new Cliente
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido = collection["Apellido"].ToString(),
                Direccion = collection["Direccion"].ToString(),                
                Email = collection["Email"].ToString(),
                FechaNacimiento = (DateTime)collection["FechaNacimiento"],               
                TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString()),
            };
            context.Clientes.Add(cliente);
            context.SaveChanges();

        }

        public override void Guardar(FormCollection collection)
        {
            Cliente cliente = new Cliente
            {
                Identificacion = collection["Identificacion"].ToString(),
                Nombre = collection["Nombre"].ToString(),
                Apellido = collection["Apellido"].ToString(),
                Direccion = collection["Direccion"].ToString(),                
                Email = collection["Email"].ToString(),
                FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"].ToString ()),
                TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString()),
            };
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            var cliente = context.Clientes.Find(id);
            cliente.Identificacion = collection["Identificacion"].ToString();
            cliente.Nombre = collection["Nombre"].ToString();
            cliente.Apellido = collection["Apellido"].ToString();
            cliente.Direccion = collection["Direccion"].ToString();            
            cliente.Email = collection["Email"].ToString();
            cliente.FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"].ToString ());
            cliente.TipoIdentificacionId = int.Parse(collection["TipoIdentificacionId"].ToString());
            context.SaveChanges();
        }
    }
}
