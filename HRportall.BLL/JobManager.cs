using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRportal.Data.MockRepositories;
using HRportal.Models;

namespace HRportall.BLL
{
    public class JobManager
    {
        private MockJobRepository repo = new MockJobRepository();
        public List<Job> GetAllJobs()
        {
            return repo.GetAllJobsByPosition();
        }

        public Job GetJob(string id)
        {
            return repo.GetJobByID(id);
        }

        public void AddJob(Job job)
        {
            repo.AddPosition(job);
        }

        public void EditJob(Job job)
        {
            repo.UpdatePosition(job);
        }

        public void DeleteJob(Job job)
        {
            repo.DeletePosition(job.JobId);
        }
    }
}
