using ImportExcleToDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExcleToDataBase.Repository
{
    public interface IStudentRepository
    {
        List<StudentEntity> GetAllStudent();
        Task<int> InsertStudent(StudentEntity se);
    }
}
