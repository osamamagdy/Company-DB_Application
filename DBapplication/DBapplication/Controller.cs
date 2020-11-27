using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int INSERT_employee(string FName,string minit ,string lName, long ssn,string Bdate,string address,string sex,long salary,long super_ssn,long dno)//insert
        {
            //string query = "INSERT INTO Employee (S#, Name, City, Status) " +
            //  "Values ('" + snum + "','" + sname + "','" + city + "'," + status + ");";






            string query = "INSERT INTO Employee (Fname,Minit,Lname,SSN,Bdate,Address,Sex,Salary,Super_SSN,Dno)  " +
              "Values ('" + FName + "','" + minit + "','" + lName + "','" + ssn + "','" + Bdate+ "','"+ address + "','"+ sex + "','" + salary+ "','" +super_ssn+ "','" + dno  + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Deleteproject(string snum) //delete_project
        {
            string query = "DELETE FROM Project WHERE Pnumber='" + snum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Updateemployee(long ssn,int salary,int D_no,string address,long super_ssn ) //for udate
        {
            string query = "UPDATE Employee SET Salary='" + salary + "',Dno='" + D_no + "',Address='"+ address + "',Super_SSN='"+ super_ssn + "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updateaddress(long ssn,string address) //for udate
        {
            string query = "UPDATE Employee SET Address='" + address +  "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updatesalary(long ssn, long salary) //for udate
        {
            string query = "UPDATE Employee SET Salary='" + salary + "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateSUpper_ssn(long ssn, long supper_ssn) //for udate
        {
            string query = "UPDATE Employee SET Super_SSN='" + supper_ssn + "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Update_DNO(long ssn, long DNO) //for udate
        {
            string query = "UPDATE Employee SET Dno='" + DNO + "' WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Select_emloyees_in_dep(long n)
        {
            string query = "SELECT * FROM Employee WHERE Dno='" + n + "';";
            
            return dbMan.ExecuteReader(query);
        }

        public int Countemloyees(int n)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On WHERE Pno='" + n + "' ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
