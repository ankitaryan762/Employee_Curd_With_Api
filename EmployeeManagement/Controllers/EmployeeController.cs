﻿
namespace EmployeeManagement.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeModel;
    using Enployee_Manager;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// This is controller 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// this is reference of type IEmpManager
        /// </summary>
        public readonly IEmpManager manager;

        /// <summary>
        /// this is contructor
        /// </summary>
        /// <param name="manager"></param>
        public EmployeeController(IEmpManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// This is method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("Api/AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model_Of_Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Api/DeleteEmployee")]
        public Model_Of_Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Model_Of_Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        [Route("Api/UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <returns></returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
    }
}