using OnlineBookStore.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            //if (!IsPostBack)
            //{
            //    ShowCategories();
            //    GetCategories();
            //    GetAuthors();
            //}
        }
        public static string UName = "";
        public static int User;
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Value == ""|| PasswordTb.Value=="")
            {
                ErrMsg.Text = "Mssing Details!!!";
            }
            else if (UnameTb.Value == "Admin@gmail.com" && PasswordTb.Value == "Password")
            {
                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string Query = "Select * From SellerTbl Where SelEmail='{0}' and SelPass='{1}'";
                Query = string.Format(Query,UnameTb.Value,PasswordTb.Value);
                DataTable dt=Con.GetData(Query);
                if(dt.Rows.Count== 0 ) 
                {
                    Response.Redirect("Admin/Books.aspx");
                }
                else
                {
                    UName = UnameTb.Value;
                    User = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Seller/Selling.aspx");
                }
            }
        }
    }
}