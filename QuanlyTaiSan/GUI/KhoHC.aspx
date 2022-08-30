<%@ Page Title="" Language="C#" MasterPageFile="~/TaiSan.Master" AutoEventWireup="true" CodeBehind="KhoHC.aspx.cs" Inherits="QuanlyTaiSan.GUI.KhoHC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-3">
            <div class="col-sm-12"><h5 class="text-black" style="font-family:'Open Sans';Text-align:center;padding-top:8px;font-weight:bold;">  NHẬP KHO HÀNH CHÍNH </h5></div>  
        </div>
    </div>

    <div class="container" style="padding:2px 2px;">

        <div class="row bg-light">
            <div class="col-md-3" style="background-color:#Fbe5e5"><h5 style="font-family:'Open Sans';Text-align:center;padding-top:10px;font-weight:bold;color:red;">Thông tin tài sản</h5></div>
            <div class="col-md-9" style="background-color:#Fbe5e5"></div>
        </div>

        <div class ="form-row pt-2">
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Thông tin nhập(*):</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="dropThongtinNhap" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control" ></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Công ty (*):</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="dropcongty" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Tên Tài Sản (*):</div>
            <div class="form-group col-sm-2 h-75"><asp:TextBox ID="txt_tentaisan" runat="server" ></asp:TextBox></div>
        </div>

        <div class="form-row">
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Loại Tài Sản(*):</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="droploaits_hc" runat="server" ValueType="System.String" AutoPostBack="True" OnSelectedIndexChanged="droploaits_hc_SelectedIndexChanged"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Chi Tiết loại(*):</div>
            <div class="form-group col-sm-2 h-75 "><dx:ASPxComboBox ID="drop_chitiet_tshc" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-danger font-weight-bold">Mã Tài Sản(*):</div>
            <div class="form-group col-sm-2 h-75 "><asp:TextBox ID="txtMaTs" runat="server"></asp:TextBox></div>
        </div>


        <div class="row bg-light">
            <div class="col-md-3" style="background-color:#c3e6fa"><h5 style="font-family:'Open Sans';Text-align:center;padding-top:10px;font-weight:bold;color:blue;">Thông tin Mở rộng</h5></div>
            <div class="col-md-9" style="background-color:#c3e6fa"></div>
        </div>


         <div class ="form-row pt-2">
            <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Nhãn hiệu:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="dropNhanhieu" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Quy Cách:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="dropQuycach" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Đơn vị cung cấp:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="dropDonvicungcap" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control" ></dx:ASPxComboBox></div>
        </div>

         <div class="form-row">
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Ngày sử dụng:</div>
             <div class="form-group col-sm-2 h-75"><dx:ASPxDateEdit ID="ASPxDateEdit1" runat="server"></dx:ASPxDateEdit></div>
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Ngày bảo Từ:</div>
             <div class="form-group col-sm-2 h-75"><dx:ASPxDateEdit ID="ASPxDateEdit2" runat="server"></dx:ASPxDateEdit></div>
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Ngày bảo Đến:</div>
             <div class="form-group col-sm-2 h-75"><dx:ASPxDateEdit ID="ASPxDateEdit3" runat="server"></dx:ASPxDateEdit></div>
         </div>

         <div class="form-row">
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Phụ kiện đi kèm:</div>
             <div class="form-group col-sm-2 h-75"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" text="Có"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:RadioButton ID="RadioButton2" runat="server" text="không"/>
             </div>
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Thông tin phụ kiện:</div>
             <div class="form-group col-sm-2 h-75"><asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox></div>
             <div class="form-group col-sm-2 h-75 text-right text-primary font-weight-bold">Thông tin ghi chú:</div>
             <div class="form-group col-sm-2 h-75"><asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox></div>
        </div>


      <div class="row bg-light">
            <div class="col-md-3" style="background-color:#fcfbe6"><h5 style="font-family:'Open Sans';Text-align:center;padding-top:10px;font-weight:bold;color:gold">Thông tin Cấp phát</h5></div>
            <div class="col-md-9" style="background-color:#fcfbe6"></div>
      </div>

        <div class ="form-row pt-2">
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Công ty:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="isCongty" runat="server" ValueType="System.String"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Ban:</div>
            <div class="form-group col-sm-2 h-75"> <dx:ASPxComboBox ID="isPhongban" runat="server" ValueType="System.String"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Phòng:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="isBophan" runat="server" ValueType="System.String"></dx:ASPxComboBox></div>
        </div>
         
         <div class="form-row">
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Người sử dụng:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="isNguoidung" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Vị trí:</div>
            <div class="form-group col-sm-2 h-75"><dx:ASPxComboBox ID="isVitri" runat="server" ValueType="System.String"></dx:ASPxComboBox></div>
            <div class="form-group col-sm-2 h-75 text-right font-weight-bold">Ghi Chú cấp phát:</div>
             <div class="form-group col-sm-2 h-75"><asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox></div>
        </div>

  </div>




    <div class="container">
        <div class="row pb-3">
            <div class="col-md-4">

            </div>
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <asp:Button ID="Button1" runat="server" Text="get" OnClick="Button1_Click" CssClass="btn btn-primary"/>
                <input class="btn btn-primary" type="button" value="Input">
                <input class="btn btn-primary" type="submit" value="Submit">
                <input class="btn btn-primary" type="reset" value="Reset">
            </div>
        </div>
    </div>

    <div class="container border border-primary">
        
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="Aqua" AutoGenerateColumns="False" OnLoad="ASPxGridView1_Load" OnRowUpdated="ASPxGridView1_RowUpdated" KeyFieldName="ID" OnInit="ASPxGridView1_Init">
            <SettingsPager PageSize="50">
            </SettingsPager>
            <Settings ShowFilterRow="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        <SettingsPopup>
        <HeaderFilter MinHeight="140px"></HeaderFilter>
        </SettingsPopup>
                <SettingsSearchPanel Visible="True" />
                <Columns>
                    <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0" ShowClearFilterButton="True">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn Caption="Mã ALP" FieldName="Mã ALP" Name="Mã ALP" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Mã BarCode" FieldName="Mã BarCode" Name="Mã BarCode" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tên Sản phẩm" FieldName="Tên Sản phẩm" Name="Tên Sản phẩm" ShowInCustomizationForm="True" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Loại Tài Sản" FieldName="Loại Tài Sản" Name="Loại Tài Sản" VisibleIndex="4">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Nhãn hiệu" FieldName="Nhãn hiệu" Name="Nhãn hiệu" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>


            </Columns>
       </dx:ASPxGridView>

    </div>

        <div class="container">
        <div class="row pt-3 pb-3">
            <div class="col-md-4">

            </div>
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <asp:Button ID="Button2" runat="server" Text="get" OnClick="Button1_Click" CssClass="btn btn-primary"/>
                <input class="btn btn-primary" type="button" value="Input">
                <input class="btn btn-primary" type="submit" value="Submit">
                <input class="btn btn-primary" type="reset" value="Reset">
            </div>
        </div>
    </div>

    <footer class="bg-light text-center text-lg-start">
  <!-- Copyright -->
  <div class="text-center p-3" style="background-color: rgba(0, 0, 0, 0.2);">
    © 2020 Copyright:
    <a class="text-dark" href="#">MDBootstrap.com</a>
  </div>
  <!-- Copyright -->
</footer>
</asp:Content>
