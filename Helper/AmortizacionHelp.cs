using Datos;
using Factory;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualBasic;
using SelectPdf;
namespace Helper
{
    public class AmortizacionHelp : Help<AmortizacionDTO>
    {
        public AmortizacionHelp(PrestamoDbContext dbContext)
        {
            context = dbContext;
        }    
        protected override HtmlToPdf HtmlToPdf => throw new NotImplementedException();

        public override IQueryable<AmortizacionDTO> TEntity => context.Amortizacions.
            Include("pagos").
            Include("Telefonos").
            Include("Referencias").
            Include("TipoIdentificaciones").
            Include("Areas").
            Include("Clientes").
            Include("TipoTelefonos").
            Include("Referencias").
            Include("Pestamos").Select(x => new AmortizacionDTO
            {                            
                Id = x.Id,
                Periodo = x.Periodo,
                Referencia = x.Referencia,                
                Fecha = x.Fecha,
                Valor = x.Valor,
                PagoCompleto = x.PagoCompleto,
                PrestamoId = x.PrestamoId,
                Prestamo = new PrestamoDTO
                {

                    Id = x.Prestamo.Id,
                    ClienteId=x.Prestamo.ClienteId,
                    Cliente=new ClienteDTO
                    {
                        Id =x.Prestamo.Cliente.Id,   
                        TipoIdentificacionId = x.Prestamo.Cliente.TipoIdentificacionId,
                        Identificacion=x.Prestamo.Cliente.  Identificacion,
                        Nombre=x.Prestamo.Cliente.Nombre,
                        Apellido=x.Prestamo.Cliente.Apellido,
                        AreaId=x.Prestamo.Cliente.AreaId,
                        Codigo=x.Prestamo.Cliente.Codigo,
                        Direccion=x.Prestamo.Cliente.Direccion,
                        Email=x.Prestamo.Cliente.Email,
                        EmperesaDondeLabora=x.Prestamo.Cliente.EmperesaDondeLabora,
                        FechaExpedicion=x.Prestamo.Cliente.FechaExpedicion,
                        FechaNacimiento=x.Prestamo.Cliente.FechaNacimiento,
                        Area=x.Prestamo.Cliente.Area,
                        Telefonos=x.Prestamo.Cliente.Telefonos.Select(y=>new TelefonoDTO
                        {
                            Id=y.Id,
                            ClienteId=y.ClienteId,
                            NumeroTelefonico=y.NumeroTelefonico,
                            TipoTelefonoId=y.TipoTelefonoId,
                            TipoTelefono=y.TipoTelefono,

                        }).ToList(),
                        Referencias=x.Prestamo.Cliente.Referencias.Select(y=>new ReferenciaDTO
                        {
                            Id =y.Id,
                            Apellido=y.Apellido,
                            Direccion=y.Direccion,
                            ClienteId   =y.ClienteId,
                            Email=y.Email,
                            Identificacion=y.Identificacion,
                                Nombre=y.Nombre,
                                Telefono=y.Telefono,
                                TipoIdentificacion=y.TipoIdentificacion,
                                TipoIdentificacionId    =y.TipoIdentificacionId,
                        }).ToList(),
                    } ,
                    EmpleadoId=x.Prestamo.EmpleadoId,
                    Referencia=x.Prestamo.Referencia,
                    EstadoId=x.Prestamo.EstadoId,
                    Fecha=x.Prestamo.Fecha,
                    FiadorId=x.Prestamo.FiadorId,
                    TipoCobroId=x.Prestamo.TipoCobroId,
                    Monto=x.Prestamo.Monto,
                    Interes=x.Prestamo.Interes,
                    Tiempo=x.Prestamo.Tiempo,
                    Observacion=x.Prestamo.Observacion,
                    
                },
                Pagos = x.Pagos.Select(y => new PagoDTO
                {
                    Id = y.Id,
                    AmortizacionId = y.AmortizacionId,
                    Fecha = y.Fecha,
                    FormaPagoId = y.FormaPagoId,
                    TipoPagoId = y.TipoPagoId,
                    ValorPagar = y.ValorPagar,
                    Referencia = y.Referencia,
                    Observaciones = y.Observaciones,
                    EmpleadoId = y.EmpleadoId,
                    
                }).ToList()
            });


