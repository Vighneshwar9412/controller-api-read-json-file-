using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System.Text.Json;
using DemoWebApi1.Models;
using Newtonsoft.Json;

namespace DemoWebApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        /*
      public static List<Employee> Employeelist1 = new List<Employee> {

           new Employee { Id=1,Name="Rahul Gupta",City="Delhi",IsActive=true},
           new Employee { Id=2,Name="Samaira Goel",City="Noida",IsActive=true},
           new Employee { Id=3,Name="Rohit Yadav",City="Pune",IsActive=false},
           new Employee { Id=4,Name="Pulak Sahu",City="Mumbai",IsActive=true}

      };
        */


        static List<Employee> Employeelist = new ListObject().GetEmployees();


        [HttpGet]
        public List<Employee> Get()
        {
            
            return Employeelist;
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            Employee getemployee = Employeelist.Find(e => e.Id == id);

            if (getemployee != null)
            {
                return getemployee;
            
            }
            
            return getemployee;
           // return "No data Found";
        }
        
        [HttpPost("{id},{name},{city}")]
        public List<Employee> Post(int id,string name,string city)
        {
            Employee e = new Employee { Id = id, Name = name, City=city,IsActive=true};
            Employeelist.Add(e);
            return Employeelist;
        }

        [HttpPut("{id}")]
        public List<Employee> Put(int id, string name, string city)
        {


           
            Employee updatedemployee = Employeelist.Find(e => e.Id == id);
            
            
            if(updatedemployee != null)
            {
                updatedemployee.Name = name;
                updatedemployee.City = city;
            }
            
            return Employeelist;
        }

        [HttpDelete("{id}")]
        public List<Employee> Delete(int id)
        {

            Employee deleteemployee = Employeelist.Find(e => e.Id == id);

            if (deleteemployee != null)
            {
                Employeelist.Remove(deleteemployee);
            }
            
            return Employeelist;
        }

    }
    
}
