using System;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class PageSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Text = Utils.HtmlUtil.TextSearchLink(e.Row.Cells[2].Text);
                e.Row.Cells[3].Text = Utils.HtmlUtil.TextSearchLink(e.Row.Cells[3].Text);
            }
        }
    }
}