using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanlyTaiSan.GUI
{
    public partial class KhoHC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RunFirst();
            }
        }

        protected void ASPxGridView1_Init(object sender, EventArgs e)
        {
            //QuanlyTaiSan.Core.Services.StoreManagement _s = new Core.Services.StoreManagement();
            //string err = "";
            //DataTable table;
            //table = _s.Get_AllItem(1, ref err);
            ////Session["Table"] = table;
            //ASPxGridView1.DataSource = table;
            //ASPxGridView1.DataBind();
        }


        public void RunFirst()
        {
            dropThongtinNhap.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SOURCE;
            dropThongtinNhap.TextField = "TenDanhMuc";
            dropThongtinNhap.ValueField = "ID";
            dropThongtinNhap.DataBind();
            dropThongtinNhap.SelectedIndex = 0;

            dropcongty.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_COMPANY;
            dropcongty.TextField = "TenDanhMuc";
            dropcongty.ValueField = "ID";
            dropcongty.DataBind();
            dropcongty.SelectedIndex = 0;

            droploaits_hc.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_CATEGORY;
            droploaits_hc.TextField = "TenDanhMuc";
            droploaits_hc.ValueField = "ID";
            droploaits_hc.DataBind();
            droploaits_hc.SelectedIndex = 0;

            isCongty.DataSource= QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_COMPANY;
            isCongty.TextField = "TenDanhMuc";
            isCongty.ValueField = "ID";
            isCongty.DataBind();
            isCongty.SelectedIndex = 0;

            isNguoidung.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PERSIONAL;
            isNguoidung.TextField = "TenDanhMuc";
            isNguoidung.ValueField = "ID";
            isNguoidung.DataBind();
            isNguoidung.SelectedIndex = 0;


            isVitri.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LOCATION;
            isVitri.TextField = "TenDanhMuc";
            isVitri.ValueField = "ID";
            isVitri.DataBind();
            isVitri.SelectedIndex = 0;

            dropNhanhieu.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_BRAND;
            dropNhanhieu.TextField = "TenDanhMuc";
            dropNhanhieu.ValueField = "ID";
            dropNhanhieu.DataBind();
            dropNhanhieu.SelectedIndex = 0;

            dropQuycach.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SPECIFICATION;
            dropQuycach.TextField = "TenDanhMuc";
            dropQuycach.ValueField = "ID";
            dropQuycach.DataBind();
            dropQuycach.SelectedIndex = 0;

            dropDonvicungcap.DataSource = QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PROVIDER;
            dropDonvicungcap.TextField = "TenDanhMuc";
            dropDonvicungcap.ValueField = "ID";
            dropDonvicungcap.DataBind();
            dropDonvicungcap.SelectedIndex = 0;
            //end
        }



        protected void ASPxGridView1_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxGridView1_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void droploaits_hc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //QuanlyTaiSan.Core.Access.SetupValue _v = new Core.Access.SetupValue();
            //string v = droploaits_hc.SelectedIndex.ToString();
            //int t = 0;int.TryParse(droploaits_hc.SelectedItem.Value.ToString(),out t);
            //drop_chitiet_tshc.DataSource= _v.Load_child(t);
            //drop_chitiet_tshc.TextField = "CataNames";
            //drop_chitiet_tshc.ValueField = "ID";
            //drop_chitiet_tshc.DataBind();
            //drop_chitiet_tshc.SelectedIndex = 0;

        }


        //end
    }
}