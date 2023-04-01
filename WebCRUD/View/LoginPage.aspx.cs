using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCRUD.Controller;
using WebCRUD.Model;
using WebCRUD.Repository;

namespace WebCRUD.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                emailTxtBox.Text = "";
                passwordTxtBox.Text = "";
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string password = passwordTxtBox.Text;

            string info = UserController.login(email, password);

            if(info.Equals("Succes"))
                Response.Redirect("HomePage.aspx");
            else
                status.Text = info;
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}