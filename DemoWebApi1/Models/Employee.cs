using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text.Json;
namespace DemoWebApi1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; } = true;


    }
    
    public class ListObject
    {
        
        public List<Employee> GetEmployees()
        {
           

            string jsonText = File.ReadAllText(@"D:\Ritwik\DemoWebApi1\DemoWebApi1\data.json");

            
            List<Employee> Employeelist = JsonConvert.DeserializeObject<List<Employee>>(jsonText);
           

            return Employeelist;
        }

    }

}