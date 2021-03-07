// //-----------------------------------------------------------------------------
// // <copyright file="FileStrategy.cs" company="DCOM Engineering, LLC">
// //     Copyright (c) DCOM Engineering, LLC.  All rights reserved.
// // </copyright>
// //-----------------------------------------------------------------------------
namespace AkvelonEducationPlan
{
    using System;
    using System.IO;

    public abstract class FileStrategy : Strategy
    {
        public string FilePath { get; } = Path.Combine(Environment.CurrentDirectory, @"Sample.tif");
    }
}