using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Student
    {
        //private string name;

        public string Name { get; set; }

        public Grade[] grades;

        public Student()
        {
        }

        public Student(string name, double chinese, double english, double math)
        {
            this.Name = name;

            this.grades = new Grade[3]
            {
                new Grade { subject = "國文" },
                new Grade { subject = "英文"},
                new Grade { subject = "數學"}
            };
            this.grades[0].Value = chinese;
            this.grades[1].Value = english;
            this.grades[2].Value = math;
        }

        public double TotalGrade
        {
            get
            {
                double total = 0.0;
                for (int index = 0; index < this.grades.Length; index++)
                {
                    total = total + grades[index].Value;
                }
                return total;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("學生:{0}\n", this.Name);
            result += string.Format("{0}\n", this.grades[0]);
            result += string.Format("{0}\n", this.grades[1]);
            result += string.Format("{0}\n", this.grades[2]);
            result += string.Format("總分:{0}", this.TotalGrade);
            return result;
        }
    }
}