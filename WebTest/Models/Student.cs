using System;
using System.Linq;
using System.Text;

namespace Models
{
    public class Student
    {
        
        public Int64 id {get;set;}

        public string name {get;set;}

        public Int64 sch_id {get;set;}

        public string sex {get;set;}

        public Int64 isOk {get;set;}

        public int FieldInt { get; set; }

        public bool FieldBool { get; set; }

        public DateTime FieldDateTime { get; set; }

        public decimal FieldNumber { get; set; }
    }
}
