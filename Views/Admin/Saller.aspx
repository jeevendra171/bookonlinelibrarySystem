<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Saller.aspx.cs" Inherits="OnlineBookStore.Views.Admin.Saller" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    
    <div class="container-fluid" style="margin-left: 16vw;">
        <div class="row">

        </div>
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage seller</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Name</label>
                    <input type="text" placeholder="Seller Name" autocomplete="off" runat="server" id="SNameTb" class="form-control" />
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Email</label>
                    <input type="text" placeholder="Seller Email" autocomplete="off" runat="server" id="EmailTb" class="form-control" />
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Phone Number</label>
                    <input type="text" placeholder="Seller Phone Number" autocomplete="off" runat="server" id="PhoneTb" class="form-control" />
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Password</label>
                    <input type="text" placeholder="Password" autocomplete="off" runat="server" id="AddressTb" class="form-control" />
                </div>
                <%--<div class="mb-3">
                    <label for="" class="form-label text-success">Seller Gender</label>
                     <asp:DropDownList ID="DropDownList2" runat="server"  runat="server" id="PhoneTb" class="form-control">
                         <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                     </asp:DropDownList>--%>
                <%--<input type="text" placeholder="Books Athors" autocomplete="off" class="form-control" />--%>
           
            <%--<div class="mb-3">
                    <label for="" class="form-label text-success">Country</label>
                   <%-- <asp:GridView ID="GridView1" runat="server" ></asp:GridView>--%>
            <%--<asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                        <asp:ListItem>Bharat</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>Spain</asp:ListItem>
                        <asp:ListItem>Ukrain</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <%--<input type="text" placeholder="Catogries" autocomplete="off"  />--%>
       
      
               
                <div class="row">
                     <asp:Label runat="server" ID="ErrMsg" class="text-danger text-center"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" ID="EditBtn" class="btn-warning btn-block btn" OnClick="EditBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server"  ID="SaveBtn" class="btn-success  btn-block btn" OnClick="SaveBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server"  ID="DeleteBtn" class="btn-danger  btn-block btn" OnClick="DeleteBtn_Click" />
                    </div>

                </div>
    </div>
    <div class="col-md-8">
        <asp:GridView ID="SellerList" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="1132px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="SellerList_SelectedIndexChanged">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="teal" Font-Bold="False" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>
    </div>
    </div>
</asp:Content>
