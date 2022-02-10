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

namespace Lab03EmployeeGui
{
    [Serializable]
    /// <summary>
    /// The class for the employees that work by the hour.
    /// </summary>
    public sealed class Hourly : Employee
    {
        /// <summary>
        /// Creating an hourly employee object.
        /// 
        /// </summary>
        /// <param name="_hourlyRate">Their pay per hour</param>
        /// <param name="_hoursWorked">Amount of hours worked each week</param>
        /// <param name="_firstName">First Name of the Employee</param>
        /// <param name="_lastName">Last Name of the Employee</param>
        public Hourly(Double _hourlyRate, Double _hoursWorked, string _firstName, string _lastName) 
            : base(EType.HOURLY, _firstName, _lastName)
        {
            //Because all hourly employees have the same EType of HOURLY setting them all to HOURLY
            HourlyRate = _hourlyRate;
            HoursWorked = _hoursWorked;
        }

        /// <summary>
        /// Default property for HourlyRate which is what the employee makes per hour.
        /// </summary>
        public Double HourlyRate//access modifier
        {
            get;
            set;
        }

        public override bool HasOvertime
        {
            get
            {
                return true;
            }
        }

        public override bool HasBenefits
        {
            get
            {
                return false;
            }
        }

        public override bool HasCommission
        {
            get
            {
                return false;
            }
        }

        public override bool HasEduBenefits
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Default property for HoursWorked which is the number of hours worked each week by the employee.
        /// </summary>
        public Double HoursWorked
        {
            get;
            set;
        }

        /// <summary>
        /// Takes in a course and either adds if the course meets the employees requirements or 
        /// gives an error result if the course doesn't meet the requirements and does not add the course.
        /// </summary>
        /// <param name="courseToAdd"></param>
        /// <returns></returns>
        public override AddCourseResult AddCourse(Course courseToAdd)
        {
            const string MIN_GRADE_ALLOWED = "B";
            const int MAX_CREDIT_HOURS = 1;
            //CHANGE int FOR credits to double
            double creditsSoFar = 0;

            if (CourseDictionary.ContainsKey(courseToAdd.CourseID))
            {
                return AddCourseResult.duplicateCourse;
            }

            foreach (var creditCheck in CourseDictionary.Values)
            {
                creditsSoFar += creditCheck.CourseCreditAmount;
            }

            if (creditsSoFar + courseToAdd.CourseCreditAmount > MAX_CREDIT_HOURS)
            {
                return AddCourseResult.notEnoughCredits;
            }

            if (!Course.GradeComparer(courseToAdd.CourseGrade, MIN_GRADE_ALLOWED))
            {
                return AddCourseResult.gradeNotHighEnough;
            }

            CourseDictionary.Add(courseToAdd.CourseID, courseToAdd);
            return AddCourseResult.success;
        }
    }
}