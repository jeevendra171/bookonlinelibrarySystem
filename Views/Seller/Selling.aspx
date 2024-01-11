<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="OnlineBookStore.Views.Seller.Selling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       function PrintBill() {
           var PGrid = document.getElementById('<%=BillList.ClientID%>');
           PGrid.border = 0;
           var PWin = window.open('', 'PrintGrid', 'left=100,top=100,width=1024,height=768,toolbar=0,scrollbars=1,status=0,resizable=1');
           PWin.document.write(PGrid.outerHTML);
           PWin.document.close();
           PWin.focus();
           PWin.print();
           PWin.close();
           //PWin.focus();
           //PWin.print();
           //PWin.close();
       }
   </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
   <div class="container-fluid" style="margin-left: 16vw;">
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center" style="color: orangered">Book Details</h3>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="BNameTb" class="form-label text-success">Book Name</label>
                            <input type="text" placeholder="Book Name" autocomplete="off" runat="server" id="BNameTb" class="form-control" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="mt-3">
                            <label for="BPriceTb" class="form-label text-success">Book Price</label>
                            <input type="text" placeholder="Book Price" autocomplete="off" runat="server" id="BPriceTb" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="BQtyTb" class="form-label text-success">Quantity</label>
                            <input type="text" placeholder="Quantity" autocomplete="off" runat="server" id="BQtyTb" class="form-control" />
                        </div>
                    </div>
                    <div class="col">
                        <div class="mt-3">
                            <label for="DateTb" class="form-label text-success">Billing Date</label>
                            <input type="date" runat="server" id="DateTb" class="form-control" />
                        </div>
                    </div>
                    <div class="row mt-3 mb-3">
                        <div class="col d-grid">
                            <asp:Button Text="Add To Bill" runat="server" ID="AddToBillBtn" class="btn-warning btn-block btn" OnClick="AddToBillBtn_Click" />
                        </div>
                    </div>
                </div>
                <div class="row mt-5">
                    <h4 class="text-center" style="color: orangered">Book List</h4>
                    <div class="col">
                        <asp:GridView ID="Bookslist" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Catagorieslist_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <HeaderStyle BackColor="SlateBlue" Font-Bold="false" ForeColor="White" />
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
            <div class="col-md-7">
                <h4 class="text-center" style="color: red">Client List</h4>
                <div class="col">
                    <asp:GridView ID="BillList" runat="server" CssClass="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Catagorieslist_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="SlateBlue" Font-Bold="false" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                   </asp:GridView>
                    <div class="d-grid">
                        <asp:Label runat="server" ID="GrdTotalTb" class="text-danger text-center"></asp:Label><br />
                        <asp:Button Text="Print" runat="server" ID="PrintBtn" OnClientClick="PrintBill()" class="btn-warning btn-block btn" OnClick="PrintBtn_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
