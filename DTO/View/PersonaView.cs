using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.View
{
    public class PersonaView
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string FechaNacimiento { get; set; }
        public string  FechaExpedicion { get; set; }
        public string Telefono { get; set; }
        public List <Telefono> Telefonos { get; set; }
        public string Email { get; set; }       
        public string TipoIdentificacion { get; set; }
        public int TipoIdentificacionId { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string EmperesaDondeLabora { get; set; }
        public string ListaTelefono
        {
            get
            {
                string _tel = "";
                if (Telefonos != null)
                {
                    foreach (Telefono telefono in Telefonos)
                    {
                        _tel = telefono.NumeroTelefonico + "; ";
                    }

                }
                return _tel;
            }
        }
    }
}
