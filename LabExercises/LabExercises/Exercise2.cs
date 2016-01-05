using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    public class Exercise2
    {
        private string color;
        private string firstName;
        private string lastName;

        public void FindUserInfo()
        {
            Console.WriteLine("Favorite Color?");
            color = Console.ReadLine();
            Console.WriteLine("First name?");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name?");
            lastName = Console.ReadLine();
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} is the favorite color of {1}, {2}", color, lastName, firstName);
        }
    }
}
