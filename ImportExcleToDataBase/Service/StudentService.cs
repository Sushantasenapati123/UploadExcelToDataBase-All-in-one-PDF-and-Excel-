using ImportExcleToDataBase.Models;
using ImportExcleToDataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExcleToDataBase.Service
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _sturepo;

        public StudentService(IStudentRepository sturepo)
        {
            _sturepo = sturepo;
        }

        public async Task<int> InsertStudentService(StudentEntity se)
        {
            return await _sturepo.InsertStudent(se);
        }

        public async Task<List<StudentEntity>> GetAllStudentService()
        {
            return await _sturepo.GetAllStudent();
        }
    }
}
