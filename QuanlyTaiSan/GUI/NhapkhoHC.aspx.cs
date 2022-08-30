using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanlyTaiSan.GUI
{
    public partial class NhapkhoHC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Run_NhapKhoHC();
            }
        }

        private void Run_NhapKhoHC()
        {

        }

        protected void ASPxGridView1_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxGridView1_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            checkrow();
            

        }

        public int checkrow()
        {
            int selectedRowsOnPage = 0;
            foreach (var key in ASPxGridView1.GetCurrentPageRowValues("ID"))
            {
                if (ASPxGridView1.Selection.IsRowSelectedByKey(key))
                {
                    selectedRowsOnPage++;
                    var test = ASPxGridView1.GetSelectedFieldValues("ID");
                    string t = test[selectedRowsOnPage-1].ToString();
                }

            }
            return ASPxGridView1.Selection.FilteredCount - selectedRowsOnPage;
        }


        protected void ASPxGridView1_Init(object sender, EventArgs e)
        {

            //QuanlyTaiSan.Core.Services.StoreManagement _s = new Core.Services.StoreManagement();
            //string err = "";
            //DataTable table;
            //table = _s.Get_Companies(1, 1, 1, ref err);
            ////Session["Table"] = table;
            //ASPxGridView1.DataSource = table;
            //ASPxGridView1.DataBind();
        }
        //public List<Companies> GetCurrentPageRowValues(params string[] fieldNames)
        //{

        //}
        //end
    }

   
        

    public class Companies
    {
        public string ID { get; set; }
        public string ComCode { get; set; }
        public string ComNames { get; set; }
    }
}