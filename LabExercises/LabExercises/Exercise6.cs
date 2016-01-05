using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    public class Exercise6
    {
        public void PrintByIndex()
        {
            Console.WriteLine("Enter any word");
            string word = Console.ReadLine().ToUpper();

            Console.WriteLine("Pick a number based on the word you entered. (First letter starts at 0)");
            int letterNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(word[letterNum]);
        }
    }
}
