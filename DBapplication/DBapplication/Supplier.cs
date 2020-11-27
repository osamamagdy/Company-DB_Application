using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Configuration;//add by esraa
using System.Data.SqlClient;//add by esraa
namespace DBapplication
{
    public partial class Supplier : Form
    {
        static string DBstring = ConfigurationManager.ConnectionStrings["DBapplication.Properties.Settings.Setting"].ConnectionString;
        SqlConnection con = new SqlConnection(DBstring);//add by esraa
        Controller controllerObj;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        //private void insertButton_Click(object sender, EventArgs e)
        //{
        //    // It is good to use Int16.TryParse first to check if the entered 'status' is a number
        //    // You should valaidate from the beginning that entered value to be integer.
        //    int result = controllerObj.InsertSupplier(sNumTextBox.Text, sNameTextBox.Text, cityTextBox.Text, Int16.Parse(statusTextBox.Text));
        //    if (result == 0)
        //    {
        //        MessageBox.Show("The insertion of a new Supplier failed");
        //    }
        //    else
        //    {
        //        MessageBox.Show("The row is inserted successfully!");
        //    }
        //}

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    int result = controllerObj.DeleteSupplier(sNumDelTextBox.Text);
        //    if (result == 0)
        //    {
        //        MessageBox.Show("No rows are deleted");
        //    }
        //    else
        //    {
        //        MessageBox.Show("The row is deleted successfully!");
        //    }
        //}

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    int result = controllerObj.UpdateSupplier(sNumUpdateTextBox.Text, cityUpdateTextBox.Text);
        //    if (result == 0)
        //    {
        //        MessageBox.Show("No rows are updated");
        //    }
        //    else
        //    {
        //        MessageBox.Show("The row is updated successfully");
        //    }
        //}

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text.Length==0||textBox7.Text.Length==0||textBox6.Text.Length==0||textBox5.Text.Length==0)
            {
                MessageBox.Show("The insertion of a new supplier failed");
                return;

            }
            int result = controllerObj.INSERT_employee(textBox1.Text,textBox7.Text,textBox6.Text,Int64.Parse(textBox5.Text),textBox4.Text,textBox3.Text,comboBox1.Text,Int64.Parse(textBox2.Text),Int64.Parse(textBox9.Text),Int64.Parse(textBox8.Text));

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new supplier failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int result = controllerObj.Updateemployee(Int64.Parse(textBox5.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox8.Text),textBox3.Text,Convert.ToInt64(textBox9.Text));
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }



        }

        private void button3_Click(object sender, EventArgs e)//to show in grid
        {
            DataTable dt = controllerObj.Select_emloyees_in_dep(Convert.ToInt64(textBox10.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //for delete project
        {
            int result = controllerObj.Deleteproject(textBox11.Text);
            if (result == 0)
            {
                MessageBox.Show("The Project not Deleted");
            }
            else
            {
                MessageBox.Show("The project is deleted successfully");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void button5_Click(object sender, EventArgs e) //number of employees
        {
            
            textBox12.Text= Convert.ToString(controllerObj.Countemloyees(Convert.ToInt32(textBox11.Text)));
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)

        {
            if(textBox5.Text.Length==0||textBox3.Text.Length==0)
            {
                MessageBox.Show(" Update failed");
                    return;
            }
            int result = controllerObj.Updateaddress(Int64.Parse(textBox5.Text),textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show(" Update failed");
                    return;
            }
            int result = controllerObj.Updatesalary(Int64.Parse(textBox5.Text),Int64.Parse(textBox2.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0 || textBox9.Text.Length == 0)
            {
                MessageBox.Show(" Update failed");
                    return;
            }
            int result = controllerObj.UpdateSUpper_ssn(Int64.Parse(textBox5.Text),Int64.Parse(textBox9.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0 || textBox8.Text.Length == 0)
            {
                MessageBox.Show(" Update failed");
                    return;
            }
            int result = controllerObj.Update_DNO(Int64.Parse(textBox5.Text),Int64.Parse(textBox8.Text));
        }

        //private void selectAllButton_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = controllerObj.SelectAllSuppliers();
        //    suppliersDataGrid.DataSource = dt;
        //    suppliersDataGrid.Refresh();


        //}

        //private void countButton_Click(object sender, EventArgs e)
        //{
        //    countTextBox.Text = controllerObj.CountSuppliers().ToString();
        //}
    }
}
