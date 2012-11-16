using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RajSoftware.Models;

namespace RajSoftware.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    [HandleError]
    public class HomeController : Controller
    {
        public IDataRepository DataRepository { get; set; }

        public HomeController()
        {
            DataRepository = new DataRepository();
        }

        /// <summary>
        /// Displays action
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Display()
        {   
            return View();
        }

        /// <summary>
        /// Visuals the studio.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult VisualStudio()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.VisualStudio);
            return View(items);
        }

        /// <summary>
        /// ASPNET
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AspNet()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.ASPNET);
            return View(items);
        }

        /// <summary>
        /// C#
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CSharp()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.CSharp);
            return View(items);
        }

        /// <summary>
        /// UnitTests
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UnitTests()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.UnitTests);
            return View(items);
        }

        /// <summary>
        /// Patterns and Practices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult PnP()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.PNP);
            return View(items);
        }

        /// <summary>
        /// Books reviews.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult BookReviews()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.BookReviews);
            return View(items);
        }

        /// <summary>
        /// Books the reviews.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult BlogsList()
        {
            IEnumerable<LinkItem> items = DataRepository.GetData(LinkType.BlogsList);
            return View(items);
        }

       
    }
}
