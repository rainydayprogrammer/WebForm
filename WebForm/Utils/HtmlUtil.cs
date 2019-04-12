using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.Utils
{
    public static class HtmlUtil
    {
        public static string TextSearchLink(string targetString)
        {
            return "<a href='#' onclick=\"highlightKeyword('" + targetString + "');\"> " + targetString + "</a>";
        }
    }
}