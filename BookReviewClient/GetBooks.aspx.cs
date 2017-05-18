using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetBooks : System.Web.UI.Page
{
    BookRevReference.BookReviewServiceClient sc =
        new BookRevReference.BookReviewServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        FillAuthorList();
    }

    protected void AuthorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void FillAuthorList()
    {
        string[] authors = sc.GetAuthors();
        AuthorDropDownList.DataSource = authors;
        //AuthorDropDownList.Text = "AuthorName";
        AuthorDropDownList.DataBind();
        ListItem item = new ListItem("Choose Author");
        AuthorDropDownList.Items.Insert(0, item);
    }
}