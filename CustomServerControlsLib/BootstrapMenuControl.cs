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
                    writer.Write("<a href=\"{0}\"class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\"", node.Url);
                    writer.Write(" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\"");
                    writer.Write(">{0}</a>", node.Title);
                    writer.Write("<div class=\"dropdown-menu\">");
                    foreach (SiteMapNode cnode in node.ChildNodes)
                    {
                        writer.Write("<a class=\"dropdown-item\" href=\"{0}\">{1}</a>", cnode.Url, cnode.Title);
                    }
                    writer.Write("</div>");
                }
                else
                {
                    if (node == SiteMap.CurrentNode)
                    {
                        writer.Write("<li class=\"nav-item active\">");
                    }
                    else
                    {
                        writer.Write("<li class=\"nav-item\">");
                    }
                    writer.Write("<a class=\"nav-link\" href=\"{0}\">{1}</a>", node.Url, node.Title);

                }
                writer.Write("</li>");
            }

            writer.Write("</ul>");
        }
    }
}
