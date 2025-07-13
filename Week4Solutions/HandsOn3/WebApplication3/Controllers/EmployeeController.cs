using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Sai",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { DeptId = 1, DeptName = "IT" },
                    Skills = new List<Skill> {
                        new Skill { SkillId = 1, SkillName = "C#" },
                        new Skill { SkillId = 2, SkillName = "SQL" }
                    },
                    DateOfBirth = new DateTime(1999, 5, 20)
                }
            };
        }

        [HttpGet("GetStandard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            //throw new Exception("Test exception");
            return GetStandardEmployeeList();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Employee emp)
        {
            return Ok(emp);
        }
    }
}
