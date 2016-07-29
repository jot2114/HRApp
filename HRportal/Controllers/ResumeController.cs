using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRportal.Models;
using HRportall.BLL;

namespace HRportal.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
        public ActionResult Jobs()
        {
            var manager = new JobManager();
            var model = manager.GetAllJobs();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddResume(string id)
        {
            var resume = new Resume();
            var jobManager = new JobManager();
            resume.JobApplyingFor = jobManager.GetJob(id);
            return View(resume);
        }

        [HttpPost]
        public ActionResult AddResume(Resume resume)
        {
            var manager = new ResumeManager();
            manager.AddResume(resume);
            return View("SubmissionDone",resume);
        }

    }
}