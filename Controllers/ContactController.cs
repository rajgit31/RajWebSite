using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RajSoftware.Controllers
{
    /// <summary>
    /// ContactController
    /// </summary>
    public class ContactController : Controller
    {
        /// <summary>
        /// Details action
        /// </summary>
        /// <returns></returns>
        public ActionResult Details()
        {
            return View();
        }
    }
}
