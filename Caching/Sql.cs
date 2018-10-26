using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Caching
{
    class Sql : IRepository
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = @"Data Source=TAVDESK026;Initial Catalog=ProductDatabase;User Id=sa;Password=test123!@#";
            con = new SqlConnection(constr);

        }
        public List<Product> GetAll()
        {
            connection();
            List<Product> productList = new List<Product>();
            string query = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(query, con)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                productList.Add(
                    new Product
                    {
                        id = Convert.ToInt32(dr["Id"]),
                        product = Convert.ToString(dr["Name"]),
                        
                    }
                );

            }
            return productList;
        }

        public Product GetById(int id)
        {
            connection();
            List<Product> productList = new List<Product>();
            string query = "SELECT * FROM Product where Id=" + id;
            SqlCommand command = new SqlCommand(query, con)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                productList.Add(
                    new Product
                    {
                        id = Convert.ToInt32(dr["Id"]),
                        product = Convert.ToString(dr["Name"]),
                       
                    }
                );

            }
            return productList[0];
        }
    }
}
