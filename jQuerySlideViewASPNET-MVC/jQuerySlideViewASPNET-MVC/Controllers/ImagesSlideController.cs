using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using jQuerySlideViewASPNET_MVC.DatabaseContext;
using jQuerySlideViewASPNET_MVC.Models;

namespace jQuerySlideViewASPNET_MVC.Controllers
{
    public class ImagesSlideController : Controller
    {
        // GET: ImagesSlide
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentInformationVm studentInformationVm)
        {
            var model = Mapper.Map<StudentInformation>(studentInformationVm); 

            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension=Path.GetExtension(model.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            model.ImagePath = "~/Image" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image"), fileName); 
            model.ImageFile.SaveAs(fileName);
           
            using (Db db = new Db())
            {
                db.StudentInformations.Add(model);
                db.SaveChanges();
            }  
            ModelState.Clear();
 

            return RedirectToAction("Add");
        }
    }
}