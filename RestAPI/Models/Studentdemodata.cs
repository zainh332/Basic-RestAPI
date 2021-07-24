using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class studentdemodata
    { public int rollno { get; set; }
        public string name { get; set; }
        public string course { get; set; }
    }

    public class studentdatalist
    {
        public List<studentdemodata> std { get; set; } = null;
        public studentdatalist()
        {
            std = new List<studentdemodata>();
            studentdemodata sd = new studentdemodata();
            sd.rollno = 123;
            sd.name = "Zain";
            sd.course = "OOP";
            std.Add(sd);

            sd = new studentdemodata();
            sd.rollno = 124;
            sd.name = "Ali";
            sd.course = "Data Structure";
            std.Add(sd);

            sd = new studentdemodata();
            sd.rollno = 124;
            sd.name = "John";
            sd.course = "Design Patterns";
            std.Add(sd);
        }
    }
}