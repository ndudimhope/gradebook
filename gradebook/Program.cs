using System;

using System.Collections.Generic;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var grades= new List<double>() {12.1, 4.6, 10.3, 3.7};
            grades.Add(40.2);

            var result=0.0;

            foreach (var number in grades)
            {
                result += number;
            }

            result /=grades.Count;

            Console.WriteLine($"The Average Grade is {result:N1}");
        }
    }
}
