using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace MvcApplication1.Models.MyModel
{
    public class GetUserInf
    {

        private Entities5 db_Kabinet = new Entities5();
        private string conectString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-MvcApplication1-20141021183026;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnet-MvcApplication1-20141021183026.mdf";
        private List<String> queri = new List<String>();

        private int UserId = WebSecurity.CurrentUserId;

        public GetUserInf() { 
              
        }

        public Array Getuser() {

            var all = (from u in db_Kabinet.UserKabinet where u.UserId == UserId select u).ToArray();

            return all;
           
        }

        public List<String> SQLSelect(String colum, String table) {

            try
            {
                SqlConnection conn = new SqlConnection(conectString);

                try
                {
                    //пробуем подключится
                    conn.Open();
                }
                catch (SqlException se)
                {

                }

                SqlCommand cmd = new SqlCommand("SELECT " + colum + " FROM " + table, conn);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    for (int i = 0; i <= dr.FieldCount; i++)
                    {
                        /*метод GetValue() класса SqlDataReader позволяет получить значение столбца
                                                по номеру, который передается в качестве параметра, данному методу
                                                и озночает номер столбца в таблице(начинается с 0)
                                                */

                        queri.Add(dr.GetValue(i++).ToString());

                    }
                }
                conn.Close();
                conn.Dispose();

                return queri;

            }
            catch (Exception ex)
            {
                return null;
            }
         
        }

        public void SQLInsert(String TableName, String ColumnName, String Values) {

            try
            {
                SqlConnection conn = new SqlConnection(conectString);

                try
                {
                    //пробуем подключится
                    conn.Open();
                }
                catch (SqlException se)
                {

                }

                SqlCommand cmd = new SqlCommand("INSERT INTO " + TableName + " (" + ColumnName + ") VALUES ( " + Values + " );", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();

            }
            catch (Exception ex)
            {

            }
        }
    }
}