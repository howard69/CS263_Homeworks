using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Generate
    {
        public static  bool IsNumberic(string sNum)
        {
            bool StringOK = true;

            return StringOK;
        }

        public static void SetStudent() {

            Console.WriteLine("請輸入學生數量：");
            int studentCount = int.Parse(Console.ReadLine ());

            for (int i = 1; i <= studentCount; i++)
            {
                Student student = new Student() { Name = "Resnick" };
                string name = string.Empty;
                int chinese = 0;
                int english = 0;
                int math = 0;
                Console.Write("請輸入第{0}位學生姓名:",i);
                name = Console.ReadLine();

                do
                {
                    Console.Write("請輸入國文成績:");
                } while (!int.TryParse(Console.ReadLine(), out chinese));

                do
                {
                    Console.Write("請輸入英文成績:");
                } while (!int.TryParse(Console.ReadLine(), out english));

                do
                {
                    Console.Write("請輸入數學成績:");
                } while (!int.TryParse(Console.ReadLine(), out math));


                student = new Student(name, chinese, english, math);

                Console.WriteLine(student+"\n");
            }
        }
    }
}
