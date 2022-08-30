using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DBConnect;

namespace QuanlyTaiSan.Core.Access
{
     
    public class SetupValue
    {
        string _config = null;
        private string read_config(ref string e_code)
        {
            string a = "";
            try
            {
                string b = @"/web.config";
                Configuration config = WebConfigurationManager.OpenWebConfiguration(b);
                var cms = WebConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
                a = cms.ToString();
                _config = a;
                e_code = "true";
                return a;
            }
            catch (Exception ep)
            {
                e_code = ep.Message;
                return a;
            }
        }
        //end

    }
}