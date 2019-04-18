using System.Web;
using System.Web.UI;

namespace CustomServerControlsLib
{
    public class BootstrapMenuControl : Control
    {
        
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("<ul class=\"navbar-nav mr-auto\">");
            foreach (SiteMapNode node in SiteMap.RootNode.ChildNodes)
            {
                if (node.HasChildNodes)
                {
                    if (SiteMap.CurrentNode != null && (node == SiteMap.CurrentNode || SiteMap.CurrentNode.IsDescendantOf(node)))
                    {
                        writer.Write("<li class=\"nav-item dropdown active\">");
                    }
                    else
                    {
                        writer.Write("<li class=\"nav-item dropdown\">");
                    }
                    writer.Write("<a href=\"" + node.Url + "\"class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\"");
                    writer.Write(" role=\"button\"  aria-haspopup=\"true\" aria-expanded=\"false\"");
                    writer.Write(">" + node.Title);
                    writer.Write("</a>");
                    writer.Write("<div class=\"dropdown-menu\">");
                    foreach (SiteMapNode cnode in node.ChildNodes)
                    {
                        writer.Write("<a class=\"dropdown-item\" href=\"" + cnode.Url + "\">" + cnode.Title + "</a>");
                    }
                    writer.Write("</div>");
                }
                else
                {
                    if (node == SiteMap.CurrentNode)
                    {
                        writer.Write("<li class=\"nav-item active\"><a class=\"nav-link\" href=\"" + node.Url + "\">" + node.Title + "</a>");
                    }
                    else
                    {
                        writer.Write("<li class=\"nav-item\"><a class=\"nav-link\" href=\"" + node.Url + "\">" + node.Title + "</a>");
                    }
                }
                writer.Write("</li>");
            }

            writer.Write("</ul>");



            //writer.Write("<ul class=\"navbar-nav mr-auto\">");
            //foreach (SiteMapNode node in SiteMap.RootNode.ChildNodes)
            //{
            //    if (node.HasChildNodes)
            //    {

            //    }
            //}
            //writer.Write("</ul>");
        }
    }
}
