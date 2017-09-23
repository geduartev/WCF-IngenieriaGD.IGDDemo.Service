//-----------------------------------------------------------------------
// <copyright file="CourseService.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/22/2017 9:50:18 PM</date>
//-----------------------------------------------------------------------
namespace EvalServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class.
    /// </summary>
    public class CourseService : ICourseService
    {
        public List<string> GetCourseList()
        {
            List<string> courses = new List<string>();
            courses.Add("WCF Fundamentals");
            courses.Add("WF Fundamentals");
            courses.Add("WPF Fundamentals");
            courses.Add("Silverlight Fundamentals");
            return courses;
        }
    }
}