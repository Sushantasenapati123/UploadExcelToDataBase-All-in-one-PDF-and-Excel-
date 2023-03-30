using Dapper;
using ImportExcleToDataBase.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExcleToDataBase.Repository
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> InsertStudent(StudentEntity se)
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@STUD_NAME", se.STUD_NAME);
                param.Add("@TOTAL_MARK", se.TOTAL_MARK);
                param.Add("@OBTAINED_MARK", se.OBTAINED_MARK);
               
                param.Add("@ACTION", "INSERT");
                param.Add("@P_MSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                cn.Execute("SP_STUDENT_MARKLIST", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@P_MSGOUT"));
                cn.Close();
                return x;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<List<StudentEntity>> GetAllStudent()
        {
            try
            {
                var cn = CreateConnection();
                if (cn.State == ConnectionState.Closed) cn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ACTION", "SELECTALL");
                param.Add("@P_MSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var lstStudent = cn.Query<StudentEntity>("SP_STUDENT_MARKLIST", param, commandType: CommandType.StoredProcedure).ToList();
                return lstStudent;
            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
