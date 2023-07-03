using ImportExcleToDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExcleToDataBase.Service
{
    public interface IStudentService
    {
        List<StudentEntity> GetAllStudentService();
        Task<int> InsertStudentService(StudentEntity se);
    }
}
