using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    { 

        static void Main(string[] args)
        {
            GetUserInf db = new GetUserInf();
            string Line;
            string[] strArr;
            char[] charArr = new char[] { ' ' };
            try
            {
                FileStream fs = new FileStream("log.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                while (sr.EndOfStream != true)  // framework 2.0
                {
                    Line = sr.ReadLine();
                    strArr = Line.Split(charArr);
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        //MessageBox.Show(strArr[i].Trim());
                        db.SQLInsert("gda_city", "name", "'" + strArr[i].Trim() + "'");
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            

        }
    }
}
