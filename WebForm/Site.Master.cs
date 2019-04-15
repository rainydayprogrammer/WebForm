using System;
using System.Web;
using System.Web.UI;

namespace WebForm
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string LabelText = "<ul class=\"navbar-nav mr-auto\">";
            foreach (SiteMapNode node in SiteMap.RootNode.ChildNodes)
            {
                if (node.HasChildNodes)
                {
                    if (SiteMap.CurrentNode != null && (node == SiteMap.CurrentNode || SiteMap.CurrentNode.IsDescendantOf(node)))
                    {
                        LabelText += "<li class=\"nav-item dropdown active\">";
                    }
                    else
                    {
                        LabelText += "<li class=\"nav-item dropdown\">";
                    }
                    LabelText += "<a href=\"" + node.Url + "\"class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\"";
                    LabelText += " role=\"button\"  aria-haspopup=\"true\" aria-expanded=\"false\"";
                    LabelText += ">" + node.Title;
                    LabelText += "</a>";
                    LabelText += "<div class=\"dropdown-menu\">";
                    foreach (SiteMapNode cnode in node.ChildNodes)
                    {
                        LabelText += "<a class=\"dropdown-item\" href=\"" + cnode.Url + "\">" + cnode.Title + "</a>";
                    }
                    LabelText += "</div>";
                }
                else
                {
                    if (node == SiteMap.CurrentNode)
                    {
                        LabelText += "<li class=\"nav-item active\"><a class=\"nav-link\" href=\"" + node.Url + "\">" + node.Title + "</a>";
                    }
                    else
                    {
                        LabelText += "<li class=\"nav-item\"><a class=\"nav-link\" href=\"" + node.Url + "\">" + node.Title + "</a>";
                    }
                }
                LabelText += "</li>";
            }

            LabMenu.Text = LabelText + "</ul>";

        }
    }
}