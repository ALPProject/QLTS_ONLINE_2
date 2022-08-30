using DBConnect;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DBConnect;

namespace QuanlyTaiSan.Core.Access
{
    public class SetupConfig
    {
        string _config = null;
        public SetupConfig()
        {
            _config = null;
        }
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
        public bool isConfig()
        {
            if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.isOpens==false)
            {
                DBConnect.DBAccess _access = new DBAccess();
                string err = "";
                _access.Set_ConnectString_SQL(read_config(ref err));
                string t= DBInit.SQLStringCon;
                QuanlyTaiSan.Core.StaticValue.Base_RunClass.isOpens = true;
                Load_Config(1);
                Load_Config(2);
                Load_Config(3);
                Load_Config(4);
                Load_Config(5);
                Load_Config(6);
                Load_Config(7);
                Load_Config(8);
                Load_Config(9);
                Load_Config(10);
                Load_Config(11);
                Load_Config(12);
            }
            else
            {
                QuanlyTaiSan.Core.StaticValue.Base_RunClass.isOpens = false;
            }
            return QuanlyTaiSan.Core.StaticValue.Base_RunClass.isOpens;
        }
        private void Contruct_DanhMuc(DataTable table,List<QuanlyTaiSan.Core.Model.DanhMuc> list,ref bool TrangThai)
        {
            if(TrangThai == false)
            {
                if(table.Rows.Count>0)
                {
                    for(int i=0;i<table.Rows.Count;i++)
                    {
                        int id = 0; int.TryParse(table.Rows[i]["ID"].ToString(), out id);
                        QuanlyTaiSan.Core.Model.DanhMuc _danhmuc = new Model.DanhMuc();
                        _danhmuc.ID = id;
                        _danhmuc.TenDanhMuc = table.Rows[i]["CataNames"].ToString();
                        list.Add(_danhmuc);
                    }
                    QuanlyTaiSan.Core.Model.DanhMuc _v = new Model.DanhMuc();
                    _v.ID = 0;
                    _v.TenDanhMuc = "Chọn tất cả";
                    list.Insert(0, _v);
                    TrangThai = true;
                }else
                {
                    TrangThai = false;
                }
            }
            else
            {
                TrangThai = false;
            }
        }
        public bool Load_Config(int key)
        {
            bool r = false;
            QuanlyTaiSan.Core.Access.SetupStore _su = new SetupStore();
            string maloi = "";
            if (key == 1)
            {
                if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_COMPANY == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_COMPANY = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(2,0,2,QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config,ref maloi),QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_COMPANY,ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_COMPANY);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_COMPANY;
                }
            }
            else if(key == 2)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PERSIONAL == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PERSIONAL = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(8, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PERSIONAL, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PERSIONAL);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PERSIONAL;
                }
            }
            else if(key == 3)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_UNIT == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_UNIT = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(6, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_UNIT, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_UNIT);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_UNIT;
                }
            }
            else if(key == 4)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LOCATION == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LOCATION = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(4, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LOCATION, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LOCATION);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LOCATION;
                }
            }
            else if(key == 5)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORY == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_CATEGORY = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(3, 2, 2, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_CATEGORY, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORY);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORY;
                }
            }
            else if(key == 6)
            {
                if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORYIT == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_CATEGORYIT = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(3, 33, 3, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_CATEGORYIT, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORYIT);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_CATEGORYIT;
                }
            }
            else if(key==7)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SOURCE == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SOURCE = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(7, 0, 1, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SOURCE, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SOURCE);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SOURCE;
                }
            }
            else if(key == 8)
            {
                //Control_LINEBUSSINESS
                if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEBUSSINESS == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LINEBUSSINESS = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(7, 0, 2, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LINEBUSSINESS, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEBUSSINESS);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEBUSSINESS;
                }
            }
            else if(key==9)
            {
                if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEUSER == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LINEUSER = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(7, 0, 4, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_LINEUSER, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEUSER);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_LINEUSER;
                }
            }
            else if(key == 10)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_BRAND == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_BRAND = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(9, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_BRAND, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_BRAND);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_BRAND;
                }
            }
            else if(key==11)
            {
                if (QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SPECIFICATION == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SPECIFICATION = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(10, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_SPECIFICATION, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SPECIFICATION);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_SPECIFICATION;
                }
            }
            else if(key==12)
            {
                if(QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PROVIDER == false)
                {
                    QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PROVIDER = new List<Model.DanhMuc>();
                    Contruct_DanhMuc(_su.Get_Data(11, 0, 0, QuanlyTaiSan.Core.StaticValue.Base_RunClass._Get_Config, ref maloi), QuanlyTaiSan.Core.StaticValue.Base_RunClass.Control_PROVIDER, ref QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PROVIDER);
                }
                else
                {
                    r = QuanlyTaiSan.Core.StaticValue.Base_RunClass.is_Control_PROVIDER;
                }
            }
            return r;
        }
        //end
    }
}