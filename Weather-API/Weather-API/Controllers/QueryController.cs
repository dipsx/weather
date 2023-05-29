using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Weather_API.Controllers
{
    public class QueryController : ApiController
    {
        private List<UserModel> _Users;
        private List<DeptModel> _Depts;
         
        public QueryController() {
            _Users = new List<UserModel>
            {
                new UserModel{ EmpId= 1 , EmpName="emp1", ManagerID=null, DeptId=1,Salary=6000,DOB = new DateTime(1982,1,8)},
                new UserModel{ EmpId= 2 , EmpName="emp2", ManagerID=null, DeptId=5,Salary=6000,DOB =new DateTime(1977,2,21)},
                new UserModel{ EmpId= 3, EmpName="emp3", ManagerID=1, DeptId=1,Salary=2000,DOB=new DateTime(1999,9,8)},
                new UserModel{ EmpId= 4, EmpName="emp4", ManagerID=2, DeptId=5,Salary=2000, DOB=new DateTime(2000,1,6)},
                new UserModel{ EmpId= 5, EmpName="emp5", ManagerID=2, DeptId=1, Salary=1900, DOB=new DateTime(2002,1,1)},
                new UserModel{ EmpId= 6, EmpName="emp6", ManagerID=2,DeptId=5, Salary=null, DOB=null}
            };
            _Depts = new List<DeptModel>
            {
                new DeptModel{ DeptId=1, Permission = "Edit"},
                new DeptModel{ DeptId=1, Permission = "View"},
                new DeptModel{ DeptId=1, Permission = "Create"},
                new DeptModel{ DeptId = 5, Permission = "View"},
                new DeptModel{ DeptId = 5, Permission="Delete" }
            };
        }

        // Increase salary by 10%
        public void IncreaseSalary()
        {

        }

        // Return users has DOB in January
        public List<UserModel> BirthdayInJanuary()
        {
            return new List<UserModel>();
        }


        // Display manager's name
        /*
            empId   empName managerId   managerName
            3       emp3    1           emp1
            4       emp4    2           emp2
            5       emp5    2           emp2
            6       emp6    2           emp2         
         */
        public void DisplayManagers()
        {


        }


        // Display manager's permission
        /*
            empId   empName permissions
            1	    emp1	Edit,View,Create
            2	    emp2	View,Delete
         */
        public void DisplayPermission()
        {

        }

    }


    public class UserModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? ManagerID { get; set; }
        public int DeptId { get; set; }
        public double? Salary { get; set; }
        public DateTime? DOB { get; set; }
    }

    public class DeptModel
    {
        public int DeptId { get; set; }
        public string Permission { get; set; }
    }
}
