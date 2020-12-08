using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();
        public List<Student> GetStudents()
        {
            return dal.GetStudents();
        }
        public int AddStudent(Student s)
        {
            return dal.AddStudent(s);
        }
    }
}
