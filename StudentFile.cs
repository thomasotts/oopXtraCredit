using System;
using System.IO;

namespace oopXtraCredit
{
    public class StudentFile
    {
        private string fileName;

        public StudentFile(string fileName)
        {
            this.fileName = fileName;
        }

        public Student[] GetAllStudents()
        {
              Student.SetCount(0); 

              Student[] myStudents = new Student[50];

              StreamReader inFile = new StreamReader(fileName);
              string line = inFile.ReadLine();

              while(line != null)
              {
                    string[] temp = line.Split("#");
                    myStudents[Student.GetCount()] = new Student(temp[0], int.Parse(temp[1]), int.Parse(temp[2]), temp[3]); 
                    Student.IncCount();

                    line = inFile.ReadLine();
              }

              inFile.Close();
              return myStudents;
              
        }

    }
}