using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRportal.Models;

namespace HRportal.Data.Interfaces
{
    public interface IResumeRepository
    {
        Resume GetResumeById(string id);
        void AddResume(Resume resume);
        void UpdateResume(Resume resume);
    }
}
