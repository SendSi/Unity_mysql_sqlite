using UnityEngine;
using System.Collections;
using System.Data;
using Assets.Script;
using Mono.Data.Sqlite;
using System.Reflection;


public class SqliteDataDemo : MonoBehaviour
{
    void OnGUI()
    {
        if (GUILayout.Button("sqlite  select name"))
        {
            //string sApplicationPath = Assembly.GetExecutingAssembly().Location;//E:\DataSQLite\Library\ScriptAssemblies\Assembly-CSharp.dll
            DataTable table = SqlHelper.SqliteExecuteDataTable("Select * from Employee");
            print("数据库路径:" + Application.dataPath + "/Plugins/LuckyTimeDB.db");
            DataRow row = table.Rows[0];
            string Name = row[2].ToString();
            print("从数据中:--sqlite--" + Name);
        }
    }
}
