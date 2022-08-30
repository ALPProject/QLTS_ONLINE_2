<%@ Page Title="" Language="C#" MasterPageFile="~/TaiSan.Master" AutoEventWireup="true" CodeBehind="NhapkhoHC.aspx.cs" Inherits="QuanlyTaiSan.GUI.NhapkhoHC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href ="../Style/TaiSanStyles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-3">
        <div class="col-md-12 bg-light"><h5 class="text-black" style="font-family:'Open Sans';Text-align:center;padding-top:10px;font-weight:bold;">  NHẬP KHO HÀNH CHÍNH </h5></div>  
        </div>
    </div>

    <div class="container" style="padding:10px 10px;">

        <div class="card">
        <div class="card-header text-primary font-weight-bold">Thông tin sản phẩm</div>
        <div class="card-body">

                    <div class="form-group row">
                              <label for="inputEmail3" class="col-sm-2 h-75 col-form-label text-right text-danger font-weight-bold">Nguồn nhập (*):</label>
                              <div class="col-sm-2 h-75">
                                    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control form-control-lg" Height="30px" Width="190px"></dx:ASPxComboBox>
                              </div>

                              <label for="inputEmail3" class="col-sm-2 h-75 col-form-label text-right">Email</label>
                              <div class="col-sm-2 h-75">
                                         <dx:ASPxComboBox ID="ASPxComboBox2" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                               </div>

                               <label for="inputEmail3" class="col-sm-2 h-75 col-form-label text-right">Email</label>
                               <div class="col-sm-2 h-75">
                                         <dx:ASPxComboBox ID="ASPxComboBox3" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                               </div>

                     </div>

                    <div class="form-group row">
                        <label for="inputEmail3" class="col-sm-2  col-form-label text-right text-danger font-weight-bold">Chọn Công Ty (*):</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </div>

                        <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                        <div class="col-sm-2">

                        </div>
                        <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                        <div class="col-sm-2">

                         </div>
                     </div>

                    <div class="form-group row">
                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right text-danger font-weight-bold">Chọn Công Ty (*):</label>
                      <div class="col-sm-2">
                            <dx:ASPxComboBox ID="ASPxComboBox4" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control" Height="30px" Width="190px"></dx:ASPxComboBox>
                      </div>

                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                      <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox5" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

                       <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                       <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox6" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

             </div>

        </div>
        </div>


        <div class="card">
        <div class="card-header text-success font-weight-bold">Thông chi tiết</div>
            <div class="card-body">

            <div class="form-group row">
                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right text-danger font-weight-bold">Tên tài sản (*):</label>
                      <div class="col-sm-2">
                            <dx:ASPxComboBox ID="ASPxComboBox7" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control" Height="30px" Width="190px"></dx:ASPxComboBox>
                      </div>

                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                      <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox8" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

                       <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                       <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox9" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

             </div>

            <div class="form-group row">
                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right text-danger font-weight-bold">Loại tài sản(*):</label>
                      <div class="col-sm-2">
                            <dx:ASPxComboBox ID="ASPxComboBox10" runat="server" ValueType="System.String" ButtonEditEllipsisImage-SpriteProperties-CssClass="form-control" Height="30px" Width="190px"></dx:ASPxComboBox>
                      </div>

                      <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                      <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox11" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

                       <label for="inputEmail3" class="col-sm-2 col-form-label text-right">Email</label>
                       <div class="col-sm-2">
                                 <dx:ASPxComboBox ID="ASPxComboBox12" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                       </div>

             </div>

            </div>
        </div>


        <div class="card">
        <div class="card-header text-warning font-weight-bold">Thông chi tiết</div>
            <div class="card-body">
            </div>
        </div>


    </div>



    <div class="container">
        <asp:Button ID="Button1" runat="server" Text="get" OnClick="Button1_Click" />
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" Theme="Youthful" AutoGenerateColumns="False" OnLoad="ASPxGridView1_Load" OnRowUpdated="ASPxGridView1_RowUpdated" KeyFieldName="ID" OnInit="ASPxGridView1_Init">
            <SettingsPager PageSize="50">
            </SettingsPager>
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        <SettingsPopup>
        <HeaderFilter MinHeight="140px"></HeaderFilter>
        </SettingsPopup>
                <Columns>
                    <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn Caption="Mã Đơn Vị" FieldName="ComCode" Name="ComCode" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tên Đơn Vị" FieldName="ComNames" Name="ComNames" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Mã Hệ Thống" FieldName="ID" Name="ID" ShowInCustomizationForm="True" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
            </Columns>
       </dx:ASPxGridView>
    </div>
</asp:Content>
