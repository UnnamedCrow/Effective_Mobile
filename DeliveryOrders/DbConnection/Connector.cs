using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOrders.DbConnection
{
    internal class Connector
    {
        private SqlConnection connection;
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                connection = new SqlConnection(ConnectionString.MsSqlConnection);
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }
    }
}
