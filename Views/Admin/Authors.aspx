<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Authors.aspx.cs" Inherits="OnlineBookStore.Views.Admin.Authors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <div class="container-fluid" style="margin-left:16vw;" >
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Authors</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Authors Name</label>
                    <input type="text" placeholder="Title" autocomplete="off" class="form-control" runat="server" id="ANameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Athors Gender</label>
                     <asp:DropDownList  runat="server" class="form-control" ID="GenCb">
                         <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                     </asp:DropDownList>
                    <%--<input type="text" placeholder="Books Athors" autocomplete="off" class="form-control" />--%>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Country</label>
                   <%-- <asp:GridView ID="GridView1" runat="server" ></asp:GridView>--%>
                    <asp:DropDownList  runat="server" class="form-control" ID="CountryCb">
                        <asp:ListItem>Bharat</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>Spain</asp:ListItem>
                        <asp:ListItem>Ukrain</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <%--<input type="text" placeholder="Catogries" autocomplete="off"  />--%>
                </div>
               
                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger text-center"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" ID="EditBtn" class="btn-warning btn-block btn" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" ID="SaveBtn" class="btn-success  btn-block btn" OnClick="SaveBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" ID="DeleteBtn" class="btn-danger  btn-block btn" OnClick="DeleteBtn_Click" />
                    </div>

                </div>
            </div>
            <div class="col-md-8">
                 <%--<link href="../../Content/bootstrap.min.css" rel="stylesheet" /> --%>
                <asp:GridView ID="Authorslist" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                 </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
