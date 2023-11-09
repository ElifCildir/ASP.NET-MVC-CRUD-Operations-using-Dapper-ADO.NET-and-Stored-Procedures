using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace saloonmvcdapper.Models
{
    public class DP
    {
        public static string connectionString = @"Server=.;Database=BeautyCenter; Integrated Security=true;";

        public static void ExecuteReturn(string procname, DynamicParameters param = null)
        {
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(procname, param, commandType: System.Data.CommandType.StoredProcedure);

            }



        }


        public static IEnumerable<T>List<T> (string procname,DynamicParameters param=null)
        {
            using (SqlConnection db= new SqlConnection(connectionString))
            {
                db.Open();
                return db.Query<T>(procname, param, commandType: System.Data.CommandType.StoredProcedure);

            }



        }




    }
}