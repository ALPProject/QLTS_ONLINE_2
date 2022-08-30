using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConnect;

namespace QuanlyTaiSan.Core.StaticValue
{
    public static class Base_RunClass
    {
        public static bool isOpens;
        static Base_RunClass()
        {
            isOpens = false;
            _Form_loadSystem = "Form_loadSystem";
            _Form_loadSystem_Para = "Form_loadSystem_Para";
            _Get_Config = "Get_Config";

        }

        public static string _Form_loadSystem;
        public static string _Form_loadSystem_Para;
        public static string _Get_Config;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_COMPANY;
        public static bool is_Control_COMPANY = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_PERSIONAL;
        public static bool is_Control_PERSIONAL = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_STATUS;
        public static bool is_Control_STATUS = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_UNIT;
        public static bool is_Control_UNIT=false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_LOCATION;
        public static bool is_Control_LOCATION = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_CATEGORYIT;
        public static bool is_Control_CATEGORYIT = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_CATEGORY;
        public static bool is_Control_CATEGORY = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_SOURCE;
        public static bool is_Control_SOURCE = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_LINEBUSSINESS;
        public static bool is_Control_LINEBUSSINESS = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_LINEUSER;
        public static bool is_Control_LINEUSER = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_BRAND;
        public static bool is_Control_BRAND = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_SPECIFICATION;
        public static bool is_Control_SPECIFICATION = false;

        public static List<QuanlyTaiSan.Core.Model.DanhMuc> Control_PROVIDER;
        public static bool is_Control_PROVIDER = false;
        //end
    }
}