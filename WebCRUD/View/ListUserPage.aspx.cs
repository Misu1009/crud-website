using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCRUD.Controller;

namespace WebCRUD.View
{
    public partial class ListUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.isExist())
            {
                userGridView.DataSource = UserController.getAllUser();
                userGridView.DataBind();
                return;
            }
            status.Text = "No Data";
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void userGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = userGridView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);

            UserController.delete(id);
            Response.Redirect("ListUserPage.aspx");
        }
    }
}