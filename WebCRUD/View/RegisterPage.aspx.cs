using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCRUD.Controller;

namespace WebCRUD.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                nameTxtBox.Text = "";
                emailTxtBox.Text = "";
                passwordTxtBox.Text = "";
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTxtBox.Text;
            string email = emailTxtBox.Text;
            string password = passwordTxtBox.Text;

            string info = UserController.register(name, email, password);

            if (info.Equals("Succes"))
                Response.Redirect("HomePage.aspx");
            else
                status.Text = info;
        }
    }
}