using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLB7
{
    public class Healthmonitor
    {
        public void Warn(object sender, EventArgs e) 
        {
            Student student = (Student)sender;

            Console.WriteLine($"Внимание! У {student.Name} низкий балл {student.AverageGrade}");
        }
    }
}
