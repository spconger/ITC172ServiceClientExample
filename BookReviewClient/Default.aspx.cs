using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        BookRevReference.BookReviewServiceClient sc = 
            new BookRevReference.BookReviewServiceClient();

        int result = sc.Login(UserTextBox.Text, PasswordTextBox.Text);

        if (result != 0)
        {
            Session["userKey"] = result;
            ResultLabel.Text = "Welcome ";
        }
        else
        {
            ResultLabel.Text = "Invalid login";
        }
            

    }
}