using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oops_project;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.get();
            s.print();
            s = new teacher();
            s.get();
            s.print();
            s = new subject();
            s.get();
            s.print();

        }
    }
}
