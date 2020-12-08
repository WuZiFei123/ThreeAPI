using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace ThreeAPI.Controllers
{
    public class StudentController : ApiController
    {
        StudentBLL bll = new StudentBLL();
        [HttpGet]
        public IHttpActionResult Show()
        {
            return Ok(bll.GetStudents());
        }
        [HttpPost]
        public int AddStudent(Student s)
        {
            return bll.AddStudent(s);
        }
    }
}
