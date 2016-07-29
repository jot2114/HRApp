using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRportal.Models;
using HRportall.BLL;

namespace HRportal.Controllers
{
    public class JobController : Controller
    {

        [HttpGet]
        public ActionResult Jobs()
        {
            var manager = new JobManager();
            var model = manager.GetAllJobs();
            return View(model.ToList());
        }

        [HttpGet]
        public ActionResult AddJob()
        {
            return View(new Job());
        }

        [HttpPost]
        public ActionResult AddJob(Job job)
        {
            var manager = new JobManager();
            manager.AddJob(job);
            return RedirectToAction("Jobs");
        }

        [HttpGet]
        public ActionResult EditJob(string id)
        {
            var manager = new JobManager();
            var model = manager.GetJob(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditJob(Job job)
        {
            var manager = new JobManager();
            manager.EditJob(job);
            return RedirectToAction("Jobs");
        }

        [HttpGet]
        public ActionResult DeleteJob(string id)
        {
            var manager = new JobManager();
            var model = manager.GetJob(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeleteJob(Job job)
        {
            var manager = new JobManager();
            manager.DeleteJob(job);
            return RedirectToAction("Jobs");
        }

        [HttpGet]
        public ActionResult Resumes()
        {
            var manager = new ResumeManager();
            var model = manager.GetAllResumes();
            return View(model.ToList());
        }

        [HttpGet]
        public ActionResult SingleResume(string id)
        {
            var manager = new ResumeManager();
            var resume = manager.GetResume(id);
            return View(resume);
        }


    }
}