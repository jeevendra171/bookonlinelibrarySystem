using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "Select * from CategoryTbl";
            Catagorieslist.DataSource = Con.GetData(Query);
            Catagorieslist.DataBind();
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value=="")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;
                    ;
                    string Query = "insert into  CategoryTbl values('{0}','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Categories Inserted!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
                  
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
            CatNameTb.Value = Catagorieslist.SelectedRow.Cells[2].Text;
            DescriptionTb.Value= Catagorieslist.SelectedRow.Cells[3].Text;
            if (CatNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Catagorieslist.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;
                    
                    string Query = "update CategoryTbl set CatName='{0}',CatDescription='{1}' where CatId={2}";
                    Query = string.Format(Query, CName, CDesc ,Catagorieslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Categories updated!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";

                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;
                    
                    string Query = "delete from CategoryTbl where CatId={0}";
                    Query = string.Format(Query, CName, CDesc, Catagorieslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Categories deleted!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";

                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}