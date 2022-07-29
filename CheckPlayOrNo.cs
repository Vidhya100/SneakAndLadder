using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakAndLadder
{
    public static class CheckPlayOrNo
    {
        public static void CheckSneakOrLadder()
        {
            int startPoint = 0;

            Random random = new Random();
            int roll = (random.Next(1, 6) + 1);
            Console.WriteLine("roll : " + roll);

            
        }
    }
}