        public List<AmortizacionCapitalDTO> GetAmortizacionCapitals(double InterestRate,double LoanTerm,double LoanAmount ,out double Fee)
        {
            Fee = Math.Round(Financial.Pmt(InterestRate, LoanTerm, -1 * LoanAmount), 2);
            List<AmortizacionCapitalDTO> amortizacionCapitals = new List<AmortizacionCapitalDTO>();
            double InitialBalance = LoanAmount;
            for (int periodo = 1; periodo <= LoanTerm; periodo++)
            {
                double interest = Math.Round(Financial.IPmt(InterestRate, periodo, LoanTerm, -1 * LoanAmount, 2));
                double capital = Math.Round(Financial.PPmt(InterestRate, periodo, LoanTerm, -1 * LoanAmount), 2);
                double Balance = Math.Round(InitialBalance - capital, 2);
                AmortizacionCapitalDTO amortizacionCapital = new AmortizacionCapitalDTO
                {
                    Periodo = periodo,
                    Capital = decimal.Parse(capital.ToString()),
                    Interes = decimal.Parse(interest.ToString()),
                    Saldo = decimal.Parse(Balance.ToString()),
                };
                amortizacionCapitals.Add(amortizacionCapital);
                InitialBalance = Balance;
            }
            return amortizacionCapitals;
        }
        public List<AmortizacionDTO> GetAmortizacions(int tipo, double LoanTerm, DateTime Fecha, double Total)
        {
            List<AmortizacionDTO> amortizacions = new List<AmortizacionDTO>();
            double cantidad = tipo == 30 || tipo == 1 ? (LoanTerm * tipo) : double.Parse(tipo.ToString()) == 0 ? 1 :
                        (double)(LoanTerm * 30 / tipo);
            double varlorTipo = Total / cantidad;
            for (int i = 1; i <= cantidad; i++)
            {
                Random random = new Random();
                int next = random.Next();
                DateTime date;
                AmortizacionDTO amortizacionDTO = new AmortizacionDTO();
                if (tipo == 30 || tipo == 1)
                {
                    date = tipo == 30 ? Fecha.AddDays(i) : Fecha.AddMonths(i);
                    amortizacionDTO.Referencia = date.ToOADate().ToString() + next.ToString();
                   amortizacionDTO.Periodo= i;
                    amortizacionDTO.Fecha=date;
                    amortizacionDTO.Valor=decimal .Parse( Math.Round(varlorTipo, 2).ToString());
                }
                else
                {
                    date = Fecha.AddDays(i * 15);
                    amortizacionDTO.Referencia = date.ToOADate().ToString() + next.ToString();
                    amortizacionDTO.Periodo = i;
                    amortizacionDTO.Fecha= date;
                    amortizacionDTO.Valor =decimal.Parse( Math.Round(varlorTipo, 2).ToString());
                }
               amortizacions.Add(amortizacionDTO);
            }       
            return amortizacions;
        }
  
        public override void Eliminar(int id)
        {
            var cuota = context.Amortizacions.Find(id);
            context.Amortizacions.Remove(cuota);
            context.SaveChanges();
        }
        public override void Guardar(AmortizacionDTO Entity)
        {
            Amortizacion cuota = new Amortizacion
            {
                Periodo=Entity.Periodo,
               Referencia= Entity.Referencia,
                Fecha = Entity.Fecha,
                Valor = Entity.Valor ,               
                PagoCompleto = Entity.PagoCompleto,
                PrestamoId = Entity.PrestamoId
            };
            context.Amortizacions.Add(cuota);
            context.SaveChanges();
        }
        public void PagarCuota(int id, decimal valorPagado)
        {
            Amortizacion cuota = context.Amortizacions.Find(id);
            if (cuota == null)
            {
                return;
            }
            if (valorPagado>= cuota.Valor)
            {
                cuota.PagoCompleto = true;
                context.SaveChanges();
            }
            
            
        }
        public override void Actualizar(int id, AmortizacionDTO Entity)
        {
            Amortizacion cuota = context.Amortizacions.Find(id);
            cuota.Periodo = Entity.Periodo;
            cuota.Fecha = Entity.Fecha;
            cuota.Valor = Entity.Valor;
            cuota.Referencia = Entity.Referencia;
            cuota.PagoCompleto = Entity.PagoCompleto;
            cuota.PrestamoId = Entity.PrestamoId;
            context.SaveChanges();
        }

        public override byte[] ExportarPdf(Controller controller, string viewName, object model, PdfPageSize pageSize, PdfPageOrientation pdfOrientation, int webPageWidth)
        {
            throw new NotImplementedException();
        }
    }
}
