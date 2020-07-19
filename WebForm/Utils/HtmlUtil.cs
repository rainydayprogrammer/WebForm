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
            return String.Format(@"<a href='#' onclick=""highlightKeyword('{0}');"">{0}</a>", targetString);
        }

        public static string TextHighlight(string orgString, string keyWord)
        {
            string repstr = string.Format(@"<span class=""bg-warning"">{0}</span>", keyWord);
            return orgString.Replace(keyWord, repstr);
        }
    }
}