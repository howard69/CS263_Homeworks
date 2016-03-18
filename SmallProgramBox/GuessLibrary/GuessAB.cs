using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessLibrary
{
    public class GuessAB
    {
        static int[] result = new int[2];
        static int countA = 0;
        static int countB = 0;
        public static int[] AorB(int[] Num, int[] userNum  )
        {
            // Initial
            countA = 0;
            countB = 0;
            // Start
            for (int i = 0; i < Num.Count(); i++)
            {
                if (Num[i] == userNum[i])
                    countA++;
            }
            if (Num[0] == userNum[1] || Num[0] == userNum[2] || Num[0] == userNum[3])
                countB++;
            if (Num[1] == userNum[0] || Num[1] == userNum[2] || Num[1] == userNum[3])
                countB++;
            if (Num[2] == userNum[1] || Num[2] == userNum[0] || Num[2] == userNum[3])
                countB++;
            if (Num[3] == userNum[1] || Num[3] == userNum[2] || Num[3] == userNum[0])
                countB++;

            /*
            if (Num2 == userNum[0] || Num3 == userNum[0] || Num4 == userNum[0])
                countB++;
            if (Num[0] == userNum2 || Num3 == userNum2 || Num4 == userNum2)
                countB++;
            if (Num2 == userNum3 || Num[0] == userNum3 || Num4 == userNum3)
                countB++;
            if (Num2 == userNum4 || Num3 == userNum4 || Num[0] == userNum4)
                countB++;
            */
            result[0]=countA;
            result[1] = countB;
            return result;
        }
    }
}
