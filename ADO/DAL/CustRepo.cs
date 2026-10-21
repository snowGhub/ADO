using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ADO.DAL
{
    public class CustRepo
    {
        string conStr;
        SqlConnection conn;
        SqlDataAdapter? daCustomerGender;

        public CustRepo()
        {
            conStr = @"Server=(localdb)\MSSQLLocalDB;Database=3APEC_1;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=60;";
            conn = new SqlConnection(conStr);
        }

        public DataTable getCustomers()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM myc.Customers", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCustomerNames()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT CustomerID, LName + ' ' + ISNULL(FName, '') AS FullName FROM myc.Customers", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getGenders()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT GenderId, Title FROM myc.Genders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getCustomerByGender(int gender)
        {
            DataTable dt = new DataTable();
            if (daCustomerGender == null)
            {
                configByCusotmerAndGender();
            }

            daCustomerGender?.SelectCommand.Parameters["@GenderId"].Value = gender;
            daCustomerGender?.Fill(dt);
            return dt;
        }

        private void configByCusotmerAndGender()
        {
            SqlCommand cmd = new SqlCommand("select * from myc.Customers where Gender = @GenderId ORDER BY LName, FName", conn);
            cmd.Parameters.Add("@GenderId", SqlDbType.Int);
            daCustomerGender = new SqlDataAdapter(cmd);

        }
    }
}
