using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlleEx1._1.Controllers
{
    public class Ex1Controller : Controller
    {
        List<String> breakingNews = new List<String>()      //DO NOT change this declaration and values
        {
            "PM visit brings business","10% slash in GST","Top Player announced retirement","India wins series"
        };
        // GET: Ex1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllNews()
        {
            string temp = "";
            foreach(var q in breakingNews)
            {
                temp = temp + q + "</br>";
            }
            
            return Content(temp);
        }

        public ActionResult NewsByChoice(int id)
        {
            int count = 1;
            string temp = "";
            foreach(var q in breakingNews)
            {
                temp = q;
                if(count == id)
                {
                    break;
                }
                count++;
            }
            return Content(temp);
        }
    }
}