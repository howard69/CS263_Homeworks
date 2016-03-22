using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Grade
    {
        private double value;
        private string level;
        public string subject;

        public double Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value > 100)
                    this.value = 100;
                else if (value < 0)
                    this.value = 0;
                else
                    this.value = value;
                //return this;
            }
        }

        public string Level
        {
            get
            {
                if (this.value >= 90)
                {
                    this.level = "A+";
                }
                else if (this.value >= 85 && this.value < 90)
                {
                    this.level = "A";
                }
                else if (this.value >= 80 && this.value < 85)
                {
                    this.level = "A-";
                }
                else if (this.value >= 70 && this.value < 80)
                {
                    this.level = "B";
                }
                else if (this.value >= 60 && this.value < 70)
                {
                    this.level = "C";
                }
                else if (this.value >= 50 && this.value < 60)
                {
                    this.level = "D";
                }
                else
                {
                    this.level = "F";
                }

                return this.level;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("科目名稱:{0}\n", this.subject);
            result += string.Format("百分制成績:{0}\n", this.value);
            result += string.Format("等第制成績:{0}", this.Level);
            return result;
        }
    }
}