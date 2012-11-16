using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RajSoftware.Models
{
    public class LinkItem
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string Description { get; set; }

        public LinkType Type { get; set; }

        public string Date { get; set; }
    }

    public enum LinkType
    {
        VisualStudio,
        ASPNET,
        CSharp,
        UnitTests,
        PNP,
        BookReviews,
        BlogsList,
        Undefined,
        News
    }
}
