using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampuStore
{
    public class Result
    {
        public DataTable Data { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }


        internal class DbHelper
        {
            public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-32UIRU3;Initial Catalog=CampuStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            public static Result GetQueryData(string query)
            {
                var result = new Result();
                try
                {
                    con.Open();



                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    result.Data = dt;

                }
                catch (Exception e)
                {
                    result.HasError = true;
                    result.Message = e.Message;
                }

                finally
                {
                    con.Close();
                }

                return result;

            }

            public static Result ExecuteNonResultQuery(string query)
            {
                var result = new Result();
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();


                }

                catch (Exception e)
                {
                    result.HasError = true;
                    result.Message = e.Message;
                }

                return result;
            }
        }
    }
}
