using System;
using System.IO;

namespace oopXtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentFile myDataHandler = new StudentFile("students.txt");

            Student[] myStudents = myDataHandler.GetAllStudents();

            StudentReports reports = new StudentReports(myStudents);

            reports.PrintAllStudents();
        }
    }
}

