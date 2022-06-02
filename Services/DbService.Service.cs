using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace myapp.Service
{
    public class DbService
    {
        private string ConnectionString {get;set;}
        public string ExecuteSQL(string query)
        {
            SqlConnection conn = new SqlConnection();
        }
        
    }
}