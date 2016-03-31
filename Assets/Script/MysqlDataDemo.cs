using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Assets.Script;

public class MysqlDataDemo : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 100, 100, 30), "mysql insert"))
        {
            SqlHelper.MySqlExecuteNonQuery("Insert into Employee(Id,Number,EmployeeName,Phone) values(12,12,'曾思信','13543403844')");
            print("插入成功");
        }
        if (GUI.Button(new Rect(0, 150, 260, 30), "mysql delete  EmployeeName='曾思信'"))
        {
            SqlHelper.MysqlExecuteNonQuery("Delete from Employee where EmployeeName='曾思信'");
            print("删除成功");
        }
        if (GUI.Button(new Rect(0, 200, 160, 30), "mysql select look"))
        {
            DataTable tb = SqlHelper.MysqlExecuteDataTable("select *  from Employee where id=12;");
            if (tb.Rows.Count == 0) { Debug.LogError("数据库 没数据"); return; }
            var row_ = tb.Rows[0];
            print(row_["employeeName"].ToString());
        }
    }
}

