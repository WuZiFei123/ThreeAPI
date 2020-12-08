using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        public List<Student> GetStudents()
        {
            string sql = "select * from Student";
            return DBHelper.GetList<Student>(sql);
        }
        public int AddStudent(Student s)
        {
            string sql = $"insert into Student values('{s.Sname}',{s.Sage},'{s.Simg}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
