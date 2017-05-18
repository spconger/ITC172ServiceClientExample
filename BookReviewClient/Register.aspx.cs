using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string user = UserTextBox.Text;
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;

        BookRevReference.BookReviewServiceClient sc =
            new BookRevReference.BookReviewServiceClient();
        BookRevReference.Reviewer rev = new BookRevReference.Reviewer();
        rev.ReviewerUserName = user;
        rev.ReviewerLastName = last;
        rev.ReviewerFirstName = first;
        rev.ReviewerEmail = email;
        rev.ReviewPlainPassword = password;

        bool result = sc.RegisterReviewer(rev);
        if(result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went horribly wrong";
        }

    }
}