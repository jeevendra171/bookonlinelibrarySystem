using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineBookStore.Models
{
    
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        public Functions() 
        {
            ConStr = ConfigurationManager.ConnectionStrings["BookShopASPDB"].ConnectionString;
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }
        public DataTable GetData(string Query)
        {
            dt= new DataTable();
            sda=new SqlDataAdapter(Query,ConStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string Query)
        {
            int cnt = 0;
            if(Con.State==ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            cnt=cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }

}