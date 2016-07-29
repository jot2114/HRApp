using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRportal.Data.Interfaces;
using HRportal.Models;

namespace HRportal.Data.MockRepositories
{
    public class MockResumeRepository :IResumeRepository
    {
        private List<Resume> _resumes;

        public MockResumeRepository()
        {
            _resumes = new List<Resume>()
            {
                new Resume()
                {
                    Name = "qwerr",
                    //Address = "C# Developer",
                    PhoneNumber = "Full time job",
                    EmailId = "Need 5 year experience",
                    Dob = new DateTime(1990,12,12),
                    education = new Education() {Degree = "B.Tech",YearOfPassing = new DateTime(2010,12,12),School = "qwe"},
                    workHistory = new WorkEx() {Years = 1,CompanyName = "SGguild",JobPosition = "Teaching Assistant"},
                    JobApplyingFor = new Job() {JobId = "Tech01",JobPosition = "Developer",JobDescription = "Fulltime",JobRequirements = "1 year experience"},
                },
            };
        }

        public List<Resume> GetAllResumes()
        {
            return _resumes;
        }

        public Resume GetResumeById(string id)
        {
            return _resumes.FirstOrDefault(j => j.JobApplyingFor.JobId == id);
        }

        public void AddResume(Resume resume)
        {
            resume.JobApplyingFor.JobId = _resumes.Max(j => j.JobApplyingFor.JobId) + 1;
            _resumes.Add(resume);

        }

        public void UpdateResume(Resume resume)
        {
            var resumeToUpdate = _resumes.FirstOrDefault(c => c.JobApplyingFor.JobId == resume.JobApplyingFor.JobId);
            resumeToUpdate.Name = resume.Name;
        }

    }
}
