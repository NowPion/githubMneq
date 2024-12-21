using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//访问数据库的类
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CCTV20230901
{
    class Program
    {
        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}", dataRecord[0]));
        }


        static void Main(string[] args)
        {
            //string ConnStr = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
            //// string ConnStr = "Data Source=localhost;Initial Catalog=orders;Integrated Security=True";
            //SqlConnection conn = null;
            //bool isShow = false;
            //try
            //{

            //    conn = new SqlConnection(ConnStr);
            //    conn.Open();
            //    if (conn.State == ConnectionState.Open)
            //    {

            //        Console.WriteLine("orders Server is Yes");
            //        isShow = true;
            //        //string Tsql = "insert into Star (starId,starName) values " +
            //        //"(" + "'" + 202215 + "'," + "'" + "猴子" + "')";
            //        string Tsql = "Select COUNT(*) from [user] where name='admin' and passdword='123456'";
            //        string poit = "insert into [user] values('utyt','123')";
            //        SqlCommand command = new SqlCommand(Tsql, conn);
            //        SqlDataReader reader = command.ExecuteReader();
            //        SqlCommand itmt = new SqlCommand(poit, conn);
            //        itmt.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            ReadSingleRow((IDataRecord)reader);
            //        }

            //    }

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if(isShow)
            //    {
            //        conn.Close();
            //        Console.WriteLine("关闭");
            //    }
            //    else
            //    {
            //        Console.WriteLine("异常");
            //    }
            //}
            //Console.ReadLine();
            //string ConnStr = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
            //string Tsql1 = "delete from star where starId=@starId";
            //string Tsql2 = "delete from film where starId=@starId";
            //SqlConnection conn = new SqlConnection(ConnStr); ;
            //SqlTransaction tran = null;

            ////Connection
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    tran = conn.BeginTransaction();
            //    cmd.Transaction = tran;
            //    cmd.Connection = conn;

            //    cmd.CommandText = Tsql1;
            //    cmd.Parameters.AddWithValue("@starId","000003");
            //    cmd.ExecuteNonQuery();


            //    cmd.CommandText = Tsql2;
            //    cmd.ExecuteNonQuery();

            //    tran.Commit();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    tran.Rollback();
            //}
            //finally
            //{
            //    conn?.Close();

            //}
            // Console.WriteLine(ConnStr);
            //string Tsql = "insert into Star (starId) values(@starId)";
            //string Tsql = "procWithInputAndOutputPara";
            //Tsql = "select starId,starName,sex from star";
            //using (SqlConnection conn = new SqlConnection(ConnStr))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(Tsql, conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("StarId：" + reader["starId"] + " ,StarName：" + reader["starName"]);
            //    }
            //}
            //using (SqlConnection conn = new SqlConnection(ConnStr))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(Tsql, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;


            //    SqlParameter parameter = new SqlParameter("@starName", SqlDbType.VarChar, 20);
            //    parameter.Direction = ParameterDirection.Input;
            //    parameter.Value = "成龙";
            //    cmd.Parameters.Add(parameter);


            //    /* parameter = new SqlParameter("@filmName", SqlDbType.VarChar, 20);
            //       parameter.Direction = ParameterDirection.Output;
            //       cmd.Parameters.Add(parameter);

            //       parameter = new SqlParameter("@count",SqlDbType.Int);
            //       parameter.Direction = ParameterDirection.ReturnValue;
            //       cmd.Parameters.Add(parameter);
            //    */

            //    parameter = new SqlParameter("@income", SqlDbType.Int);
            //    parameter.Direction = ParameterDirection.Output;
            //    cmd.Parameters.Add(parameter);

            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("最高票房: " + cmd.Parameters["@income"].Value + "亿");

            //}
            int currentPage = 2;
            int pageSize = 1;
            DataTable tab = getRecordByPage(currentPage, pageSize);
            Console.WriteLine("编号\t姓名\t性别");
            foreach (DataRow row in tab.Rows)
            {
                foreach (DataColumn c in tab.Columns)
                {
                    Console.Write($"{row[c]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static DataTable getRecordByPage(int currentPage, int pageSize)
        {
            string conString = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
            string sql = "select starId,starName,sex from star";
            int beginIndex = (currentPage - 1) * pageSize;
            try
            {
                SqlConnection con = new SqlConnection(conString);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(ds, beginIndex, pageSize, "star");
                return ds.Tables["star"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误信息：" + ex.Message);
                return null;
            }
        }
    }
}
