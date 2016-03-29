using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        // 建構式
        public Employee()
        {
        }

        // 建構式2
        public Employee(string id, string name, int baseSalary)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;
        }

        // 建構式3  將傳入的參數再轉傳至建構式2，就不用多寫一次了
        public Employee(string id, string name, string baseSalary)
            : this(id, name, int.Parse(baseSalary))
        {
        }

        //沒有要做什麼，所以直接寫get;set;
        public string Name { get; set; }

        public string Id { get; set; }
        protected double baseSalary;    // protected 是只讓繼承的人可以看到

        virtual public double BaseSalary    // 有virtual在前面才能夠讓繼承者修改裡面的判斷
        {
            // get 是當有人用.BaseSalary呼叫時，會回傳的東西
            get { return this.baseSalary; }
            // set 是設定.BaseSalary時，用來先預先處理，以免出錯的
            set
            {
                if (value > 50000)
                    this.baseSalary = 50000;
                else if (value >= 22000 && value <= 50000)
                    this.baseSalary = value;
                else
                    this.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("員工編號:{0}, 姓名:{1}\n",
                this.Id, this.Name);
            result += string.Format("基本薪資:{0}", this.BaseSalary);
            return result;
        }
    }
}