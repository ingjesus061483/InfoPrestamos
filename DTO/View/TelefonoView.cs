using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.View
{
    public class TelefonoView
    {
        public int Id { get; set; }
        public string NumeroTelefonico { get; set; }        
        public int ClienteId { get; set; }      
        public int TipoTelefonoId { get; set; }
        
        public string  TipoTelefono { get; set; }
    }
}
