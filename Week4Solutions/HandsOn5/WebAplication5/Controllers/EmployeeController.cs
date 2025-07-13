using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Authorize(Roles = "Admin,POC")]

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
                },

            };
        }

        [HttpGet("GetStandard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            //throw new Exception("Test exception");
            return GetStandardEmployeeList();
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var employees = GetStandardEmployeeList();
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employee.Name = updatedEmployee.Name;
            employee.Salary = updatedEmployee.Salary;
            employee.Permanent = updatedEmployee.Permanent;
            employee.Department = updatedEmployee.Department;
            employee.Skills = updatedEmployee.Skills;
            employee.DateOfBirth = updatedEmployee.DateOfBirth;

            return Ok(employee);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Employee emp)
        {
            return Ok(emp);
        }
    }
}
