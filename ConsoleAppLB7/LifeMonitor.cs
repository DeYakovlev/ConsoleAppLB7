using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLB7
{
    public class LifeMonitor
    {
        public static void Critical(object sender, EventArgs e) 
        {
            Student student = (Student)sender;
            Console.WriteLine($" Критическая ситуация! Студент {student.Name} отчислен!");
        }
    }
}
