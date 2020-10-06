using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppTask1_17597280
{
    class RandomCalNum
    {
       
        public string GenerateNumbes()
        {

            var charNum = "123456789";
            var stringCharsNum = new char[3];
            var randomNum = new Random();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringCharsNum[i] = charNum[randomNum.Next(charNum.Length)];
            }

            var StringNum = new String(stringCharsNum);


            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var StringChars = new String(stringChars);

            string final = StringChars  + " " + StringNum;

            return final;

        }       
    }
}

