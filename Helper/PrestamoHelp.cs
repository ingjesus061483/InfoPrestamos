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
    public class PrestamoHelp : Help
    {
        CuotaHelp CuotaHelp;
        public PrestamoHelp(PrestamoDbContext dbContext,CuotaHelp cuotaHelp  )
        {
            context = dbContext ;
            CuotaHelp = cuotaHelp ;
        }
        public IQueryable<PrestamoDTO > Prestamos
        {
            get
            {
                return context.Prestamos.Include("Clientes")
                                        .Include("Fiadors")
                                        .Include("Empleadoes").Select(x => new PrestamoDTO
                                        {
                                            Id = x.Id,
                                            Codigo = x.Codigo,
                                            Fecha = x.Fecha,
                                            Monto =  x.Monto,
                                            TipoCobro = x.TipoCobro,
                                            TipoCobroId = x.TipoCobroId,
                                            Tiempo = x.Tiempo,
                                            Interes = x.Interes,
                                            Cliente = x.Cliente,
                                            ClienteId = x.ClienteId,
                                            Empleado = x.Empleado,
                                            EmpleadoId = x.EmpleadoId,
                                            Fiador = x.Fiador,
                                            FiadorId = x.FiadorId,
                                            EsCancelado = x.EsCancelado,
                                            Observacion = x.Observacion,
                                        });
            }
        }
        public override void Actualizar(int id, Dictionary<string, object> collection)
        {
            throw new NotImplementedException();
        }

        public override void Actualizar(int id, FormCollection collection)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(int id)
        {
            Prestamo prestamo = context.Prestamos.Find(id);
            context.Prestamos.Remove(prestamo);
            context.SaveChanges();
        }
        public override void Guardar(Dictionary<string, object> collection)
        {
            int? fiadorId = int.Parse(collection["FiadorId"].ToString());
            if(fiadorId ==0)
            {
                fiadorId = null;
            }
            Prestamo prestamo = new Prestamo
            {
                Codigo =collection ["Codigo"].ToString (),
                Monto =decimal .Parse ( collection [ "Monto" ].ToString ()),
                Tiempo =int.Parse (collection [ "Tiempo"].ToString()),
                Interes =decimal .Parse (collection [ "Interes"].ToString() ),
                Fecha =DateTime .Parse (collection [  "Fecha"].ToString ()),
                Observacion =collection [ "Observacion"].ToString () ,
                EsCancelado =bool .Parse ( collection ["EsCancelado"].ToString ()),
                ClienteId =int.Parse (collection ["ClienteId"].ToString ()),
                TipoCobroId =int . Parse (collection ["TipoCobroId"].ToString ()),
                FiadorId=fiadorId ==0?null:fiadorId ,
                EmpleadoId =int.Parse (collection ["EmpleadoId"].ToString ()),                
            };
            context.Prestamos.Add(prestamo);
            context.SaveChanges();
            var codigo = collection["Codigo"].ToString();
            prestamo = GetPrestamo(codigo);
            var cuotas = (List<Cuota>)collection["cuotas"];
            GuardarCuotasPrestamo(cuotas, prestamo);
        }

        public override void Guardar(FormCollection collection)
        {
            throw new NotImplementedException();
        }

        Prestamo GetPrestamo(string codigo)
        {
            return  context.Prestamos.Where(x => x.Codigo.Contains(codigo))
                                     .FirstOrDefault();
        }
        void GuardarCuotasPrestamo(List <Cuota>cuotas,Prestamo prestamo )
        {
            foreach (Cuota cuota in cuotas)
            {
                Dictionary<string, object> collection = new Dictionary<string, object>
                {
                    {"prestamo",prestamo },
                    {"cuota",cuota }
                };
                CuotaHelp.Guardar(collection);         
            }
        }
    }
}
