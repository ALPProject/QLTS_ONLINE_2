using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DBConnect;

namespace QuanlyTaiSan.Core.Access
{
    public class SetupStore
    {
        public DataTable Get_Data(int key, int parent, int level,string storename,ref string maloi)
        {
            DBConnect.DBAccess truyvan = new DBAccess();
            DataTable table = new DataTable();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@key", key);
            p[1] = new SqlParameter("@Parent", parent);
            p[2] = new SqlParameter("@Level", level);
            table = truyvan.GetData_withSqlStoreName(p,storename,ref maloi);
            return table;
        }

        //end
    }
}