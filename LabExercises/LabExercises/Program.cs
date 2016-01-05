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
            //Exercise1 ex1 = new Exercise1();
            //Exercise2 ex2 = new Exercise2();
            Exercise3 ex3 = new Exercise3();
            //Exercise5 ex5 = new Exercise5();
            //Exercise6 ex6 = new Exercise6();

            //ex1.NumberCount();

            //ex2.FindUserInfo();
            //ex2.PrintInfo();

            ex3.StringSplitter("bacon", "ham", "pepperoni", "beef", "pizza", "tacos");

            //ex5.RepeatWord("Hola");
            //ex6.PrintByIndex();

            Console.ReadLine();
        }
    }
}
