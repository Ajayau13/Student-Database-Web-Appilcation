using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentsDatabaseoAuth.Controllers
{  
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            using (StudentsDBEntities entities = new StudentsDBEntities())
            {
                return entities.Students.ToList();
            }
        }

        public object getStudentData()
        {
            using (StudentsDBEntities entities = new StudentsDBEntities())
            {
                return entities.Students.ToList();
            }
        }
    }
}
