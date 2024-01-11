using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowCategories();
                GetCategories();
                GetAuthors();
            }
            
        }
        private void ShowCategories()
        {
            string Query = "Select * from BookTbl";
            Bookslist.DataSource = Con.GetData(Query);
            Bookslist.DataBind();
        }
        private void GetCategories()
        {
            string Query= "Select * from CategoryTbl";
            BCatCb.DataTextField=Con.GetData(Query).Columns["CatName"].ToString();
            BCatCb.DataTextField = Con.GetData(Query).Columns["CatId"].ToString();
            BCatCb.DataSource = Con.GetData(Query);
            BCatCb.DataBind();
        }
        private void GetAuthors()
        {
            string Query = "Select * from AuthorTbl";
            BAuthCb.DataTextField = Con.GetData(Query).Columns["AutName"].ToString();
            BAuthCb.DataTextField = Con.GetData(Query).Columns["AutId"].ToString();
            BAuthCb.DataSource = Con.GetData(Query);
            BAuthCb.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == ""|| PriceTb.Value=="")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                  
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                        int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "insert into  BookTbl values('{0}',{1},{2},'{3}','{4}')";
                    Query = string.Format(Query, BName, BAuth, BCategory, Quantity, Price);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Book Inserted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
        int key = 0;
        protected void Catagorieslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value = Bookslist.SelectedRow.Cells[2].Text;
            BAuthCb.SelectedValue = Bookslist.SelectedRow.Cells[3].Text;
            BCatCb.SelectedValue = Bookslist.SelectedRow.Cells[4].Text;
            QtyTb.Value = Bookslist.SelectedRow.Cells[5].Text;
            PriceTb.Value = Bookslist.SelectedRow.Cells[6].Text;

            if (BNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Bookslist.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == "" || PriceTb.Value == "")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();

                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "update BookTbl set BName='{0}',BAuthor={1},Bcategory={2},BQty='{3}',BPrice='{4}' where BId={5}";
                    Query = string.Format(Query, BName, BAuth, BCategory, Quantity, Price, Bookslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Book Updated!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == "" || PriceTb.Value == "")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuth = BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();

                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);

                    string Query = "delete from BookTbl  where BId={0}";
                    Query = string.Format(Query, Bookslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Book deleted!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        
    }
}