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

        public int Insert_Employee(string [] employee_details)
        {
            string query = "INSERT INTO Employee Values('"+employee_details[0] + "',";
            for(int i = 1; i<9; i++)
            {
                if(employee_details[i].ToUpper()=="NULL")
                {
                    query += employee_details[i] + ",";
                }
                else
                {
                    query += "'" + employee_details[i] + "',";
                }
            }
            if (employee_details[9].ToUpper() == "NULL")
            {
                query += employee_details[9] + ")";
            }
            else
            {
                query +="'" +employee_details[9] + "')";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteProject(int Pnum)
        {
            string query = "DELETE FROM Project WHERE Pnumber ='" + Pnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateAll(string Enum,string Mnum, string Dnum,String Salary , String Address)
        {
            string query = "update Employee set Super_SSN ='"+ Mnum +"' , Dno = '" + Dnum + "' , Address = '"+ Address+"',Salary = '"+Salary + "'where SSN ='" + Enum + "';" ;
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateManager(string Enum, string Mnum)
        {
            string query = "update Employee set Super_SSN ='" + Mnum + "'where SSN ='" + Enum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateSalary(string Enum,String Salary)
        {
            string query = "update Employee set Salary ='" + Salary + "' where SSN ='" + Enum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateDepartment(string Enum, string Dnum)
        {
            string query = "update Employee set Dno ='" + Dnum + "'where SSN ='" + Enum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAddress(string Enum, String Address)
        {
            string query = "update Employee set Address ='" +Address + "'where SSN ='" + Enum + "';";
            return dbMan.ExecuteNonQuery(query);
        }





        public DataTable SelectAllEmployees(int Dnum)
        {
            string query = "SELECT * FROM Employee WHERE Dno ='"+Dnum+"';";
            return dbMan.ExecuteReader(query);
        }

        public int CountProjects(int Pnum)
        {
            string query = "SELECT COUNT(Essn) FROM Works_On Where Pno='"+ Pnum + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
