using System;
using System.Collections.Generic;
using System.Text;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public int _studentID { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public string _studyProgram { get; set; }


        public Student(int studentId, string name, int age, string studyProgram)
        {
            _studentID = studentId;
            _name = name;
            _age = age;
            _studyProgram = studyProgram;
        }

        public static void SkrivUtInfo()
        {
            Console.WriteLine($"StudentId: {_studentID} \nNavn: {_name} \nAlder: {_age}\nStudieProgram: {_studyProgram}");
        }
    }
}
