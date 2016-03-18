using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Num4 = 0;
            int TmpNum;
            string  userNum;
            int userNum1 = 0;
            int userNum2 = 0;
            int userNum3 = 0;
            int userNum4 = 0;
            int countA = 0;
            int countB = 0;
            // 一、隨機選出不重覆4個數字
            Random RandomNum = new Random();
            for (int index = 0; index < 4; index += 1) {
                if (index == 0)
                    Num1 = RandomNum.Next(1,10);
                else if (index == 1) {
                    TmpNum = RandomNum.Next(1, 10);
                    while (TmpNum == Num1 ){
                        TmpNum = RandomNum.Next(1, 10);
                    }
                    Num2 = TmpNum; 
                }
                else if (index == 2)
                {
                    TmpNum = RandomNum.Next(1, 10);
                    while (TmpNum == Num1 || TmpNum == Num2)
                    {
                        TmpNum = RandomNum.Next(1, 10);
                    }
                    Num3 = TmpNum;
                }
                else if (index == 3)
                {
                    TmpNum = RandomNum.Next(1, 10);
                    while (TmpNum == Num1 || TmpNum == Num2 || TmpNum == Num3)
                    {
                        TmpNum = RandomNum.Next(1, 10);
                    }
                    Num4 = TmpNum;
                }
            }
            Console.WriteLine("{0},{1},{2},{3}",Num1 ,Num2,Num3,Num4);
            // 二、判斷A or B
            while (countA != 4)
            {
                // 1.使用者是否輸入不重覆4個數字
                userNum = Console.ReadLine();
                TmpNum = 0;
                bool result = int.TryParse(userNum, out TmpNum);
                bool result2 = false;
                while (userNum.Length != 4 || result == false || result2 == false)
                {
                    if (userNum.Length != 4 || result == false)
                    {
                        Console.WriteLine("Please Check your Number.");
                        userNum = Console.ReadLine();
                        result = int.TryParse(userNum, out TmpNum);
                        //}
                        //while (result2 == true)
                        //{
                    }
                    else
                    {
                        userNum1 = int.Parse(userNum.Substring(0, 1));
                        userNum2 = int.Parse(userNum.Substring(1, 1));
                        userNum3 = int.Parse(userNum.Substring(2, 1));
                        userNum4 = int.Parse(userNum.Substring(3, 1));
                        Console.WriteLine("{0},{1},{2},{3}", userNum1, userNum2, userNum3, userNum4);

                        if ((!(userNum1 != userNum2 && userNum1 != userNum3 && userNum1 != userNum4) ||
                            !(userNum2 != userNum1 && userNum2 != userNum3 && userNum2 != userNum4) ||
                            !(userNum3 != userNum1 && userNum3 != userNum2 && userNum3 != userNum4)))
                        {
                            Console.WriteLine("Please Check your Number2.");
                            userNum = Console.ReadLine();
                        }
                        else
                            result2 = true;
                    }
                }
                Console.WriteLine("Number OK.");

                // 2.判斷A or B
                countA = 0;
                countB = 0;
                if (Num1 == userNum1)
                    countA++;
                if (Num2 == userNum2)
                    countA++;
                if (Num3 == userNum3)
                    countA++;
                if (Num4 == userNum4)
                    countA++;
                if (Num2 == userNum1 || Num3 == userNum1 || Num4 == userNum1)
                    countB++;
                if (Num1 == userNum2 || Num3 == userNum2 || Num4 == userNum2)
                    countB++;
                if (Num2 == userNum3 || Num1 == userNum3 || Num4 == userNum3)
                    countB++;
                if (Num2 == userNum4 || Num3 == userNum4 || Num1 == userNum4)
                    countB++;
                Console.WriteLine("{0}A{1}B", countA, countB);

            }
        }
    }
}
