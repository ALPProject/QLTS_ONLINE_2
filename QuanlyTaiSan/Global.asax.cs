using System;
using System.Web;

namespace QuanlyTaiSan {
    public class Global_asax : System.Web.HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
            if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.isOpens==false)
            {
                QuanlyTaiSan.Core.Access.SetupConfig _v = new Core.Access.SetupConfig();
                _v.isConfig();
            }
        }

        void Application_End(object sender, EventArgs e) {
            // Code that runs on application shutdown
        }
    
        void Application_Error(object sender, EventArgs e) {
            // Code that runs when an unhandled error occurs
        }
    
        void Session_Start(object sender, EventArgs e) {
            Session["Full_Name"] = null;
            Session["Login_ID"] = null;
            Session["Pemit_ID"] = null;
            Session["Select_ID"] = null;
        }
    
        void Session_End(object sender, EventArgs e) {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
            HttpContext.Current.Response.Redirect("~/Trangchu.aspx");
        }
    }
}