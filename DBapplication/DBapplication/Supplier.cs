using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Supplier : Form
    {
        Controller controllerObj;

        public Supplier()
        {
            InitializeComponent();
        }

        private bool CheckData_Insert()
        {

            ////////////////////////// Mandatory Data////////////////////////////
            if (MiddleName.TextLength > 1)
                MiddleName.Text = MiddleName.Text.Substring(0, 1);

            if (String.IsNullOrEmpty(MiddleName.Text))
            {
                MessageBox.Show("Data is missing");
                return false;
            }
            if (String.IsNullOrEmpty(FirstName.Text))
            {
                MessageBox.Show("Data is missing");
                return false;
            }
            if (String.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Data is missing");
                return false;
            }
            if (String.IsNullOrEmpty(sNumTextBox.Text))
            {
                MessageBox.Show("Data is missing");
                return false;
            }
            /////////////////////////////////////////Optional Data //////////////////////////
            if (String.IsNullOrEmpty(BirthDate.Text))
            {
                BirthDate.Text = "NULL";
            }
            if (String.IsNullOrEmpty(Address.Text))
            {
                Address.Text = "NULL";
            }
            if (String.IsNullOrEmpty(Salary.Text))
            {
                Salary.Text = "NULL";
            }
            if (String.IsNullOrEmpty(ManagerSSN.Text))
            {
                ManagerSSN.Text = "NULL";
            }
            if (String.IsNullOrEmpty(DeptNum.Text))
            {
                DeptNum.Text = "NULL";
            }

            return true;
        }









        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            Sex.SelectedIndex = 0;
        }
        private void insertButton_Click(object sender, EventArgs e)
        {

            if (!CheckData_Insert())
            {
                return;
            }

            String[] employee_details = new String[10] { FirstName.Text, MiddleName.Text, LastName.Text, sNumTextBox.Text, BirthDate.Text, Address.Text, Sex.Text, Salary.Text, ManagerSSN.Text, DeptNum.Text };

            int result = controllerObj.Insert_Employee(employee_details);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Supplier failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ProjectNumDel.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }
            int result = controllerObj.DeleteProject(Int16.Parse(ProjectNumDel.Text));
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Enum.Text))
            {
                MessageBox.Show("No Employee Is selected");
                return;
            }

            if (String.IsNullOrEmpty(Mnum.Text) || String.IsNullOrEmpty(Dnum.Text) || String.IsNullOrEmpty(SalaryUpdate.Text) || String.IsNullOrEmpty(AddressUpdate.Text))
            {
                MessageBox.Show("Datat Is missing");
                return;
            }

            int result = controllerObj.UpdateAll(Enum.Text, Mnum.Text, Dnum.Text, SalaryUpdate.Text, AddressUpdate.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(DeptNumGet.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }

            DataTable dt = controllerObj.SelectAllEmployees(Int16.Parse(DeptNumGet.Text));
            EmployeesDataGrid.DataSource = dt;
            EmployeesDataGrid.Refresh();


        }

        private void countButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(ProjectNumCount.Text))
            {

                MessageBox.Show("Missing Data");
                return;
            }

            countTextBox.Text = controllerObj.CountProjects(Int16.Parse(ProjectNumCount.Text)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }



        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sNumTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Dnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptNumGet_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptNum_Click(object sender, EventArgs e)
        {

        }

        private void DeptNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDep_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Dnum.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }
            int result = controllerObj.UpdateDepartment(Enum.Text, Dnum.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void UpdateSal_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(SalaryUpdate.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }
            int result = controllerObj.UpdateSalary(Enum.Text, SalaryUpdate.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }

        }

        private void UpdateManager_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Mnum.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }
            int result = controllerObj.UpdateManager(Enum.Text, Mnum.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }

        }

        private void UpdateAddress_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(AddressUpdate.Text))
            {
                MessageBox.Show("Missing Data");
                return;
            }
            int result = controllerObj.UpdateAddress(Enum.Text, AddressUpdate.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }

        }
    }
}
