using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MD_LOGIN.CONEXION
{
     class CONEXIONMAESTRA
    {
        // public static string conexion = @"Data Source = DESKTOP-N2AETTM\SQLEXPRESS; Initial Catalog = MDPV; Integrated Securuty=True";
        public static string conexion = Convert.ToString(CONEXION.Desencryptacion.checkServer());
    }
}
