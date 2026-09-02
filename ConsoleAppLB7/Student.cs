using ConsoleAppLB7;
using System;
using System.Xml.Linq;

namespace ConsoleAppLB7
{
    public class Student : Person
    {
        private Action _speak;

        private Action<double> _gainWeight;
        public string Group { get; set; }
        public double AverageGrade { get; set; }

        public double Weight { get; set; }

        public Student() { }

        public Student(string name, int age, string group, double averageGrade)
            : base(name, age)
        {
            Group = group;
            AverageGrade = averageGrade;
        }

        public override string ToString()
            => $"{Name}, {Age} лет, группа {Group}, средний балл {AverageGrade}";

        public void SetSpeak(Action action) 
        {
            _speak = action;
            
        }

        public void SetGainWeight(Action<double> action) 
        {
            _gainWeight = action;

        }

        public void AddSpeak(Action action) 
        {
            _speak += action;
        }

        public void GainWeight(double amount) 
        {
            _gainWeight?.Invoke(amount);
        }

        public void Speak() 
        {
            _speak?.Invoke();
        }

        public bool SpeakComparison(Student student) 
        {
            return this._speak == student._speak;
        }
    }
}