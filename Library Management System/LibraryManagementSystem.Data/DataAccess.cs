using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem.Data
{

    public static class DataAccess
    {
        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private static SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

         static DataAccess()
        {
            //this.sqcon = new SqlConnection(WFAExer.Properties.Settings.Default.conStr);
            Sqlcon = new SqlConnection(@"Data Source=DESKTOP-RTMHU7G\SQLEXPRESS;Initial Catalog=librarydb;Persist Security Info=True;User ID=sa;Password=99466");
            Sqlcon.Open();
        }

        private static void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }
        public static DataTable ExecuteQueryTable(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds.Tables[0] ;
        }

        public static int ExecuteDmlQuery(string sql)
        {
            QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}