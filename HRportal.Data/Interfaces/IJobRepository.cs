using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRportal.Models;

namespace HRportal.Data.Interfaces
{
    public interface IJobRepository
    {
        Job GetJobByID(string id);
        List<Job> GetAllJobsByPosition();
        void AddPosition(Job job);
        void UpdatePosition(Job job);
        void DeletePosition(string id);
    }
}
