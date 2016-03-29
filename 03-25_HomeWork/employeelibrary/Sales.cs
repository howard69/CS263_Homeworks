using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Sales : Employee
    {
        private int performance;

        public int Performance
        {
            get { return this.performance; }
            set
            {
                if (value < 0)
                    this.performance = 0;
                if (value > 100)
                    this.performance = 100;
                else
                    this.performance = value;
            }
        }

        // base是呼叫繼承的東西，這樣就可以只寫多出來的項目即可
        public Sales(string id, string name, int baseSalary, int performance)
            : base(id, name, baseSalary)
        {
            this.Performance = performance;
        }

        // 呼叫this，把不同型態的東西轉成同型態的東西，就不用再多一次
        public Sales(string id, string name, string baseSalary, string performance)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance))
        { }

        // 當繼承的function中有virtual ，繼承的項目就可以用override去重新訂義這個function
        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                // sales改成固定22000
                base.baseSalary = 22000;
            }
        }

        // ToString  不用virtual 就可以override
        // 這邊是把原本的ToString資料再加上Sales特有的項目
        public override string ToString()
        {
            return base.ToString() + string.Format("\n業績:{0}\n Sales總薪資：{1}\n"
                , this.Performance, this.BaseSalary * this.Performance);
        }
    }
}