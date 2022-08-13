<%@ Page Title="" Language="C#" MasterPageFile="~/QLTSMain.Master" AutoEventWireup="true" CodeBehind="Quantri.aspx.cs" Inherits="QuanlyTaiSan.GUI.Quantri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <nav class="navbar navbar-expand-sm bg-primary navbar-dark">
          <ul class="navbar-nav">
            <li class="nav-item active">
              <a class="nav-link" href="#">TRANG CHỦ</a>
            </li>
            <li class="nav-item active">
              <a class="nav-link" href="#">NHẬP KHO HC</a>
            </li>
            <li class="nav-item active">
              <a class="nav-link" href="#">NHÂP KHO CNTT</a>
            </li>
            <li class="nav-item active">
              <a class="nav-link disabled" href="#">KIỂM KÊ</a>
            </li>
          </ul>
        </nav>
    </div>
    <div class="container">
       <div class="row">
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
        </div>

        <div class="row">
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
          <div class="col-sm-3 bg-success">.col-sm-3</div>
        </div>

        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="Office2003Blue">
            <Settings ShowGroupPanel="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
<SettingsPopup>
<HeaderFilter MinHeight="140px"></HeaderFilter>
</SettingsPopup>
        </dx:ASPxGridView>

    </div>
</asp:Content>
