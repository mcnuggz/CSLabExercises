using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    public class Exercise5
    {
        public void RepeatWord(string input)
        {
            string word = input;
            char[] letters = word.ToCharArray();
            string output = String.Concat(Enumerable.Repeat(input + " ", letters.Length));
            Console.WriteLine(output);
        }
    }
}
