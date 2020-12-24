using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace LianXi_AJAX_MVC.Controllers
{
    public class LianXiController : Controller
    {
        // GET: LianXi
        //分页查询试图
        public ActionResult FenYe()
        {
            return View();
        }
        //主页页面试图
        public ActionResult Index()
        {
            return View();
        }
        //新增页面试图
        public ActionResult insert()
        {
            return View();
        }
        //修改页面试图
        public ActionResult aaaa()
        {
            return View();
        }
        //aa表查询全部信息
        public ActionResult GetaaAll()
        {
            return Json(aaManager.GetaaAll(),JsonRequestBehavior.AllowGet);
        }
        //aa新增
        public ActionResult aaAdd(aa a)
        {
            return Json(aaManager.aaAdd(a), JsonRequestBehavior.AllowGet);
        }
        //aa删除
        public ActionResult Del(int id)
        {
            return Json(aaManager.Del(id),JsonRequestBehavior.AllowGet);
        }
        //修改根据ID先查询全部信息
        public ActionResult GetById(int id)
        {
            return Json(aaManager.GetById(id),JsonRequestBehavior.AllowGet);
        }
        //aa修改
        public ActionResult Edit(aa a)
        {
            return Json(aaManager.Edit(a),JsonRequestBehavior.AllowGet);
        }
        //分页查询
        public ActionResult PageListAA(int PageIndex, int PageSize)
        {
            return Json(fenyeManager.PageListAA(PageIndex, PageSize),JsonRequestBehavior.AllowGet);
        }
    }
}