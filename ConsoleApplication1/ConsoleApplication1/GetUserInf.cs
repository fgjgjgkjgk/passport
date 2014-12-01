using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


namespace ConsoleApplication1
{
    public class GetUserInf
    {


        private string conectString = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=D:\Документы\git\migration\MvcApplication1\App_Data\aspnet-MvcApplication1-20141021183026.mdf;Initial Catalog=aspnet-MvcApplication1-20141021183026;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        private List<String> queri = new List<String>();



        public GetUserInf() { 
              
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