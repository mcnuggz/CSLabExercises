using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercises
{
    public class Exercise3
    {

        public void StringSplitter(string input)
        {
            int middle = 0;
            string split1;
            string split2;

            if(input.Length % 2 == 0)
            {
                middle = input.Length / 2;
                split1 = input.Substring(0, middle);
                split2 = input.Substring(middle);
                Console.WriteLine(split1);
                Console.WriteLine(split2);
            }
            else
            {
                middle = (int)(input.Length / 2);
                split1 = input.Substring(0, middle);
                split2 = input.Substring(middle);

                Console.WriteLine(split1);
                Console.WriteLine(split2);
            }


        }
    }
}
