using IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroToAPI.Controllers
{
    public class StudentController : ApiController
    {
        List<Student> students = new List<Student>()
            {
                new Student() { SId = 1,SName = "John",Sem1 = 80,Sem2 = 85,Sem3 = 78,Sem4 = 83},
                new Student() { SId = 2,SName = "Levi",Sem1 = 90,Sem2 = 93,Sem3 = 88,Sem4 = 77},
                new Student() { SId = 3,SName = "Peter",Sem1 = 70,Sem2 = 74,Sem3 = 82,Sem4 = 79},
                new Student() { SId = 4,SName = "Maria",Sem1 = 70,Sem2 = 85,Sem3 = 98,Sem4 = 78},
                new Student() { SId = 5,SName = "Angel",Sem1 = 100,Sem2 = 94,Sem3 = 97,Sem4 = 90},
            };
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            var student = students.FirstOrDefault(o => o.SId == id);
            return student.ToString();
        }

        // POST: api/Student
        
        
    }
}
