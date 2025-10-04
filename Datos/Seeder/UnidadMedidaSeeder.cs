using Factory;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seeder
{
    public static  class UnidadMedidaSeeder
    {
        public  static void Run(PrestamoDbContext context)
        {
            UnidadMedida[] unidadMedidas ={
                new UnidadMedida{Nombre="Gramo" },
                new UnidadMedida{Nombre="Litro" },
                new UnidadMedida {Nombre="Unidad" },
            };
           context .UnidadMedidas .AddOrUpdate(z=>z.Nombre, unidadMedidas);

        }
    }
}
