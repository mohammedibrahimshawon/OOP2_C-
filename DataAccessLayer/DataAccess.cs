using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManagementSystem.DataAccessLayer
{ public static class DataAccess
    {
        private static string connectionString = @"'DESKTOP-95T2N1H\SQLEXPRESS']/Database[@Name = 'SoccerManagementSystem']/Data";
        private static string _connectionString;
       // Table[@Name = 'CoachInstruction' and @Schema = 'dbo']

        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static int ExecuteQuery1(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        } 
    //class DataAccess : IDisposable
    //{
    //    protected SqlConnection connection;
    //    protected SqlCommand command;


        //public DataAccess()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SoccerManagementSystem"].ConnectionString);
        //    connection.Open();

        //}
        //public SqlDataReader GetData(string sql)
        //{
        //    command = new SqlCommand(sql, connection);
        //    return command.ExecuteReader();

        //}
        //public int ExecuteQuery(string sql)
        //{
        //    command = new SqlCommand(sql, connection);
        //    return command.ExecuteNonQuery();

        //}
        //public void Dispose()
        //{
        //    connection.Close();
        //}

    }
}

