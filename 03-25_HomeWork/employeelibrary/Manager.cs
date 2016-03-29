using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int managementSalesCount;

        public int ManagementSalesCount
        {
            get
            {
                return managementSalesCount;
            }

            set
            {
                if (value < 0)
                    this.managementSalesCount = 0;
                else
                    this.managementSalesCount = value;
            }
        }

        // base是呼叫繼承的東西，這樣就可以只寫多出來的項目即可
        public Manager(string id, string name, int baseSalary, int managementSalesCount)
            : base(id, name, baseSalary)
        {
            this.ManagementSalesCount = managementSalesCount;
        }

        // 呼叫this，把不同型態的東西轉成同型態的東西，就不用再多一次
        public Manager(string id, string name, string baseSalary, string managementSalesCount)
            : this(id, name, int.Parse(baseSalary), int.Parse(managementSalesCount))
        { }

        // 當繼承的function中有virtaul ，繼承的項目就可以用override去重新訂義這個function
        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                // Manager
                if (value > 100000)
                    base.baseSalary = 100000;
                else if (value >= 50000 && value <= 100000)
                    base.baseSalary = value;
                else
                    base.baseSalary = 50000;
            }
        }
        private double bonus;
        public double Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                if (this.managementSalesCount > 20)
                {
                    value = (this.ManagementSalesCount * this.BaseSalary);
                    this.bonus = value;
                }
                else
                {
                    value = this.BaseSalary;
                    this.bonus = value;
                }
            }
        }

       


        public override string ToString()
        {
            return base.ToString() + string.Format("\n Sales數量:{0}，Manager總薪資：{1}"
                , this.ManagementSalesCount, this.BaseSalary );
        }
    }
}