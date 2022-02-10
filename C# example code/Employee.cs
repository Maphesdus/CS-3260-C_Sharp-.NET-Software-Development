//Project Prolog
//Name:  Brock Ayres
//Project:  Lab Employee Project
//Class:  CS 3260 C#
//Date: Fall Semester
//Purpose: World Wide Wombat Employee thinger.
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace Lab03EmployeeGui
{
    /// <summary>
    /// Creating enumerator for different types of employees
    /// </summary>
    public enum EType { SALARY, SALES, HOURLY, CONTRACT }
    
    /// <summary>
    /// Parent employee class
    /// </summary>
    [Serializable]
    public abstract class Employee
    {
        /// <summary>
        /// Creates a SortedDictionary of strings mapping to Courses
        /// </summary>
        public SortedDictionary<string, Course> CourseDictionary
        {

            get;
            private set; //internally there is access to changing it and externally you don't.
        }

        /// <summary>
        /// Keeps track of which employee id number will be given out next.
        /// </summary>
        private static uint empIDCount = 0;

        /// <summary>
        /// This Employee constructor initializes the object
        /// </summary>
        /// <param name="_empType">Type of employee. Example Hourly employees will always have HOURLY as their EType</param>
        /// <param name="_firstName">First Name of Employee</param>
        /// <param name="_lastName">Last Name of Employee</param>
        public Employee(EType _empType, string _firstName, string _lastName)
        {
            CourseDictionary = new SortedDictionary<string, Course>(); //REMEMBER: the parentheses at the end is calling the constructor

            EmpID = empIDCount++;
            EmpType = _empType;
            FirstName = _firstName;
            LastName = _lastName;
        }

        public abstract bool HasOvertime
        {
            get;
        }

        public abstract bool HasBenefits
        {
            get;
        }

        public abstract bool HasCommission
        {
            get;
        }

        public abstract bool HasEduBenefits
        {
            get;
        }

        /// <summary>
        /// Employee ID
        /// </summary>
        public uint EmpID
        {
            get;

            set;
        }

        /// <summary>
        /// Employee Type - Read Only
        /// </summary>
        public EType EmpType //design pattern problem of parent class depending on the child, and a runtime check of types situation
        {
            get;
        }

        /// <summary>
        /// Employee's first name - Read and Write
        /// </summary>
        public string FirstName
        {
            get;

            set;
        }

        /// <summary>
        /// Employee's last name - Read and Write
        /// </summary>
        public string LastName
        {
            get;

            set;
        }


        public static uint EmpIDCount
        {
            get
            {
                return empIDCount;
            }

            set
            {
                empIDCount = value;
            }
        }

        /// <summary>
        /// Basic ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Employee {EmpID} was created with info: {FirstName}, {LastName}, of type {EmpType}";
        }

        /// <summary>
        /// PLEASE PLEASE PLEASE NO ONE USE THIS, except for testing
        /// </summary>
        public static void resetEmpIDCount()
        {
            empIDCount = 0;
        }

        public enum AddCourseResult { success, gradeNotHighEnough, notEnoughCredits, duplicateCourse}

        /// <summary>
        /// For adding the education benefits to the particular employees SortedDictionary
        /// Does all checking to make sure that the requirements are met to be added.
        /// </summary>
        /// <param name="courseToAdd"></param>
        /// <returns></returns>
        public abstract AddCourseResult AddCourse(Course courseToAdd);
    }


}