using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using HRportal.Data.MockRepositories;
using HRportal.Models;

namespace HRportall.BLL
{
    public class ResumeManager
    {
        private MockResumeRepository repo = new MockResumeRepository();

        public List<Resume> GetAllResumes()
        {
            return repo.GetAllResumes();
        }

        public List<Resume> GetAllResumesByJobId(string id)
        {
            return repo.GetAllResumes().Where(m=> m.JobApplyingFor.JobId == id).ToList();
        }

        public Resume GetResume(string id)
        {
            return repo.GetResumeById(id);
        }

        public void AddResume(Resume resume)
        {
            repo.AddResume(resume);
        }

        public void EditJob(Resume resume)
        {
            repo.UpdateResume(resume);
        }
    }
}
