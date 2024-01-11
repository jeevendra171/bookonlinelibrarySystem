<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="OnlineBookStore.Views.Admin.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid" style="margin-left: 16vw;">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Catagories</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Catagories Name</label>
                    <input type="text" placeholder="Catagories Name" autocomplete="off" class="form-control" runat="server" id="CatNameTb" />
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Catagories Discription</label>
                    <%--<asp:DropDownList ID="DropDownList2" runat="server" class="form-control"></asp:DropDownList>--%>
                    <input type="text" placeholder="Catagories Discription" autocomplete="off" class="form-control" runat="server" id="DescriptionTb" />
                </div>

                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger text-center"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" ID="EditBtn" class="btn-warning btn-block btn" OnClick="EditBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" ID="saveBtn" class="btn-success  btn-block btn" OnClick="saveBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" ID="deleteBtn" class="btn-danger  btn-block btn" OnClick="deleteBtn_Click" />
                    </div>

                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="Catagorieslist" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Catagorieslist_SelectedIndexChanged">
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
