<%@ Page Title="" Language="C#" MasterPageFile="~/QLTS.Master" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="QuanlyTaiSan.Trangchu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="vh-100">
  <div class="container-fluid h-custom">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
          <img src="Image/draw2.webp" class="img-fluid" alt="Sample image">
      </div>


      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
          <div class="d-flex flex-row align-items-center justify-content-center justify-content-lg-start">
            <p class="lead fw-normal mb-0 me-3">Đăng nhập hệ thống</p>
            <button type="button" class="btn btn-primary btn-floating mx-1">
              <i class="fab fa-facebook-f"></i>
            </button>

            <button type="button" class="btn btn-primary btn-floating mx-1">
              <i class="fab fa-twitter"></i>
            </button>

            <button type="button" class="btn btn-primary btn-floating mx-1">
              <i class="fab fa-linkedin-in"></i>
            </button>
          </div>

          <div class="divider d-flex align-items-center my-4">
            <p class="text-center fw-bold mx-3 mb-0"></p>
          </div>

          <!-- Email input -->
          <div class="form-outline mb-4">
<<<<<<< HEAD
            <input type="email" id="txtemail" class="form-control form-control-md"
=======
            <input type="email" id="txtemail" runat="server" class="form-control form-control-md"
>>>>>>> origin/Dev
              placeholder="Enter a valid email address" />
          </div>

          <!-- Password input -->
          <div class="form-outline mb-3">
            <input type="password" id="txtpasword" runat="server" class="form-control form-control-lg"
              placeholder="Enter password" />
            
          </div>

          <div class="d-flex justify-content-between align-items-center">
            <!-- Checkbox -->
            <div class="form-check mb-0">
              <input class="form-check-input me-2" runat="server" type="checkbox" value="" id="form2Example3" />
              <label class="form-check-label" for="form2Example3">
                Lưu phiên làm việc
              </label>
            </div>
            
          </div>

          <div class="text-center text-lg-start mt-4 pt-2">
              <asp:Button ID="Button1" runat="server" Text="Đăng nhập" class="btn btn-primary btn-lg" OnClick="Button1_Click"/>
          </div>


      </div>
    </div>
  </div>
  <div
    class="d-flex flex-column flex-md-row text-center text-md-start justify-content-between py-4 px-4 px-xl-5 bg-primary">
    <!-- Copyright -->
    <div class="text-white mb-3 mb-md-0">
      Copyright © 2022. All rights reserved.
    </div>
    <!-- Copyright -->

    <!-- Right -->
    <div>
      <a href="#!" class="text-white me-4">
        <i class="fab fa-facebook-f"></i>
      </a>
      <a href="#!" class="text-white me-4">
        <i class="fab fa-twitter"></i>
      </a>
      <a href="#!" class="text-white me-4">
        <i class="fab fa-google"></i>
      </a>
      <a href="#!" class="text-white">
        <i class="fab fa-linkedin-in"></i>
      </a>
    </div>
    <!-- Right -->
  </div>
</section>
</asp:Content>
