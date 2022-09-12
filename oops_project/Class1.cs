using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_project
{
    public class student

    {
            public string name;
            public int classes;
            public char section;

            public virtual void get()
            {
                Console.WriteLine("To Enter the Student Details");
                Console.WriteLine();
                Console.WriteLine("Enter the Student name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the class:");
                classes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the section:");
                section = Convert.ToChar(Console.ReadLine());
            }
            public virtual void print()
            {
                Console.WriteLine();
                Console.WriteLine("Printing Student details");
                Console.WriteLine();
                Console.WriteLine("Student Name:"+ name);
                Console.WriteLine("Class:" + classes);
                Console.WriteLine("Section:" + section);
            }
        }
        public class teacher : student
        {
            public string subject;
            public override void get()
            {
                Console.WriteLine();
                Console.WriteLine("To Enter the Teacher details");
                Console.WriteLine();
                Console.WriteLine("Enter the Teacher name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the class:");
                classes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the section:");
                section = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the Subject name:");
                subject = Console.ReadLine();
            }
            public override void print()
            {
                Console.WriteLine();
                Console.WriteLine("Printing Teacher Details");
                Console.WriteLine();
                Console.WriteLine("Teacher Name:" + name);
                Console.WriteLine("Class:" + classes);
                Console.WriteLine("Section:" + section);
                Console.WriteLine("Subject:" + subject);
            }
        }
        public class subject : student
        {
            public string subject_code;
            public override void get()
            {
                Console.WriteLine();
                Console.WriteLine("To Enter the Subject Details");
                Console.WriteLine();
                Console.WriteLine("Enter the subject name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the subject code");
                subject_code = Console.ReadLine();

            }
            public override void print()
            {
                Console.WriteLine();
                Console.WriteLine("Printing Subject Details");
                Console.WriteLine();
                Console.WriteLine("Subject Name:" + name);
                Console.WriteLine("Subject Code:" + subject_code);
                Console.ReadLine();
            }
        }
    }

