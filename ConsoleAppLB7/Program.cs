using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLB7
{
    internal class Program
    {
        public static void Gaf() 
        {
            Console.WriteLine("Гаф");
        }
      
        static void Main(string[] args)
        {
             Action a = Gaf;
             Student student = new Student();
             Student student1 = new Student();
             Student student2 = new Student();
             Student student3 = new Student();

            student.SetSpeak(a);
            student1.SetSpeak(delegate () { Console.WriteLine("Я аноним");});
            student2.SetSpeak(() => Console.WriteLine("А я вот лямбда"));
            student3.SetSpeak(a);

        

            student.Speak();
            student1.Speak();
            student2.Speak();


            //student3.SpeakComparison(student1);
            //student3.SpeakComparison(student2);
            Console.WriteLine(student3.SpeakComparison(student));
            Console.WriteLine(student3.SpeakComparison(student2));

            student.AddSpeak(() => Console.WriteLine("Мяу?"));

            student.Speak();


            student.SetGainWeight((x) => student.Weight += x);
            student.GainWeight(30);
            Console.WriteLine(student.Weight);

            student2.Weight = 10;
            student2.SetGainWeight((x) => student2.Weight *= x);
            student2.GainWeight(30);
            Console.WriteLine(student2.Weight);


        }
    }
}
