using System;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public IEmployeeBL employeeBL;

        public EmployeeController(IEmployeeBL employeeBL)
        {
            this.employeeBL = employeeBL;
        }

        [HttpGet]
        public IActionResult GetAllEmployeeDetails()
        {
            try
            {

                var result = this.employeeBL.GetEmployeeDetails();
                if (!result.Equals(null))
                {
                    return this.Ok(new { sucess = true, message = "Records are displayed below succesfully", data = result });
                }
                else
                {
                    return this.NotFound(new { sucess = true, message = "No Records Are Present" });
                }
            }
            catch (Exception e)
            {
                bool success = false;
                return this.BadRequest(new { success, message = e.Message });
            }
        }

       /* [HttpPost]
        public IActionResult AddEmployeeDetails(EmployeeDetails employee)
        {
            try
            {
                bool result = this.employeeBL.AddEmployee(employee);

                if (!result.Equals(false))
                {
                    return this.Ok(new { sucess = true, message = "Record Added" });
                }
                else
                {
                    return this.BadRequest(new { sucess = false, message = "Record Not Added" });
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(new { sucess = false, message = e.Message });
            }
        }*/
    }
}
