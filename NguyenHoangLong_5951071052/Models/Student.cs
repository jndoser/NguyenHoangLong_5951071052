using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenHoangLong_5951071052.Models
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        [DataMember(Name = "mssv")]
        public string MSSV { get; set; }

        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        [DataMember(Name = "phoneNumber")]
        public int PhoneNumber { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }
    }
}