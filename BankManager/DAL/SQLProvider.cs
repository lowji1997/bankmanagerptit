using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BankManager.DAL
{
    //kết nối database
    public class SQLProvider
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["Bank"].ConnectionString;
        // Lấy 1 bảng dữ liệu
        public static DataTable Query(string query, CommandType commandType = CommandType.Text, Dictionary<string, object> paramters = null)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = commandType;

                    if (paramters != null)
                        foreach (var item in paramters)
                            cmd.Parameters.AddWithValue(item.Key, item.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                }

                return null;
            }
        }
        // Lấy 1 dòng dữ liệu
        public static DataRow Single(string query, CommandType commandType = CommandType.Text, Dictionary<string, object> paramters = null)
        {
            DataTable dt = Query(query, commandType, paramters);
            if (dt != null && dt.Rows.Count > 0)
                return dt.Rows[0];

            return null;
        }
        //Thực hiện chức năng thêm xóa sửa.
        public static bool Execute(string query, CommandType commandType = CommandType.Text, Dictionary<string, object> paramters = null)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = commandType;

                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    if (paramters != null)
                        foreach (var item in paramters)
                            cmd.Parameters.AddWithValue(item.Key, item.Value);

                    int effectedRow = cmd.ExecuteNonQuery();
                    if (effectedRow > 0)
                        transaction.Commit();
                    else transaction.Rollback();

                    return effectedRow > 0;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    if (transaction != null)
                        transaction.Rollback();
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                }

                return false;
            }
        }
    }
}
