using NguyenHoangLong_5951071052.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenHoangLong_5951071052.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var myInfoList = new List<Student>();

            for(int i = 0; i < 10; i++)
            {
                var studentInfo = new Student
                {
                    FullName = "Nguyen Hoang Long",
                    MSSV = "SV" + i,
                    Gender = "Nam",
                    PhoneNumber = i,
                    Address = "To " + i + " , KP. De Duc 2, Phuong Hoai Tan, TX. Hoai Nhon, Tinh Binh Dinh"
                };
                myInfoList.Add(studentInfo);
            }

            return myInfoList;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return new Student
            {
                FullName = "Nguyen Hoang Long",
                MSSV = "SV" + id,
                Gender = "Nam",
                PhoneNumber = 1234567 + id,
                Address = "To " + id + " , KP. De Duc 2, Phuong Hoai Tan, TX. Hoai Nhon, Tinh Binh Dinh"
            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
