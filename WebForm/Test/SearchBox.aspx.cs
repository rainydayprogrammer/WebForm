using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm.Test
{
    public partial class SearchBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                return;
            }

            var data = new Data.Goods();
            var result = data.GetGoodsAll().Where(m => m.Name.Contains(txtKeyword.Text.TrimEnd()));
            GridView1.DataSource = result;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            foreach (TableCell cell in e.Row.Cells)
            {
                cell.Text = Utils.HtmlUtil.TextHighlight(cell.Text, txtKeyword.Text);
            }
        }
    }
}