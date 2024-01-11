using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.Views.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        Models.Functions Con;
        int Seller = Login.User;
        string SName = Login.UName;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowBooks();
               DataTable dt= new DataTable();
                dt.Columns.AddRange(new DataColumn[5]{
                    new DataColumn("ID"),
                    new DataColumn("Book"),
                     new DataColumn("Price"),
                         new DataColumn("Quantity"),
                         new DataColumn("Total"),
                }
                );
                ViewState["Bill"] = dt;
                this.BindGrid();
            }
        }
        protected void BindGrid()
        {
            BillList.DataSource = ViewState["Bill"];
            BillList.DataBind();    
        }
        private void ShowBooks()
        {
            string Query = "Select BId as Code,BName as Name,BQty as Stock,Bprice as Price from BookTbl";
            Bookslist.DataSource = Con.GetData(Query);
            Bookslist.DataBind();
        }
        int key = 0;
        int Stock = 0;
        protected void Catagorieslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value = Bookslist.SelectedRow.Cells[2].Text;
            BPriceTb.Value = Bookslist.SelectedRow.Cells[4].Text;

            // Validate and parse the Stock value
            if (int.TryParse(Bookslist.SelectedRow.Cells[3].Text, out int stock))
            {
                Stock = stock;
            }
            else
            {
                // Handle the case where the string is not a valid integer
                // Here, setting Stock to a default value or performing error handling
                Stock = 0; // Setting a default value of 0
            }

            // Validate and parse the key value
            if (int.TryParse(Bookslist.SelectedRow.Cells[1].Text, out int parsedKey))
            {
                key = parsedKey;
            }
            else
            {
                // Handle the case where the string is not a valid integer
                // Here, setting key to a default value or performing error handling
                key = 0; // Setting a default value of 0
            }

            //BNameTb.Value = Bookslist.SelectedRow.Cells[2].Text;
            //Stock = Convert.ToInt32(Bookslist.SelectedRow.Cells[3].Text);
            //BPriceTb.Value = Bookslist.SelectedRow.Cells[4].Text;

            //if (!string.IsNullOrEmpty(BNameTb.Value))
            //{

            //    if (int.TryParse(Bookslist.SelectedRow.Cells[1].Text, out int result))
            //    {
            //        key = result;
            //    }
            //    else
            //    {

            //        key = 0; 
            //    }
            //}
            //else
            //{
            //    key = 0;
            //}


            //    if (BNameTb.Value == "")
            //{
            //    key = 0;
            //}
            //else
            //{
            //    key = Convert.ToInt32(Bookslist.SelectedRow.Cells[1].Text);
            //}
        }
        private void UpdateStock()
        {
            int NewQty;
            NewQty = Convert.ToInt32(Bookslist.SelectedRow.Cells[3].Text)+ Convert.ToInt32(BQtyTb.Value);
            string Query= "Update BookTbl set BQty='{0}' where BId={1}";                   
            Query = string.Format(Query, NewQty, Bookslist.SelectedRow.Cells[1].Text);                    
            Con.SetData(Query);
            ShowBooks();
        }
        public void InsertBill()
        {
            string Query = "insert into BillTbl values('{0}','{1}','{2}')";//datetime.today.date,text.substring(2)
            Query = string.Format(Query, System.DateTime.Today.ToString(), Seller, Convert.ToInt32(GrdTotalTb.Text.Substring(2)));
            //Query= string.Format(Query, DateTime.Today.Date)
            Con.SetData(Query);
            ShowBooks();
            try
            {
                 
            }
            catch(Exception Ex)
            {

            }
        }
        int Grdtotle = 0;
        int Amount;
        protected void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if(BQtyTb.Value==""|| BPriceTb.Value==""||BNameTb.Value=="")
            {

            }
            else
            {
                int total = Convert.ToInt32(BQtyTb.Value) * Convert.ToInt32(BPriceTb.Value);
                DataTable dt = (DataTable)ViewState["Bill"];
                dt.Rows.Add(BillList.Rows.Count + 1,
                    BNameTb.Value.Trim(),
                    BPriceTb.Value.Trim(),
                    BQtyTb.Value.Trim(),
                    total);
                ViewState["Bill"] = dt;
                this.BindGrid();
                //UpdateStock();
                
                for (int i = 0; i < BillList.Rows.Count - 1; i++)
                {
                    Grdtotle = Grdtotle + Convert.ToInt32(BillList.Rows[i].Cells[5].Text);
                }
                Amount = Grdtotle;
                GrdTotalTb.Text = "Rs" + Grdtotle;
                BNameTb.Value = "";
                BPriceTb.Value = "";
                BQtyTb.Value = "";
                Grdtotle = 0;

            }
            

            
        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {
            InsertBill();
        }
    }
}