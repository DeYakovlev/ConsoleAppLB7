using ConsoleAppLB7;
using System;
using System.Xml.Linq;

namespace ConsoleAppLB7
{
    public class Student : Person
    {
        public string Group { get; set; }
        public double AverageGrade { get; set; }

        public Student() { }

        public Student(string name, int age, string group, double averageGrade)
            : base(name, age)
        {
            Group = group;
            AverageGrade = averageGrade;
        }

        public override string ToString()
            => $"{Name}, {Age} лет, группа {Group}, средний балл {AverageGrade}";
    }
}