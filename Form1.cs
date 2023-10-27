using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
  
    public partial class Form1 : Form
    {
        public class Employee
        {
            public string Name { get; set; }
            public string EmployeeID { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
         private List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            {
                Name = txtName.Text,
                EmployeeID = txtEmployeeID.Text,
                Department = txtDepartment.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };

            employees.Add(newEmployee);

            // Clear the text boxes
            txtName.Clear();
            txtEmployeeID.Clear();
            txtDepartment.Clear();
            txtSalary.Clear();
        }
    }
}
