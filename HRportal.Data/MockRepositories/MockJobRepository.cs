using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRportal.Data.Interfaces;
using HRportal.Models;

namespace HRportal.Data.MockRepositories
{
    public class MockJobRepository : IJobRepository
    {
        private List<Job> _jobs;
        public MockJobRepository()
        {
            _jobs = new List<Job>()
            {
                new Job()
                {
                    JobId = "Job1",
                    JobPosition = "C# Developer",
                    JobDescription = "Full time job",
                    JobRequirements = "Need 5 year experience"
                },
                new Job()
                {
                    JobId = "Job2",
                    JobPosition = "Cashier",
                    JobDescription = "Half time job",
                    JobRequirements = "Need 0-1 year experience"
                }
            };
        }

        public Job GetJobByID(string id)
        {
            return _jobs.FirstOrDefault(j => j.JobId == id);
        }


        public List<Job> GetAllJobsByPosition()
        {
            return _jobs;
        }

        public void AddPosition(Job job)
        {
            var newJob = new Job();
            newJob.JobPosition = job.JobPosition;
            newJob.JobDescription = job.JobDescription;
            newJob.JobRequirements = job.JobRequirements;

            newJob.JobId = _jobs.Max(c => c.JobId) + 1;
            _jobs.Add(newJob);
        }

        public void UpdatePosition(Job job)
        { 
            var selectedJob = _jobs.First(c => c.JobId == job.JobId);
            selectedJob.JobPosition = job.JobPosition;
            selectedJob.JobDescription = job.JobDescription;
            selectedJob.JobRequirements = job.JobRequirements;
        }

        public void DeletePosition(string id)
        {
            _jobs.RemoveAll(c => c.JobId == id);
        }
    }
}
