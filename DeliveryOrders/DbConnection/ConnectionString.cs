using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrders.DbConnection
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.\SQLEXPRESS;Database=EffectiveMobileDelivery;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
