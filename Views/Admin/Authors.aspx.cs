using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.Views.Admin
{
    public partial class Authors : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con=new Models.Functions();
            ShowAuthors();
        }

        private void ShowAuthors()
        {
            string Query = "Select * from AuthorTbl";
            Authorslist.DataSource = Con.GetData(Query);
            Authorslist.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender=GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();
                    string Query = "insert into AuthorTbl values('{0}','{1}','{2}')";
                    Query=string.Format(Query, AName, Gender, Country);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "Authors Inserted!!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                ErrMsg.Text= ex.Message;
            }

        }
        int key = 0;
        protected void Authorslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ANameTb.Value = Authorslist.SelectedRow.Cells[2].Text;
           GenCb.SelectedItem.Value = Authorslist.SelectedRow.Cells[3].Text;
            CountryCb.SelectedItem.Value = Authorslist.SelectedRow.Cells[4].Text;
            if(ANameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Authorslist.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Details!!!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = GenCb.SelectedItem.ToString();
                    string Query = "update AuthorTbl set AutName='{0}',AutGender='{1}',AutCountry='{2}'where AutId={3}";
                    Query = string.Format(Query, AName, Gender, Country, Authorslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "Authors Updated!!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
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
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select an Authors!!!!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = GenCb.SelectedItem.ToString();
                    string Query = "delete from AuthorTbl where AutId={0}";
                    Query = string.Format(Query, AName, Gender, Country, Authorslist.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "Authors deleted!!!";
                    ANameTb.Value = "";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}