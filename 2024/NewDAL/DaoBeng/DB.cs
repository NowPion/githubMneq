using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDAL.DaoBeng
{
    namespace NewDAL
    {
        /// <summary>
        /// 访问数据库的通用类，具有普遍性
        /// </summary>
        public class DB
        {
            //连接字符串
            private string conString = null;
            private SqlConnection con = null;
            public DB(string _conString)
            {
                conString = _conString;
            }
            public DB()
            {
                conString = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
            }
            /// <summary>
            /// 实行打开连接：c#与数据库服务器
            /// </summary>
            private void Open()
            {
                if (con == null)
                {
                    con = new SqlConnection(conString);
                }
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("数据库连接打开错误信息：" + ex.Message);
                    }
                }
            }
            private void Close()
            {
                //con?.Close();
                if (con == null) return;
                if (con.State != ConnectionState.Closed)
                {
                    try
                    {
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("数据库连接关闭错误信息：" + ex.Message);
                    }
                }
            }
            /// <summary>
            /// 执行：添加、修改、删除、create、drop等写操作
            /// </summary>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数过程</param>
            /// <returns>成功：true；失败：false</returns>
            public bool executeSql(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                try
                {
                    Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = type;
                    if (parameters != null)//添加参数
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("报错原因：" + ex.Message);
                    return false;
                }
                finally
                {
                    Close();
                }
            }
            /// <summary>
            /// 查询：返回SqlDataReader对象
            /// </summary>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数过程</param>
            /// <returns>有数据：数据读取器对象；没有数据：null</returns>
            public SqlDataReader GetReader(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                SqlDataReader reader = null;
                try
                {
                    Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = type;
                    if (parameters != null)//添加参数
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    //CommandBehavior.CloseConnection作用为若关闭读取器，同时关闭数据库与c#连接
                    if (reader != null && reader.HasRows == true)
                    {
                        return reader;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("报错原因：" + ex.Message);
                    return null;
                }
            }
            /// <summary>
            /// 查询：返回DataTable对象
            /// </summary>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数过程</param>
            /// <returns>有数据：数据读取器对象；没有数据：null</returns>
            public DataTable GetDataTable(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                try
                {
                    DataSet ds = new DataSet();
                    con = new SqlConnection(conString);
                    //sql必须为select语句
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    //添加参数
                    adapter.SelectCommand.Parameters.Add(parameters);
                    adapter.Fill(ds, "tab");
                    return ds.Tables["tab"];
                }
                catch (Exception ex)
                {
                    Console.WriteLine("查询错误信息：" + ex.Message);
                    return null;
                }
            }
            /// <summary>
            /// 查询：返回实体类的对象
            /// </summary>
            /// <typeparam name="T">泛型</typeparam>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数过程</param>
            /// <returns>有数据：实体类的对象；否则：null</returns>
            public T GetEntity<T>(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                SqlDataReader reader = GetReader(sql, type, parameters);
                if (reader != null)
                {
                    return DataReaderHelper.ReaderToEntity<T>(reader);//ReaderToEntity普通方法，ReaderToEntity<T>泛型方法

                }
                else
                {
                    return default;//泛型里不能写空转而写default
                }
            }
            /// <summary>
            /// 查询：返回实体类的对象集合
            /// </summary>
            /// <typeparam name="T">泛型</typeparam>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数过程</param>
            /// <returns>有数据：实体类的对象；否则：null</returns>
            public IList<T> GetEntities<T>(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                SqlDataReader reader = GetReader(sql, type, parameters);
                if (reader != null)
                {
                    return DataReaderHelper.ReaderToList<T>(reader);
                }
                else
                {
                    return null;
                }
            }
            /// <summary>
            /// 返回第一行第一列
            /// </summary>
            /// <typeparam name="T">泛型</typeparam>
            /// <param name="sql">要执行的sql命令、存储过程名称</param>
            /// <param name="type">命令对象的类型：简单的sql语句、存储过程</param>
            /// <param name="parameters">参数集合</param>
            /// <returns></returns>
            public object GetScalar(string sql, CommandType type = CommandType.Text, SqlParameter[] parameters = null)
            {
                try
                {
                    Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (parameters != null)
                    {
                        cmd.Parameters.Add(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("统计异常，错误信息为：" + ex.Message);
                    return null;
                }
                finally
                {

                }
            }
        }
    }//说明：DataReaderHelper，需要select语句中的字段列表，字段名与将来指定的类的属性同名
}
