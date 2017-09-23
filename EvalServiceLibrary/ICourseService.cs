//-----------------------------------------------------------------------
// <copyright file="ICourseService.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/22/2017 9:51:03 PM</date>
//-----------------------------------------------------------------------
namespace EvalServiceLibrary
{
    using System.Collections.Generic;
    using System.ServiceModel;

    /// <summary>
    /// Interface.
    /// </summary>
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        List<string> GetCourseList();
    }
}
