using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class26sept
{
     public class Student
    {
        public int id { get; set; }
        public string stuname { get; set; }
       
        public string city { get; set; }

        
    }
    public class Course//:IEnumerable
    {
        public int num { get; set; }
        public string cname { get; set; }
        public int fees { get; set; }   
        public Student[]students { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    return Course.GetEnumerator();
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student1 = new Student[]
            {
               new Student{id=1,stuname="Anil",city="Lonar"},
               new Student{id=2,stuname="Pavan",city="Pune"},
               new Student{id=3,stuname="Rahul",city="Kataraj"},
            };
            Student[] students2 = new Student[]
            {
                new Student{id=1,stuname="Uddhav",city="Koyali"},
                new Student{id=2,stuname="Renu",city="Mehakar"},
                new Student{id=3,stuname="Vrushali",city="Mumbia"}
            };
            Student[] students3 = new Student[]
            {
                new Student{id=1,stuname="Sham",city="Nagpur"},
                new Student{id=2,stuname="Ram",city="pune"},
                new Student{id=3,stuname="Shubham",city="Jalgao"},
                new Student{id=4,stuname="Atul",city="Buldhana"}
            };
            Course[] courses = new Course[]
            {
                new Course{num=1,cname="C#",fees=25000,students=student1},
                new Course{num=2,cname="Java",fees=50000,students=students2},
                new Course{num=3,cname="MVC",fees=30000,students=students3}
            };
            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.num}  {course.cname}  {course.fees}");
                foreach(Student s in course.students)
                {
                    Console.WriteLine($"\t {s.id} {s.stuname} {s.city}");
                }
            }





        }
    }
}
