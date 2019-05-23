using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace UrlCustomize.Areas.Blog.Controllers
{
    public class AzureController : Controller
    {
        // GET: Blog/Azure
        public ActionResult Index()
        {
            return View();
        }

        // GET: Blog/Azure/DevOps/
        // GET: Blog/Azure/DevOps/2019/
        // GET: Blog/Azure/DevOps/2019/1001/
        // GET: Blog/Azure/DevOps/2019/1001/Introductions/
        // GET: Blog/Azure/DevOps?date=2019&serial=1001&article=AspNetMvc

        [HttpGet]
        public ActionResult DevOps(string date, string serial, string article)
        {

            if (!date.IsNullOrWhiteSpace() && !serial.IsNullOrWhiteSpace() && !article.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "Date-" + date + ", Serial-" + serial + " & Article-" + article;
                return View();
            }
            if (!date.IsNullOrWhiteSpace() && !serial.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "Date-" + date + ", Serial-" + serial;
                return View();
            }
            if (!date.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "Date-" + date;
                return View();
            }

            return View();
        }
    }
}