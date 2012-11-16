using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RajSoftware.Models;
using System.Linq;

namespace RajSoftware.Controllers
{
    /// <summary>
    /// NewsController
    /// </summary>
    public class NewsController : Controller
    {
        public IDataRepository DataRepository { get; set; }

        public NewsController()
        {
            DataRepository = new DataRepository();
        }

        /// <summary>
        /// Details actions
        /// </summary>
        /// <returns></returns>
        public ActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public ActionResult News()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.News);

            IList<LinkItem> list = new List<LinkItem>();

            foreach (var item in items)
            {
                if (item.Date != null)
                {
                    DateTime date = DateTime.Parse(item.Date);

                    if (date > DateTime.Now)
                    {
                        var title = "<i>" + item.Title + "</i>";
                        item.Title = title;
                    }
                }

                list.Add(item);
            }

            return View(list);
        }

    }
}
