using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanlyTaiSan
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //QuanlyTaiSan.Core.Access.SetupValue _v = new Core.Access.SetupValue();
                //bool t = _v.StartupRun();
                //if(t==true)
                //{
                //}else
                //{
                //}
                //QuanlyTaiSan.Core.Access.SetupConfig _v = new Core.Access.SetupConfig();
                //_v.isConfig();
                //int m = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_COMPANY.Count;
                //bool v = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_COMPANY;
                //int t = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PERSIONAL.Count;
                //bool u = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PERSIONAL;
            }
        }
    }
}