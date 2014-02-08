using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiQiWorkFlow.Application.Service.Archives;

namespace TEWorkFlow.Web.Client.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public IFbGoodsArchivesService FbGoodsArchivesService { get; set; }
        public ActionResult Index()
        {
            //return Json(FbGoodsArchivesService.GetAll(), JsonRequestBehavior.AllowGet);
            return View();
        }

    }
}
