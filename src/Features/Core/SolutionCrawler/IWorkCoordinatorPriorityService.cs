// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Host;

namespace Microsoft.CodeAnalysis.SolutionCrawler
{
    internal interface IWorkCoordinatorPriorityService : ILanguageService
    {
        /// <summary>
        /// True if this document is less important than other documents in the project it is 
        /// contained in, and should have work scheduled for it happen after all other documents
        /// in the project.
        /// </summary>
        bool IsLowPriority(Document document);
    }
}
