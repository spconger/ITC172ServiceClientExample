﻿using System;
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
        if(!IsPostBack)
        FillAuthorList();
    }

    protected void AuthorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        BookRevReference.Book[] books =
            sc.GetBooksByAuthor(AuthorDropDownList.SelectedItem.Text);
        GridView1.DataSource = books;
        GridView1.DataBind();
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