using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            employeeCatagory.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Employee employee = null;
            if (employeeCatagory.SelectedIndex == 0)
            {
                employee = new Employee(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text);
            }
            else if (employeeCatagory.SelectedIndex == 2)
            {
                employee = new Manager(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, SalesCountTextBox.Text);
            }
            else
            {
                employee = new Sales(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text);
            }

            employees.Add(employee);
            UpdateEmployeesInfo();
        }

        private void UpdateEmployeesInfo()
        {
            infoRichTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            baseSalaryTextBox.Text = string.Empty;
            performanceTextBox.Text = string.Empty;
            SalesCountTextBox.Text = string.Empty;
            foreach (Employee employee in employees)
            {
                infoRichTextBox.Text += string.Format("{0}\n"
                    , employee);
            }
        }

        private void employeeCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            performanceLabel.Visible = employeeCatagory.SelectedIndex == 1;
            performanceTextBox.Visible = employeeCatagory.SelectedIndex == 1;
            SalesCountLabel.Visible = employeeCatagory.SelectedIndex == 2;
            SalesCountTextBox.Visible = employeeCatagory.SelectedIndex == 2;
        }
    }
}