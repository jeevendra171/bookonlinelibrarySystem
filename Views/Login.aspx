<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineBookStore.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            align-content: center!important;
            width: 253px;
            height: 242px;
        }
        .auto-style2 {
            margin-bottom: .5rem;
            width: 126px;
        }
    </style>
</head>
<body>
    <div class="container-fluid">
        <div class="row-mt-5 md-5">

        </div>
        <div class="row">

            <div class="col-md-4">

            </div>
            <div class="col-md-4">

                <form id="form1" runat="server">
                    <div>
                        <div class="row">
                            <div class="col-md-4"> </div>
                            <div class="col-md-8"><img src="../Assets/Images/Shopping.jpeg" class="auto-style1"/> </div>
                        </div>
                        
                    </div>
                    <div class="mt-3">

                        <label for="" class="form-label">User Name</label>
                        <input type="email" placeholder="Your Email Address" autocomplete="off" runat="server" class="form-control" id="UnameTb"/>
                    </div>
                    <div class="mt-3">
                        <label for="" class="auto-style2">Password</label>
                        <input type="password" placeholder="Password" autocomplete="off"  runat="server" class="form-control" id="PasswordTb"/>
                    </div>
                    <div class="mt-3 d-grid">
                         <asp:Label runat="server" ID="ErrMsg" class="text-danger text-center"></asp:Label><br />
                  
                        <asp:Button Text="Login" runat="server" class="btn-success btn" ID="LoginBtn" OnClick="LoginBtn_Click"/>
                       
                    </div>
                   

                </form>
            </div>
            <div class="col-md-4">

            </div>
        </div>
    </div>

</body>
</html>
