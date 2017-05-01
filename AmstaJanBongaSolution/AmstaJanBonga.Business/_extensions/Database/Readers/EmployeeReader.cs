﻿using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using Rlaan.Toolkit.Extensions;
using System;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class EmployeeReader
    {
        #region Entities

        /// <summary>
        /// Gets the employee with the corresponding employee id or null. 
        /// </summary>
        /// <param name="employeeId">The employees unique id.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="colourType">The colour of the employee, default is grey.</param>
        /// <returns></returns>
        public static EmployeeEntity GetEmployeeById(int employeeId)
        {
            return new EmployeeEntity(employeeId);
        }

        /// <summary>
        /// Gets the employee with the corresponding employee id or null.
        /// </summary>
        /// <param name="employeeId">The employees unique id.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="colourType">The colour of the employee, default is grey.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static EmployeeEntity GetEmployeeById(int employeeId, bool throwExceptionWhenNotFound)
        {
            var employee = GetEmployeeById(employeeId);

            if (employee.IsNew && throwExceptionWhenNotFound)
                throw new Exception("Employee not found by id {0}.".FormatString(employeeId));

            return employee;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Returns a collection of all the employees.
        /// </summary>
        /// <returns></returns>
        public static EmployeeCollection GetAllEmployees()
        {
            var employees = new EmployeeCollection();
            employees.GetMulti(null, 0);

            return employees;
        }

        #endregion
    }
}