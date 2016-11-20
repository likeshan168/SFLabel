using Dapper;
using SFApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SFApp.Bussiness
{
    public class ProductsHelper
    {
        public static readonly ProductsHelper Instance = new ProductsHelper();
        private string connStr;
        private ProductsHelper()
        {
            connStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }

        public IEnumerable<ProductInfo> GetProductInfo(string barCode)
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                return conn.Query<ProductInfo>("select * from ProductInfo where BarCode =@BarCode or JDCode = @BarCode or OldJDCode=@BarCode", new { BarCode = barCode });
            }
        }
    }
}
