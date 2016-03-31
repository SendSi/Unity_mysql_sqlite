using UnityEngine;
using System.Collections;
//导入Sqlite数据集，也就是Plugins文件夹下的那个dll文件
using Mono.Data.Sqlite;
using System;
//数据集 是formwork2.0 用vs开发要自己引用框架中的System.Data
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace Assets.Script
{
    public class SqlHelper
    {    
        public static string connectionStringMysql = @"Server=127.0.0.1;Database=mian;User=root;Password=lnwy;";


        /// <summary>
        /// SqliteExecuteDataTable
        /// </summary>
        public static DataTable SqliteExecuteDataTable(string Sqlite, params SqliteParameter[] parameters)
        {
            using (SqliteConnection conn = new SqliteConnection("data source="+Application.dataPath + "/Plugins/LuckyTimeDB.db;Version=3"))
            {
                Debug.Log(Application.dataPath + "/Plugins/LuckyTimeDB.db;Version=3");
                conn.Open();
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Sqlite;
                    cmd.Parameters.AddRange(parameters);
                    DataSet dataset = new DataSet();
                    SqliteDataAdapter adapter = new SqliteDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }

        public static DataTable MysqlExecuteDataTable(string Sqlite, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionStringMysql))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Sqlite;
                    cmd.Parameters.AddRange(parameters);
                    DataSet dataset = new DataSet();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }



        public static void ExecuteNonQuery()
        {

        }


        /// <summary>
        /// 空数据的检测Form
        /// </summary>
        public static object FromDbValue(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 插入空数据
        /// </summary>
        public static object ToDbValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        public static object ExecuteScalar(string sql, params SqliteParameter[] parameters)
        {
            using (SqliteConnection conn = new SqliteConnection("data source=" + Application.dataPath + "/Plugins/LuckyTimeDB.db;Version=3"))
            {
                conn.Open();
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static int ExecuteNonQuery(string sql, params SqliteParameter[] parameters)
        {
            using (SqliteConnection conn = new SqliteConnection("data source=" + Application.dataPath + "/Plugins/LuckyTimeDB.db;Version=3"))
            {
                conn.Open();
                using (SqliteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int MysqlExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionStringMysql))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int MySqlExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionStringMysql))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
