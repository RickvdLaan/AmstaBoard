﻿using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.DaoClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Data;

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

        /// <summary>
        /// Gets the employee with the corresponding userId or null.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static EmployeeEntity GetEmployeeByUserId(int userId, bool throwExceptionWhenNotFound)
        {
            var user = new UserEntity(userId);

            var predicate = new PredicateExpression
            {
                EmployeeFields.UserId == userId
            };

            user.GetMultiEmployees(true, predicate);

            if (user.Employees.Count > 1)
                throw new Exception("Multiple employees found with userId: {0}".FormatString(userId));
            else if (user.Employees.Count == 0 && !throwExceptionWhenNotFound)
            {
                if (Authentication.IsAuthenticated)
                    Authentication.Utility.SignOut();

                return null;
            }
            else if (user.Employees.Count == 0 && throwExceptionWhenNotFound)
            {
                if (Authentication.IsAuthenticated)
                    Authentication.Utility.SignOut();

                throw new Exception("No employee found for userId: {0}.".FormatString(userId));
            }

            return user.Employees[0];
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

        public static EmployeeCollection GetAllEmployeesByLivingroomId(int livingroomId)
        {
            // Collection
            var employees = new EmployeeCollection();

            // Predicate
            var predicate = new PredicateExpression
            {
                EmployeeFields.LivingroomId == livingroomId
            };

            // Sorting
            var sorter = new SortExpression
            {
                EmployeeFields.FirstName | SortOperator.Ascending
            };

            // Get
            employees.GetMulti(predicate, 0, sorter);

            // Return
            return employees;
        }

        /// <summary>
        /// Returns a collection of all the patients joined with the livingroom relation.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllEmployeesJoinedWithLivingroom()
        {
            // The fields in the result.
            var fields = new ResultsetFields(3);
            fields.DefineField(EmployeeFields.Id, 0);
            fields.DefineField(EmployeeFields.FirstName, 1);
            fields.DefineField(LivingroomFields.Name, 2);

            // Add all JOIN clauses from the relation collection.
            var relations = new RelationCollection
            {
                EmployeeEntity.Relations.LivingroomEntityUsingLivingroomId
            };

            // Create the DataTable, DAO and fill the DataTable with the above query definition/parameters.
            var dt = new DataTable();
            var dao = new TypedListDAO();
            dao.GetMultiAsDataTable(fields, dt, 0, null, null, relations, false, null, null, 0, 0);

            // Returns the dataset.
            return dt;
        }

        #endregion
    }
}
