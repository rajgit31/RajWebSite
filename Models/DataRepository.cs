using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using urn.items;
using System.Linq.Expressions;
using System.Diagnostics;
using System.IO;
using System.Globalization;


namespace RajSoftware.Models
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<LinkItem> GetData(LinkType type)
        {
            urn.items.items m_its_database = LoadData() as urn.items.items;

            if (m_its_database != null)
            {
                IList<LinkItem> itemsList = new List<LinkItem>();

                var items = from i in m_its_database.item
                            select i;

                foreach (var item in items)
                {
                    var linkItem = new LinkItem()
                    {
                        Link = item.url,
                        Title = item.title,
                        Description = item.description,
                        Date = item.date != DateTime.MinValue ? GetDate(item.date, item.type) : null,
                        Type = GetLinkType(item.type)

                    };

                    itemsList.Add(linkItem);
                }

                return itemsList.Where(c => c.Type == type);
            }

            return null;

        }


        private string GetDate(DateTime date, string itemType)
        {            
            if (itemType.Equals(LinkType.News.ToString()))
            {
                return date.ToString();
            }

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(date.Month);
            string year = date.Year.ToString();
            return monthName + ' ' + year;
        }



        private object LoadData()
        {
            try
            {
                return urn.items.items.Load(HttpContext.Current.Server.MapPath(@"~\Data\Data.xml"));
            }
            catch (Exception exc)
            {
                throw new FileLoadException("Unable to load the xml data file");
            }
        }


        private LinkType GetLinkType(string type)
        {
            switch (type)
            {
                case "VisualStudio": return LinkType.VisualStudio;
                    break;
                case "ASPNET": return LinkType.ASPNET;
                    break;
                case "PnP": return LinkType.PNP;
                    break;
                case "BookReviews": return LinkType.BookReviews;
                    break;
                case "BlogsList": return LinkType.BlogsList;
                    break;
                case "News": return LinkType.News;
                    break;
                case "CSharp": return LinkType.CSharp;
                    break;
                case "UnitTests": return LinkType.UnitTests;
                    break;
                default:
                    break;
            }

            return LinkType.Undefined;

        }
    }
}


    