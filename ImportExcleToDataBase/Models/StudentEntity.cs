using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExcleToDataBase.Models
{
    public class StudentEntity
    {
        public int STUD_ID { get; set; } = 0;
        public string STUD_NAME { get; set; } = null;
        public int TOTAL_MARK { get; set; } = 0;
        public int OBTAINED_MARK { get; set; } = 0;
        public Double PERCENTAGE_MARK { get; set; } = 0.0;
        public string Grade { get; set; } = null;
    }
}
