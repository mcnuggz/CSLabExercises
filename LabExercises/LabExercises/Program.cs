using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise1 ex1 = new Exercise1();
            Exercise2 ex2 = new Exercise2();
            Exercise3 ex3 = new Exercise3();

            ex1.NumberCount();

            ex2.FindUserInfo();
            ex2.PrintInfo();

            Console.ReadLine();
        }
    }
}
